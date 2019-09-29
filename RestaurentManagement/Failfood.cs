using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurentManagement.Function1;
using System.Data.SqlClient;

namespace RestaurentManagement
{
    public partial class Failfood : Form
    {
        private int userid = 0;
        public Failfood(int _userid)
        {
            userid = _userid;
            InitializeComponent();
        }
        private Connect con = null;
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string where1="1=1";
        private void Failfood_Load(object sender, EventArgs e)
        {
            con = new Connect();
            con.GetComBoxAll("Select ID,FoodGroupName from R_FoodGroup", cbfoodgroup);
            con.GetComBoxAll("Select ID,FoodName from R_Foods", cbfoodname);
            GetTable(where1);
            if (dgvFailfood.RowCount > 1)
            {
                dgvFailfood.CurrentCell.Selected = false;
            }
        }



        private void cbfoodgroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con = new Connect();
            if (Convert.ToInt32(cbfoodgroup.SelectedValue)>0)
            { 
            con.GetComBoxx("Select ID,FoodName from R_Foods where GroupID='" + Convert.ToInt32(cbfoodgroup.SelectedValue) + "'", cbfoodname);
            }
            else
            {
                con.GetComBoxAll("Select ID,FoodName from R_Foods", cbfoodname);
            }
            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,FoodName from R_Foods where GroupID='" + Convert.ToInt32(cbfoodgroup.SelectedValue) + "'");
            if (dt.Rows.Count == 0)
            {
                cbfoodname.Text = "";
            }
        }
        private void GetTable(string where)
        {
            con = new Connect();
            //dgvFailfood.DataSource = null;

            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,(Select FoodName from R_Foods where ID=rff.FoodID) as 'FoodName',Quantity,(Select PackName from R_Packs where ID=(Select PackUnit from R_Foods where ID=rff.FoodID)) as 'Packs',DateCreate from R_FailFood rff where "+where+"");
            dgvFailfood.DataSource = dt;
            dgvFailfood.Columns[0].HeaderText = "Mã ID";
            dgvFailfood.Columns[1].HeaderText = "Tên thực phẩm";
            dgvFailfood.Columns[2].HeaderText = "Thực phẩm hỏng";
            dgvFailfood.Columns[3].HeaderText = "Tính theo";
            dgvFailfood.Columns[4].HeaderText = "Ngày tạo";
            dt.Dispose();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtquantity.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng thực phẩm hỏng", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbfoodname.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Bạn chưa nhập thực phẩm", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
            con = new Connect();
            txtfailID.Text = String.Empty;
            DataTable dt = new DataTable();
            dt = con.laybang("Select Warehousing from R_Foods where ID='" + Convert.ToInt32(cbfoodname.SelectedValue) + "'");
            string WareNew = (Convert.ToDecimal(dt.Rows[0]["Warehousing"].ToString()) - Convert.ToDecimal(txtquantity.Text)).ToString();
            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            int kq1 = con.xulydulieu("Update R_Foods set Warehousing='" + WareNew + "' where ID='" + Convert.ToInt32(cbfoodname.SelectedValue) + "'");
            
            int kq = con.ExecStore("[RES_Insert_FailFood]", new string[] { "@DateCreate", "@Quantity", "@foodif" }, new object[] { DateTime.Now.ToString("dd/MM/yyy HH:mm"), txtquantity.Text, Convert.ToInt32(cbfoodname.SelectedValue) });
            if (kq > 0)
            {
                MessageBox.Show("Bạn đã thêm mới thành công");
                GetTable(where1);
                con.Ghilog("Thêm mới thực phẩm hỏng",userid);
            }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtfailID.Text == "" || txtfailID.Text==null)
            {
                MessageBox.Show("Bạn chưa chọn thực phẩm muốn sửa", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtquantity.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng thực phẩm hỏng", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbfoodname.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Bạn chưa nhập thực phẩm", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select Quantity,(Select Warehousing from R_Foods where ID=R_FailFood.FoodID) as 'Warehousing' from R_FailFood where ID='" + Convert.ToInt32(txtfailID.Text) + "'");
            Decimal wareNew;
            if (dt.Rows.Count > 0)
            {
                if (txtquantity.TextLength > 0)
                {
                    Decimal wawe = Convert.ToDecimal(dt.Rows[0]["Warehousing"].ToString());
                    Decimal quantity = Convert.ToDecimal(dt.Rows[0]["Quantity"].ToString());
                    wareNew = Convert.ToDecimal(dt.Rows[0]["Warehousing"].ToString()) + Convert.ToDecimal(dt.Rows[0]["Quantity"].ToString()) - Convert.ToDecimal(txtquantity.Text);
                    int kq1 = con.xulydulieu("Update R_Foods set Warehousing='" + wareNew.ToString().Trim() + "' where ID='" + Convert.ToInt32(cbfoodname.SelectedValue) + "'");
                }
            }
            int kq = con.ExecStore("RES_Update_FailFood", new string[] { "@ID", "@Quantity" }, new object[] { Convert.ToInt32(txtfailID.Text), txtquantity.Text.ToString().Trim() });
            if (kq > 0)
            {
                MessageBox.Show("Bạn đã sửa mới thành công");
                cbfoodname.Text = "";
                GetTable(where1);
                con.Ghilog("Sửa số lượng thực phẩm hỏng của thực phẩm số:'"+txtfailID.Text.Trim()+"'",userid);
            }
            else
            {
                MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
            }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtfailID.Text == "" || txtfailID.Text == null )
            {
                MessageBox.Show("Bạn chưa chọn thực phẩm muốn xóa", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new Connect();
                DataTable dt = new DataTable();
                dt = con.laybang("Select Quantity,(Select Warehousing from R_Foods where ID=R_FailFood.FoodID) as 'Warehousing' from R_FailFood where ID='" + Convert.ToInt32(txtfailID.Text) + "'");
                Decimal wareNew;
                if (dt.Rows.Count > 0)
                {
                    if (txtquantity.TextLength > 0)
                    {
                        Decimal wawe = Convert.ToDecimal(dt.Rows[0]["Warehousing"].ToString());
                        Decimal quantity = Convert.ToDecimal(dt.Rows[0]["Quantity"].ToString());
                        wareNew = Convert.ToDecimal(dt.Rows[0]["Warehousing"].ToString()) + Convert.ToDecimal(dt.Rows[0]["Quantity"].ToString());
                        int kq1 = con.xulydulieu("Update R_Foods set Warehousing='" + wareNew.ToString().Trim() + "' where ID='" + Convert.ToInt32(cbfoodname.SelectedValue) + "'");
                    }
                }
                int kq = con.xulydulieu("Delete from R_FailFood where ID='" + Convert.ToInt32(txtfailID.Text) + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    GetTable(where1);
                    con.Ghilog("Xóa thực phẩm hỏng số:'" + txtfailID.Text.Trim() + "'", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void dgvFailfood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvFailfood.Rows[e.RowIndex];
                txtfailID.Text = datagridview.Cells[0].Value.ToString();
                cbfoodname.Text = datagridview.Cells[1].Value.ToString();
                txtquantity.Text = datagridview.Cells[2].Value.ToString().Trim();
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string where2 = null;
            where2 = "1=1";
            if(Convert.ToInt32(cbfoodname.SelectedValue)>0)
            {
                where2 += " and FoodID='" + Convert.ToInt32(cbfoodname.SelectedValue) + "'";
            }
            where2 += " and DateCreate >= convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) ";
            where2 += " and DateCreate <= convert(datetime,'" + Convert.ToDateTime(dtTo.Value).ToString("dd/MM/yyyy") + " 23:59:59',103) ";
            GetTable(where2);
            
        }
    }
}

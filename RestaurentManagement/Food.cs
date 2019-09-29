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
using System.Globalization;

namespace RestaurentManagement
{
    public partial class Food : Form
    {
        private int userid = 0;
        public Food(int _userid)
        {
            userid = _userid;
            InitializeComponent();
        }
        private Connect con = null;
        private string _where = "1=1";
        private void Food_Load(object sender, EventArgs e)
        {
            GetComBoxPack();
            GetComBoxGroup();
            GetTable(_where);
            if (dgvFood.RowCount > 1)
            {
                dgvFood.CurrentCell.Selected = false;
            }
        }
        private void GetTable(string where)
        {
            con = new Connect();
            dgvFood.DataSource = null;

            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,FoodName,Warehousing,(select PackName from R_Packs where R_Packs.ID= R_Foods.PackUnit),(select FoodGroupName from R_FoodGroup where R_FoodGroup.ID=R_Foods.GroupID ),Price, Describle from R_Foods where "+where+"");
            dgvFood.DataSource = dt;
            dgvFood.Columns[0].HeaderText = "Mã thực phẩm";
            dgvFood.Columns[1].HeaderText = "Tên thực phẩm";
            dgvFood.Columns[2].HeaderText = "Số lượng kho";
            dgvFood.Columns[3].HeaderText = "Loại thực phẩm";
            dgvFood.Columns[4].HeaderText = "Mục thực phẩm";
            dgvFood.Columns[5].HeaderText = "Giá thực phẩm";
            dgvFood.Columns[6].HeaderText = "Mô tả";
            dt.Dispose();
        }
        private void GetComBoxGroup()
        {
            con = new Connect();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = con.con;
            mysqlcommand.CommandText = "select ID,FoodGroupName from R_FoodGroup";
            con.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbgroup.DataSource = table_MK;
            cbgroup.DisplayMember = table_MK.Columns["FoodGroupName"].ToString();
            cbgroup.ValueMember = table_MK.Columns["ID"].ToString();
            con.con.Close();
        }
        private void GetComBoxPack()
        {
            con = new Connect();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = con.con;
            mysqlcommand.CommandText = "select ID,PackName from R_Packs";
            con.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbpack.DataSource = table_MK;
            cbpack.DisplayMember = table_MK.Columns["PackName"].ToString();
            cbpack.ValueMember = table_MK.Columns["ID"].ToString();
            con.con.Close();
        }
        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvFood.Rows[e.RowIndex];
                txtFoodID.Text = datagridview.Cells[0].Value.ToString();
                txtFoodName.Text = datagridview.Cells[1].Value.ToString();
                txtquantity.Text = datagridview.Cells[2].Value.ToString().Trim();
                cbpack.Text = datagridview.Cells[3].Value.ToString();
                cbgroup.Text = datagridview.Cells[4].Value.ToString();
                txtPrice.Text = datagridview.Cells[5].Value.ToString().Trim();
                txtdes.Text = datagridview.Cells[6].Value.ToString();
            }
            catch { }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new Connect();
                txtFoodID.Text = String.Empty;
                string price = "0";
                string quantity = "0";
                if(txtPrice.Text!="")
                { 
                price = txtPrice.Text.Replace(",", "");
                }
               if(txtquantity.Text!="")
               {
                   quantity = txtquantity.Text.Trim();
               }
                int kq = con.ExecStore("[RES_Insert_Food]", new string[] { "@FoodName", "@GroupID", "@Price", "@Describle", "@PackUnit", "@Warehousing" }, new object[] { txtFoodName.Text, Convert.ToInt32(cbgroup.SelectedValue.ToString()), price, txtdes.Text, Convert.ToInt32(cbpack.SelectedValue.ToString()),quantity });
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã thêm mới thành công");
                    GetTable(_where);
                    con.Ghilog("Thêm mới thực phẩm",userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm thực phẩm", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtFoodID.Text == "" || txtFoodID.Text==null)
            {
                MessageBox.Show("Bạn chưa chọn thực phẩm", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string quantity = "0";
                if (txtquantity.Text!="")
                {
                    quantity = txtquantity.Text.Trim();
                }
                string price = "0";
                if(txtPrice.Text!="")
                {
                    price = txtPrice.Text.Replace(",", "");
                }
                int kq = con.ExecStore("RES_Update_Food", new string[] { "@ID", "@FoodName", "@GroupID", "@Price", "@Describle", "@PackUnit", "@Warehousing" }, new object[] { Convert.ToInt32(txtFoodID.Text), txtFoodName.Text, Convert.ToInt32(cbgroup.SelectedValue.ToString()), price, txtdes.Text, Convert.ToInt32(cbpack.SelectedValue.ToString()),quantity });
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã sửa mới thành công");
                    GetTable(_where);
                    con.Ghilog("Sửa thực phẩm số :'"+txtFoodID.Text.Trim()+"'", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtFoodID.Text != "" && txtFoodID.Text != null)
            {
                int kq = con.xulydulieu("DELETE FROM R_Foods WHERE ID='" + Convert.ToInt32(txtFoodID.Text) + "'");

                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    GetTable(_where);
                    con.Ghilog("Xóa thực phẩm số:'"+txtFoodID.Text.Trim()+"'", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thực phẩm cần xóa.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
          
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.Text = con.GetTextBoxCurency(this.txtPrice);
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.';
        }

        private void txtSerach_KeyPress(object sender, KeyPressEventArgs e)
        {
            string wherename = "1=1";
            if (txtSerach.TextLength > 0)
            {
                wherename += " and  R_Foods.FoodName Like N'%" + txtSerach.Text + "%'";
            }
            GetTable(wherename);
        }
    }
}

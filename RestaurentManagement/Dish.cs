using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurentManagement.Function1;

namespace RestaurentManagement
{
    public partial class Dish : Form
    {
        private string where = "1=1";
        private int userid = 0;
        public Dish(int _userid)
        {
            InitializeComponent();
            userid = _userid;
        }
        Connect con = null;
        private void btnadd_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtDishName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string price = txtdishprice.Text.Replace(",", "");
                lblID.Text = String.Empty;
                int kq = con.xulydulieu("INSERT INTO R_Dish (DishName,Price,GroupID, Describle,PackID,Search) VALUES (N'" + txtDishName.Text + "', N'" + price + "','" + cbdishgroup.SelectedValue.ToString() + "',N'" + txtDishDescrible.Text + "','"+cbPackDish.SelectedValue.ToString().Trim()+"',N'"+txtDishID.Text.Trim()+"')");
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã thêm mới thành công");
                    GetTable(where);
                    con.Ghilog("Thêm mới món ăn",userid);
                    txtDishID.Text = "";
                    txtDishName.Text = "";
                    txtdishprice.Text = "";
                    txtDishDescrible.Text = "";
                    lblID.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }
        private void GetTable(string where2)
        {
            con = new Connect();
            //dgvDish.DataSource = null;
            
            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,DishName,(select PackNameDish from R_PackDish where ID=R_Dish.PackID) as 'PackNameDish',Price,(select DishGroupName from R_DishGroup where R_DishGroup.ID=R_Dish.GroupID ) as 'DishGroupName', Describle,Search from R_Dish where " + where2 + "");
            dgvDish.DataSource = dt;
            //dgvDish.Columns[0].HeaderText = "Mã món ăn";
            //dgvDish.Columns[1].HeaderText = "Tên món ăn";
            //dgvDish.Columns[2].HeaderText = "Đơn vị tính";
            //dgvDish.Columns[3].HeaderText = "Giá món ăn";
            //dgvDish.Columns[4].HeaderText = "Mục món ăn";
            //dgvDish.Columns[5].HeaderText = "Mô tả";
            //dgvDish.Columns[6].HeaderText = "Mã TK";
            dt.Dispose();

        }

        private void GetComBox()
        {
            con = new Connect();
            con.GetComBoxx("select ID,DishGroupName from R_DishGroup",cbdishgroup);
            con.GetComBoxx("select ID,PackNameDish from R_PackDish ", cbPackDish);
        }
        private void Dish_Load(object sender, EventArgs e)
        {
            GetComBox();
            GetTable(where);
            if (dgvDish.RowCount > 1)
            {
                dgvDish.CurrentCell.Selected = false;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtDishName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else if (lblID.Text == "" || lblID.Text==null)
            {
                MessageBox.Show("Bạn chưa chọn món ăn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                string price = txtdishprice.Text.Replace(",", "");
                int kq = con.xulydulieu("UPDATE R_Dish SET Search=N'"+txtDishID.Text+"',DishName=N'" + txtDishName.Text + "',Price=N'" + price + "',GroupID=N'" + cbdishgroup.SelectedValue.ToString() + "', Describle=N'" + txtDishDescrible.Text + "',PackID='"+cbPackDish.SelectedValue.ToString()+"' WHERE ID='" + Convert.ToInt32(lblID.Text) + "'");
                if (kq > 0)
                {
                    GetTable(where);
                    MessageBox.Show("Bạn đã sửa mới thành công");
                    con.Ghilog("Thay đổi món ăn mã:'"+lblID.Text.Trim()+"'",userid);
                    
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
            if (lblID.Text != "" && lblID.Text != null)
            {
                int kq = con.xulydulieu("DELETE FROM R_Dish WHERE ID='" + Convert.ToInt32(lblID.Text) + "'");

                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    GetTable(where);
                    con.Ghilog("Xóa món ăn:'" + txtDishName.Text.Trim() + "'", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn món ăn cần xóa.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvDish.Rows[e.RowIndex];
                lblID.Text = datagridview.Cells[0].Value.ToString();
                txtDishName.Text = datagridview.Cells[1].Value.ToString();
                cbPackDish.Text = datagridview.Cells[2].Value.ToString();
                txtdishprice.Text = datagridview.Cells[3].Value.ToString();
                cbdishgroup.Text = datagridview.Cells[4].Value.ToString();
                txtDishDescrible.Text = datagridview.Cells[5].Value.ToString();
                txtDishID.Text = datagridview.Cells[6].Value.ToString();
            }
            catch { }
        }

        private void txtdishprice_TextChanged(object sender, EventArgs e)
        {
            con= new Connect();
            txtdishprice.Text = con.GetTextBoxCurency(txtdishprice);
        }

        private void txtdishprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            if(lblID.Text!="")
            {
                int dishid = Convert.ToInt32(lblID.Text);
            DishFood dishfood = new DishFood(dishid,userid);
            //frmdetaol.MdiParent = this;
            DialogResult dr = dishfood.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                dishfood.Close();
            }
            else if (dr == DialogResult.OK)
            {
                dishfood.Close();
            }
            }
                else
            {
                MessageBox.Show("Bạn chưa chọn món ăn cần thêm thực phẩm.");
            }
                }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            string where1 = null;
            where1 += where;
            if (cbdishgroup.SelectedValue !=null)
            { 
            where1 += " and GroupID="+Convert.ToInt32(cbdishgroup.SelectedValue)+"";
            }
            if(txtDishName.TextLength>0)
            {
                where1 +=" and DishName Like N'%"+txtDishName.Text+"%'";
            }
            if(txtDishID.Text!="")
            {
                where1 += " and Search Like N'%" + txtDishName.Text + "%'";
            }
            GetTable(where1);
        }

        private void Dish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con = new Connect();
                if (txtDishName.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên món ăn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string price = txtdishprice.Text.Replace(",", "");
                    lblID.Text = String.Empty;
                    int kq = con.xulydulieu("INSERT INTO R_Dish (DishName,Price,GroupID, Describle,PackID) VALUES (N'" + txtDishName.Text + "', N'" + price + "','" + cbdishgroup.SelectedValue.ToString() + "',N'" + txtDishDescrible.Text + "','" + cbPackDish.SelectedValue.ToString().Trim() + "')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã thêm mới thành công");
                        GetTable(where);
                        con.Ghilog("Thêm mới món ăn", userid);
                        txtDishName.Text = "";
                        txtdishprice.Text = "";
                        txtDishDescrible.Text = "";
                        lblID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                    }
                }
            }
        }
    }
}

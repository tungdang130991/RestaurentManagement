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

namespace RestaurentManagement
{
    public partial class GroupFood : Form
    {
        private Connect con = null;
        private int userid = 0;
        public GroupFood(int _userid)
        {
            userid = _userid;
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm thực phẩm", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtFoodID.Text = String.Empty;
                int kq = con.xulydulieu("INSERT INTO R_FoodGroup (FoodGroupName, Describle) VALUES (N'" + txtFoodName.Text + "', N'" + txtFoodDescrible.Text + "')");
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã thêm mới thành công");
                    GetTable();
                    con.Ghilog("Thêm mới nhóm thực phẩm", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }
       
       
        private void GetTable()
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select * from R_FoodGroup");
            dgvGroupFood.DataSource = dt;
            dgvGroupFood.Columns[0].HeaderText = "Mã mục";
            dgvGroupFood.Columns[1].HeaderText = "Mục món ăn";
            dgvGroupFood.Columns[2].HeaderText = "Mô tả";
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtFoodID.Text != "" && txtFoodID.Text != null)
            {
                int kq = con.xulydulieu("DELETE FROM R_FoodGroup WHERE ID='" + Convert.ToInt32(txtFoodID.Text) + "'");

                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    GetTable();
                    con.Ghilog("Xóa nhóm thực phẩm số:'"+txtFoodID.Text.Trim()+"'", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhóm thực phẩm cần xóa.");
            }
        }
        

        private void btnedit_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtFoodID.Text == "" || txtFoodID.Text == null)
            {
                MessageBox.Show("Bạn chưa chọn nhóm thực phẩm", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtFoodName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm thực phẩm", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int kq = con.xulydulieu("UPDATE R_FoodGroup SET FoodGroupName=N'" + txtFoodName.Text + "', Describle=N'" + txtFoodDescrible.Text + "' WHERE ID='" + Convert.ToInt32(txtFoodID.Text) + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã sửa mới thành công");
                    GetTable();
                    con.Ghilog("Sửa nhóm thực phẩm số:'" + txtFoodID.Text.Trim() + "'", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGroupFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvGroupFood.Rows[e.RowIndex];
                txtFoodID.Text = datagridview.Cells[0].Value.ToString();
                txtFoodName.Text = datagridview.Cells[1].Value.ToString();
                txtFoodDescrible.Text = datagridview.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void GroupFood_Load(object sender, EventArgs e)
        {
            
            GetTable();
            if (dgvGroupFood.RowCount > 1)
            {
                dgvGroupFood.CurrentCell.Selected = false;
            }
        }

    }
}

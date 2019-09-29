using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurentManagement.Function1;

namespace RestaurentManagement
{
    public partial class PackDish : Form
    {
        private int userid = 0;
        public PackDish(int _userid)
        {
            userid = _userid;
            InitializeComponent();
        }
        Connect con = null;
        private void btnadd_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị tính", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtFoodID.Text = String.Empty;
                int kq = con.ExecStore("[RES_Insert_AddPackDish]", new string[] { "@PackName", "@Describle" }, new object[] { txtFoodName.Text, txtFoodDescrible.Text });
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã thêm mới thành công");
                    GetTable();
                    con.Ghilog("Thêm mới đơn vị tính", userid);
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
            dt = con.laybang("Select * from R_PackDish");
            dgvPacks.DataSource = dt;
            dgvPacks.Columns[0].HeaderText = "Mã Loại";
            dgvPacks.Columns[1].HeaderText = "Tên loại";
            dgvPacks.Columns[2].HeaderText = "Mô tả";
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtFoodID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn vị tính", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtFoodName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị tính", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int kq = con.ExecStore("[RES_Update_PackDish]", new string[] { "@ID", "@PackName", "@Describle" }, new object[] { Convert.ToInt32(txtFoodID.Text), txtFoodName.Text, txtFoodDescrible.Text });
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã sửa mới thành công");
                    GetTable();
                    con.Ghilog("Sửa đơn vị tính mã: " + txtFoodID.Text.Trim() + "", userid);
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
                int kq = con.xulydulieu("DELETE FROM R_PackDish WHERE ID='" + Convert.ToInt32(txtFoodID.Text) + "'");

                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    GetTable();
                    con.Ghilog("Xóa đơn vị tính: " + txtFoodName.Text.Trim() + "", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn vị tính cần xóa.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPacks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvPacks.Rows[e.RowIndex];
                txtFoodID.Text = datagridview.Cells[0].Value.ToString();
                txtFoodName.Text = datagridview.Cells[1].Value.ToString();
                txtFoodDescrible.Text = datagridview.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void PackDish_Load(object sender, EventArgs e)
        {
            GetTable();
        }
    }
}

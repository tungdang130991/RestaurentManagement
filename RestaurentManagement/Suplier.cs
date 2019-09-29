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
    public partial class Suplier : Form
    {
        Connect con = null;
        private int userid = 0;
        public Suplier(int _userID)
        {
            userid = _userID;
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtSuplierName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new Connect();
                txtSuplierID.Text = String.Empty;
                int kq = con.ExecStore("[RES_Insert_Supplier]", new string[] { "@SupplierName", "@Describle", "@Address", "@PhoneNumber", "@Email" }, new object[] { txtSuplierName.Text, txtdes.Text, txtAddress.Text, txtphone.Text,txtemail.Text });
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã thêm mới thành công");
                    GetTable();
                    con.Ghilog("Thêm mới nhà cung cấp",userid);
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
           
             if (txtSuplierID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtSuplierName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int kq = con.ExecStore("RES_Update_BillImport", new string[] { "@ID", "@SupplierName", "@Describle", "@Address", "@PhoneNumber", "@Email" }, new object[] { Convert.ToInt32(txtSuplierID.Text), txtSuplierName.Text, txtdes.Text, txtAddress.Text, txtphone.Text,txtemail.Text });
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã sửa mới thành công");
                    GetTable();
                    con.Ghilog("Sửa nhà cung cấp mã:'"+txtSuplierID.Text.Trim()+"'",userid);
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
            if (txtSuplierID.Text != "" && txtSuplierID.Text != null)
            {
                int kq = con.xulydulieu("DELETE FROM R_Supplier WHERE ID='" + Convert.ToInt32(txtSuplierID.Text) + "'");

                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    GetTable();
                    con.Ghilog("Xóa nhà cung cấp: "+txtSuplierName.Text+"",userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp cần xóa.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetTable()
        {
            con = new Connect();
            dgvSupplier.DataSource = null;

            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,SupplierName,PhoneNumber,Address,Email,Describle from R_Supplier");
            dgvSupplier.DataSource = dt;
            dgvSupplier.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvSupplier.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvSupplier.Columns[2].HeaderText = "Số điện thoại";
            dgvSupplier.Columns[3].HeaderText = "Địa chỉ";
            dgvSupplier.Columns[4].HeaderText = "Email";
            dgvSupplier.Columns[5].HeaderText = "Mô tả";
            dt.Dispose();
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvSupplier.Rows[e.RowIndex];
                txtSuplierID.Text = datagridview.Cells[0].Value.ToString();
                txtSuplierName.Text = datagridview.Cells[1].Value.ToString();
                txtphone.Text = datagridview.Cells[2].Value.ToString();
                txtAddress.Text = datagridview.Cells[3].Value.ToString();
                txtemail.Text = datagridview.Cells[4].Value.ToString();
                txtdes.Text = datagridview.Cells[5].Value.ToString();
            }
            catch { }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void Suplier_Load(object sender, EventArgs e)
        {
            GetTable();
            if (dgvSupplier.RowCount > 1)
            {
                dgvSupplier.CurrentCell.Selected = false;
            }
        }
    }
}

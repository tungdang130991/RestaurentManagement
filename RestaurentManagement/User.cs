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
    public partial class User : Form
    {
        private int iduser = 0;
        public User(int _userid)
        {
            iduser = _userid;
            InitializeComponent();
        }
        Connect con = null;
        private void User_Load(object sender, EventArgs e)
        {
            GetTable();
            if (dgvUser.RowCount > 1)
            {
                dgvUser.CurrentCell.Selected = false;
            }
           
        }
        private void buttondouble_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtaccount.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                else if(txtpassword.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                else if(txtpassagain.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                 else if(txtpassagain.Text!= txtpassword.Text)
            {
                MessageBox.Show("Bạn nhập lại mật khẩu sai", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new Connect();
                string password = con.EncodePasswordToBase64(txtpassword.Text);
                int kq = con.GetIDExStore("[RES_Insert_User]", new string[] { "@Account", "@Password", "@UserFullName", "@Position", "@Phone", "@Address", "@UserActive" }, new object[] { txtaccount.Text, password, txtfullname.Text, txtposition.Text, txtphone.Text, txtaddress.Text, 1 });
                     if(checkBox1.Checked==true)
                     {
                         int k1 = con.xulydulieu("Update R_User set Status=1 where ID='"+kq+"'");
                     }
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã thêm mới thành công");
                    GetTable();
                    con.Ghilog("Thêm mới người dùng",iduser);
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
            dt = con.laybang("Select UserName,UserFullName,Position,Address,Phone,ID from R_User");
            dgvUser.DataSource = dt;
            dgvUser.Columns[0].HeaderText = "Tài khoản";
            dgvUser.Columns[1].HeaderText = "Tên người dùng";
            dgvUser.Columns[2].HeaderText = "Vị trí";
            dgvUser.Columns[3].HeaderText = "Địa chỉ";
            dgvUser.Columns[4].HeaderText = "Số điện thoại";
            dgvUser.Columns[5].HeaderText = "Mã ID";
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 ;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(lbliduser.Text!="" && lbliduser.Text!= null)
            { 
            con = new Connect();
            int kq = con.xulydulieu("Delete from R_User where ID='"+Convert.ToInt32(lbliduser.Text)+"'");
            if (kq > 0)
            {
                MessageBox.Show("Bạn đã xóa thành công");
                GetTable();
                con.Ghilog("Xóa người dùng: "+txtaccount.Text.Trim()+"",iduser);
            }
            else
            {
                MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
            }
            }
            else 
            {
                MessageBox.Show("Bạn chưa chọn người dùng", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvUser.Rows[e.RowIndex];
                txtaccount.Text = datagridview.Cells[0].Value.ToString();
                txtfullname.Text = datagridview.Cells[1].Value.ToString();
                txtposition.Text = datagridview.Cells[2].Value.ToString();
                txtaddress.Text = datagridview.Cells[3].Value.ToString();
                txtphone.Text = datagridview.Cells[4].Value.ToString();
                lbliduser.Text = datagridview.Cells[5].Value.ToString();
            }
            catch { }
        }

       


    }
}

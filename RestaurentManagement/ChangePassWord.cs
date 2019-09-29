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
    public partial class ChangePassWord : Form
    {
        private int idd = 0;
        public ChangePassWord( int userid)
        {
            InitializeComponent();
            idd = userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select Password from R_User where ID='"+idd+"'");
            string passolder = dt.Rows[0]["Password"].ToString();

            if (txtpassolder.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtpassnew.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mới mật khẩu", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtpassagain.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtpassagain.Text != txtpassnew.Text)
            {
                MessageBox.Show("Bạn nhập lại mật khẩu sai", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (con.EncodePasswordToBase64(txtpassolder.Text) != passolder)
            {
                MessageBox.Show("Bạn nhập sai mật khẩu cũ", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string passnew = con.EncodePasswordToBase64(txtpassnew.Text);
                int kq = con.xulydulieu("Update R_User set Password='"+passnew+"' where ID='"+idd+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã đổi mới thành công");
                    con.Ghilog("Thay đổi password", idd);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

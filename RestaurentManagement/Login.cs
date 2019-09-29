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
    public partial class Login : Form
    {
        
        public static string role;
        Connect con = null;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tài khoản hoặc Mật khẩu", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new Connect();
                int check = 0;
                DataTable table = null;
                table = new DataTable();
                table = con.laybang("SELECT * from R_User");
                DataRow mr = null;

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    try
                    {
                        mr = table.Rows[i];
                        string password = con.EncodePasswordToBase64(txtPass.Text);
                        string passwordnew = mr["Password"].ToString();
                        string user = mr["UserName"].ToString();
                        if (txtUser.Text == mr["UserName"].ToString() && password == mr["Password"].ToString())
                        {
                            check = 1;
                            this.Hide();
                            int userid = Convert.ToInt32(mr["ID"].ToString());
                            RestaurentManagementSystem main = new RestaurentManagementSystem(userid);
                            main.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                if (check == 0)
                {
                    MessageBox.Show("Tài khoản hoặc Mật khẩu chưa đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //User user = new User(1);
            //DialogResult dr = user.ShowDialog(this);
            //if (dr == DialogResult.Cancel)
            //{
            //    user.Close();
            //}
            //else if (dr == DialogResult.OK)
            //{
            //    user.Close();
            //}
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

       
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Please, Input Username or Password!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con = new Connect();
                    int check = 0;
                    DataTable table = null;
                    table = new DataTable();
                    table = con.laybang("SELECT * from R_User");
                    DataRow mr = null;

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        try
                        {
                            mr = table.Rows[i];
                            string password = con.EncodePasswordToBase64(txtPass.Text);
                            string passwordnew = mr["Password"].ToString();
                            string user = mr["UserName"].ToString();
                            if (txtUser.Text == mr["UserName"].ToString() && password == mr["Password"].ToString())
                            {
                                check = 1;
                                this.Hide();
                                int userid = Convert.ToInt32(mr["ID"].ToString());
                                RestaurentManagementSystem main = new RestaurentManagementSystem(userid);
                                main.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }

                    }
                    if (check == 0)
                    {
                        MessageBox.Show("UserName or Password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




    }
}

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
    public partial class Customer : Form
    {
        Connect con = null;
        private int id = 0;
        private string tablenumber = "";
        private int userid = 0;
        public Customer(int cusid,string _tablenumber,int _userid)
        {
            id = cusid;
            tablenumber = _tablenumber;
            userid = _userid;
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            con = new Connect();
            int kq = con.ExecStore("RES_Update_Customer", new string[] { "@ID", "@CustomerName", "@Phone" }, new object[] { id, txtname.Text, txtphone.Text });
            if (kq > 0)
            {
                MessageBox.Show("Bạn đã lưu thành công");
                con.Ghilog("Lưu khách hàng đặt của bàn số: "+tablenumber+"",userid);
            }
            else
            {
                MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt=con.laybang("Select * from R_Customer where ID='"+id+"'");
            lblTime.Text = Convert.ToDateTime(dt.Rows[0]["DateCreate"].ToString()).ToString("dd/MM/yyyy HH:mm");
            txtname.Text = dt.Rows[0]["CustomerName"].ToString();
            txtphone.Text = dt.Rows[0]["Phone"].ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

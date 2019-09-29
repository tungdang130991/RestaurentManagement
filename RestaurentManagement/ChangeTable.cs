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
    public partial class ChangeTable : Form
    {
        private int id = 0;
        private string _tablenumber = "";
        private int userid = 0;
        private Connect con = null;
        public delegate void PassControl(string tablenew1);
        public PassControl passControl;
        public ChangeTable(int idd,string tablenumber,int _userid)
        {
            InitializeComponent();
            id = idd;
            _tablenumber = tablenumber;
            userid = _userid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            //GiaodichBanhang gdbh = new GiaodichBanhang();
            //gdbh.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,Status,TableOrder,(Select MAX(CustomerID) from R_CustomerTable where TableID=(Select ID from R_Tables where TableNumber='" + _tablenumber + "')) as 'Customer' from R_Tables where TableNumber='" + _tablenumber + "'");
             string status = dt.Rows[0]["Status"].ToString();
            string order = dt.Rows[0]["TableOrder"].ToString();
            if (status == "True")
            {
                int kq = con.ExecStore("Res_Update_ChangeTable", new string[] { "@billid", "@tablenumber", "@tableidnew" }, new object[] { id, _tablenumber, Convert.ToInt32(cbtablenumber.SelectedValue.ToString()) });
                //int kq3 = con.xulydulieu("Delete from R_BillTable where TableID=(Select ID from R_Tables where TableNumber='" + _tablenumber + "') and BillID='"+id+"'");
                //int kq4 = con.xulydulieu("insert into R_BillTable(TableID,BillID) values ('" + Convert.ToInt32(cbtablenumber.SelectedValue.ToString()) + "' ,'" + id + "')");
                int kq1 = con.xulydulieu("UPDATE R_Tables SET Status=0,TableOrder=0 WHERE TableNumber='" + _tablenumber + "'");
                int kq2 = con.xulydulieu("UPDATE R_Tables SET Status=1,TableOrder=0 WHERE ID='" + Convert.ToInt32(cbtablenumber.SelectedValue.ToString()) + "'");
                int kq6 = con.xulydulieu("Delete from R_CustomerTable where TableID='" + Convert.ToInt32(cbtablenumber.SelectedValue.ToString()) + "'");
               
                if (kq > 0 && kq1 > 0 && kq2 > 0)
                {

                    MessageBox.Show("Bạn đã sửa mới thành công");
                    con.Ghilog("Thay đổi từ bàn " + _tablenumber + " sang bàn " + cbtablenumber.Text + " của hóa đơn số:'"+id+"''",userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            else if(order=="True")
            {
                int id1 = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                int customer = Convert.ToInt32(dt.Rows[0]["Customer"].ToString());
                int kq6 = con.xulydulieu("Delete from R_CustomerTable where TableID='" + Convert.ToInt32(cbtablenumber.SelectedValue.ToString()) + "'");
                int kq5 = con.ExecStore("RES_Update_CustomerTable", new string[] { "@TableId", "@CustomerID", "@TableIDOlder " }, new object[] { Convert.ToInt32(cbtablenumber.SelectedValue.ToString()), customer,id1 });
                int kq3 = con.xulydulieu("Update R_Tables SET TableOrder=0 where TableNumber='" + _tablenumber + "'");
                int kq4 = con.xulydulieu("Update R_Tables set TableOrder=1 where ID='" + Convert.ToInt32(cbtablenumber.SelectedValue.ToString()) + "'");
                if (kq3 > 0 && kq4 > 0)
                {

                    MessageBox.Show("Bạn đã sửa mới thành công");
                    con.Ghilog("Thay đổi từ bàn " + _tablenumber + " sang bàn " + cbtablenumber.Text + "",userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            
            if (passControl != null)
            {
                passControl(cbtablenumber.Text );
            }
            this.Close();
        }
        private void GetComBox()
        {
            con = new Connect();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = con.con;
            mysqlcommand.CommandText = "select ID,TableNumber from R_Tables where Status=0";
            con.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbtablenumber.DataSource = table_MK;
            cbtablenumber.DisplayMember = table_MK.Columns["TableNumber"].ToString();
            cbtablenumber.ValueMember = table_MK.Columns["ID"].ToString();
            con.con.Close();
        }

        private void ChangeTable_Load(object sender, EventArgs e)
        {
            GetComBox();
            lblTableNumber.Text = _tablenumber;
        }
    }
}

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
    public partial class ReasonLose : Form
    {
        public delegate void PassControl();
        public PassControl passControl;
        private string tablename = "";
        Connect con = null;
        private int billid=0;
        private int userid = 0;
        public ReasonLose(string tabname,int bill,int _user)
        {
            billid = bill;
            userid = _user;
            tablename = tabname;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtReason.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập lý do hủy bàn!");
            }
            else
            {
                con = new Connect();
                int kq = con.ExecStore("[RES_Insert_ReasonLose]", new string[] { "@TableName", "@DateCreate", "@Reason" }, new object[] { tablename, DateTime.Now, txtReason.Text });
                DataTable _Dt = new DataTable();
                int kq1 = con.ExecStore("Res_Update_R_Table", new string[] { "@TableNumber" }, new object[] { tablename });
                int kq2 = con.xulydulieu("Delete from R_BillTable where BillID='" + billid + "' and TableID=(select ID from R_Tables where TableNumber='" + tablename + "')");
                _Dt = con.laybang("Select TableID from R_BillTable where BillID= '" + billid + "'");
                if (_Dt.Rows.Count == 0)
                {
                    int kq3 = con.xulydulieu("Delete from R_Bill where ID='" + billid + "'");
                }
                con.Ghilog("Hủy bàn " + tablename + "", userid);
                if(kq>0)
                {
                    if (passControl != null)
                    {
                        passControl();
                    }
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReasonLose_Load(object sender, EventArgs e)
        {

        }

    }
}

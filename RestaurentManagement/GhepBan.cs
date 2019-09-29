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
    public partial class GhepBan : Form
    {
        private int billid = 0;
        private string tablenumber = "";
        private int userid = 0;
        Connect con = null;
        public delegate void PassControl(string tablenew1);
        public PassControl passControl;
        public GhepBan(int _billid,string _tablenumber,int _userid)
        {
            billid = _billid;
            tablenumber = _tablenumber;
            userid = _userid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbtablenumber.Text!="")
                { 
                con = new Connect();
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                dt = con.ExecStoreTable("RES_Select_BillID", new string[] { "@idtable" }, new object[] { Convert.ToInt32(cbtablenumber.SelectedValue) });
                int _billother = Convert.ToInt32(dt.Rows[0]["column1"].ToString());
               
                dt1 = con.laybang("Select * from R_BillDish where BillID='"+billid+"'");
                dt2 = con.laybang("Select * from R_BillDish where BillID='" + _billother + "'");
                for(int i=0;i<dt1.Rows.Count;i++)
                {
                    int ggg = 0;
                    int dishid1 = Convert.ToInt32(dt1.Rows[i]["DishID"].ToString());
                    Decimal quantity1 = Convert.ToDecimal(dt1.Rows[i]["Quantity"].ToString());
                    Decimal quantitynew = 0;
                    for(int k=0;k<dt2.Rows.Count;k++)
                    {
                        Decimal quantity2=Convert.ToDecimal(dt2.Rows[k]["Quantity"].ToString());
                        int dishid2 = Convert.ToInt32(dt2.Rows[k]["DishID"].ToString());
                        if(dishid1==dishid2)
                        {
                            ggg = 1;
                            quantitynew = quantity1 + quantity2;
                            break;

                        }
                    }
                    if(ggg==1)
                    {
                        int kq5 = con.xulydulieu("Update R_BillDish set Quantity='" + quantitynew + "' where BillID='" + _billother + "' and DishID='"+dishid1+"'");
                        int kq6 = con.xulydulieu("Delete from R_BillDish where BillID='"+billid+"' and DishID='"+dishid1+"'");
                    }
                    else
                    {
                        int kq1 = con.xulydulieu("Update R_BillDish set BillID='" + _billother + "' where BillID='" + billid + "' and DishID='"+dishid1+"'");
                    }
                }
                int kq8 = con.xulydulieu("Delete from R_Bill where ID='"+billid+"'");
                int kq = con.xulydulieu("Delete from R_BillTable where TableID='" + Convert.ToInt32(Idtable(tablenumber)) + "' and BillID='" + billid + "'");
                int kq2=con.xulydulieu("Update R_Tables set Status=0 where ID='"+Idtable(tablenumber) +"'");
                if (kq2>0)
                {

                    MessageBox.Show("Bạn đã sửa mới thành công");
                    con.Ghilog("Ghép từ bàn " + tablenumber + " sang bàn " + cbtablenumber.Text + "", userid);
                    if (passControl != null)
                    {
                        passControl(cbtablenumber.Text);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private int Idtable(string _tblnumber)
        {
            int id10 = 0;
            con = new Connect();
            DataTable dt = null;
            dt = new DataTable();
            dt = con.laybang("Select ID from R_Tables where TableNumber='" + _tblnumber + "'");
            id10 = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            return id10;
        }
        private void GhepBan_Load(object sender, EventArgs e)
        {
            con = new Connect();
            lblTableNumber.Text = tablenumber;
            con.GetComBoxx("Select ID,TableNumber from R_Tables where Status=1 and ID<>'" + Idtable(tablenumber) + "'", cbtablenumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

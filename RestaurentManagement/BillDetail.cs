using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurentManagement.Function1;
using System.Data.SqlClient;
using System.Globalization;

namespace RestaurentManagement
{
    public partial class BillDetail : Form
    {
        public delegate void PassControl();
        public PassControl passControl;

        private int idd1 = 0;
        private int userid = 0;
        Connect con = null;
        public BillDetail(int idd,int useridd)
        {
            InitializeComponent();
            idd1 = idd;
            userid = useridd;
        }
        private void BillDetail_Load(object sender, EventArgs e)
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select Status from R_Bill where ID='"+idd1+"'");
            if(dt.Rows[0]["Status"].ToString()=="False")
            {
                button2.Enabled = false;
            }
            if(SetAdmin()==1)
            {
                dgvbill.Enabled = false;
                txtreceive.Enabled = false;
                txtSale.Enabled = false;
                txtsalepercen.Enabled = false;
                txtNote.Enabled = false;
            }
            GetTableDish();
            BindData();
            if (dgvbill.RowCount > 1)
            {
                dgvbill.CurrentCell.Selected = false;
            }
        }
        private int SetAdmin()
        {
            int status = 0;
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select Status from R_Bill where ID='" + idd1 + "'");
            DataTable _dt = new DataTable();
            _dt=con.laybang("Select Status from R_User where ID='"+userid+"'");
            string Statusbill = dt.Rows[0]["Status"].ToString();
            string Statususer = _dt.Rows[0]["Status"].ToString();
            if(Statusbill=="False" && Statususer!="True")
            {
                status=1;
            }
            return status;
        }
        private void BindData()
        {
            lblbillnumber.Text = "000" + idd1.ToString();
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select * from R_Bill where ID='" + idd1 + "'");
            lblbilldate.Text = Convert.ToDateTime(dt.Rows[0]["DateCreate"]).ToString("dd/MM/yyyy");
            txttimecome.Text = Convert.ToDateTime(dt.Rows[0]["DateCreate"]).ToString("HH:mm");
            txttimepay.Text = Convert.ToDateTime(dt.Rows[0]["DateEnd"]).ToString("HH:mm");
            string moneyreceive = dt.Rows[0]["Moneyreceive"].ToString().Trim();
            if (moneyreceive != "")
            {
                txtreceive.Text = dt.Rows[0]["Moneyreceive"].ToString();
                txtreturn.Text = dt.Rows[0]["MoneyReturn"].ToString();
                txtTotal.Text = dt.Rows[0]["TotalEnd"].ToString();
                txtSale.Text = dt.Rows[0]["Sale"].ToString();
            }
            else
            {
                txtTotal.Text = txtTotals.Text;
                txtreceive.Text = txtTotals.Text; 
                Decimal moneys = Convert.ToDecimal(txtTotals.Text);
                int kq1 = con.ExecStore("RES_UpdateAllMoneyBill", new string[] { "@Total", "@Moneyreceive", "@TotalEnd", "@ID" }, new object[] { moneys, moneys, moneys, idd1 });
            }
            txtNote.Text = dt.Rows[0]["Note"].ToString();
            Connect con1 = new Connect();
            DataTable _dt = new DataTable();
            _dt = con1.laybang("Select TableNumber from R_Tables Where ID in (Select TableID from R_BillTable where BillID='" + idd1 + "')");
            string tablenumber = null;
            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                tablenumber += _dt.Rows[i]["TableNumber"].ToString() + " ";
            }
            txtTable.Text = tablenumber;


        }
        private void GetTableDish()
        {
            con = new Connect();
            DataTable dt = new DataTable();
            DataTable _dt = new DataTable();
            DataRow dr;
            _dt.Columns.Add(new DataColumn("ID", typeof(int)));
            _dt.Columns.Add(new DataColumn("DishName", typeof(string)));
            _dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
            _dt.Columns.Add(new DataColumn("FoodGroup", typeof(string)));
            _dt.Columns.Add(new DataColumn("Price", typeof(string)));
            dt = con.laybang("Select rbd.DishID as 'Mã món ăn',(Select DishName from R_Dish where ID=rbd.DishID) as 'Tên món ăn',rbd.Quantity as 'Số lượng',(select R_DishGroup.DishGroupName from R_DishGroup where R_DishGroup.ID=(Select GroupID from R_Dish where ID=rbd.DishID)) as 'Nhóm món',(Select Price from R_Dish where ID=rbd.DishID) as 'Giá',rbd.BillID as 'Mã Bill' from R_BillDish rbd where rbd.BillID='" + idd1 + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string pricenew = con.GetStringCurency((Convert.ToDecimal(dt.Rows[i]["Số lượng"].ToString()) * Convert.ToDecimal(dt.Rows[i]["Giá"].ToString())).ToString());
                dr = _dt.NewRow();
                dr[0] = dt.Rows[i].ItemArray[0].ToString();
                dr[1] = dt.Rows[i].ItemArray[1].ToString();
                dr[2] = dt.Rows[i].ItemArray[2].ToString();
                dr[3] = dt.Rows[i].ItemArray[3].ToString();
                dr[4] = pricenew;
                _dt.Rows.Add(dr);
            }

            dgvbill.DataSource = _dt;
            DataTable dt1 = new DataTable();
            dt1 = con.laybang("Select Sale,TotalEnd,MoneyReturn from R_Bill where ID='" + idd1 + "'");
            string sale111 = dt1.Rows[0]["Sale"].ToString().Trim();
            
            Decimal Total = 0;
            Decimal price = 0;
            Decimal quantity = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                price = Convert.ToDecimal(dt.Rows[i]["Giá"].ToString());
                quantity = Convert.ToDecimal(dt.Rows[i]["Số lượng"].ToString(), CultureInfo.InvariantCulture);
                Total += price * quantity;
            }
            if (sale111 == "")
            {
                string vab = Total.ToString();
                txtreceive.Text = vab;
                txtTotal.Text = Total.ToString();
                txtSale.Text = "";
                txtreturn.Text = "";
                txtsalepercen.Text = "";
                int kq = con.xulydulieu("UPDATE R_Bill SET Total='" + Total + "',TotalEnd='" + Total + "',Moneyreceive='" + Total + "' WHERE ID='" + idd1 + "' ");
            }
            else
            {
                string totalend = dt1.Rows[0]["TotalEnd"].ToString().Trim();
                txtreceive.Text = totalend;
                txtTotal.Text = totalend;
                txtreturn.Text = dt1.Rows[0]["MoneyReturn"].ToString().Trim();
                //int kq = con.xulydulieu("UPDATE R_Bill SET Total='" + Total + "',TotalEnd='" + totalend + "',Moneyreceive='" + totalend + "',MoneyReturn=0 WHERE ID='" + idd1 + "' ");
            }
            txtTotals.Text = Total.ToString("0#,0.#");

        }
        private void dgvbill_KeyUp(object sender, KeyEventArgs e)
        {
            con = new Connect();
            if (e.KeyCode == Keys.Enter)
            {

                if (dgvbill.CurrentCell != null)
                {
                    if (dgvbill.CurrentCell.ColumnIndex == 2)
                    {
                        int rowIndex = dgvbill.CurrentCell.RowIndex - 1;
                        DataTable dt = new DataTable();
                        dt = con.laybang("Select DishID from R_BillDish rbd where rbd.BillID='" + idd1 + "'");
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                string quantitynews = "0";
                                if(dgvbill.Rows[i].Cells[2].Value.ToString().Trim()!="")
                                {
                                    quantitynews = dgvbill.Rows[i].Cells[2].Value.ToString().Trim();
                                }
                                int _id = Convert.ToInt32(dgvbill.Rows[i].Cells[0].Value.ToString().Trim());
                                if (Convert.ToDecimal(quantitynews) <= 0)
                                {
                                    int kq1 = con.xulydulieu("DELETE FROM R_BillDish WHERE BillID='" + idd1 + "' and DishID='" + _id + "'");
                                }
                                else
                                {
                                    int kq = con.xulydulieu("Update R_BillDish set Quantity='" + quantitynews + "' where BillID='" + idd1 + "' and DishID='" + _id + "'");
                                }
                            }
                            con.Ghilog("Sửa số lượng món ăn hóa đơn số '" + idd1 + "'", userid);
                        }
                        GetTableDish();
                    }
                }
            }
        }
        private void BillDetail_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string receive = "0";
                string sale = "0";

                con = new Connect();
                DataTable dt = new DataTable();
                dt = con.laybang("Select Total from R_Bill where ID='" + idd1 + "'");
                string total = dt.Rows[0]["Total"].ToString();
                if (txtsalepercen.Text !="")
                {
                    txtSale.Text = ((Convert.ToDecimal(txtsalepercen.Text) * Convert.ToDecimal(total)) / 100).ToString();
                }
                if (txtreceive.Text !="")
                {
                    receive = txtreceive.Text.Replace(",","");
                    int kq = con.ExecStore("[RES_UPdate_BillReceive]", new string[] { "@ID", "@Receive" }, new object[] { idd1, Convert.ToDecimal(receive) });
                    con.Ghilog("Update tiền nhận của khách hóa đơn số:'" + idd1 + "'", userid);
                }
                if (txtSale.TextLength > 0)
                {
                    sale = txtSale.Text.Replace(",","");
                    int kq1 = con.ExecStore("[RES_UPdate_BillSale]", new string[] { "@ID", "@Sale" }, new object[] { idd1, Convert.ToDecimal(sale) });
                    con.Ghilog("Update tiền triết khấu hóa đơn số:'" + idd1 + "'", userid);
                }
                if(txtNote.Text!="")
                {
                    int kq3 = con.ExecStore("[RES_Update_NoteBill]", new string[] { "@ID", "@Note" }, new object[] { idd1,txtNote.Text });
                        
                }

                txtreturn.Text = (Convert.ToDecimal(receive) - Convert.ToDecimal(total) + Convert.ToDecimal(sale)).ToString();
                txtTotal.Text = (Convert.ToDecimal(total) - Convert.ToDecimal(sale)).ToString();
                if (txtTotal.TextLength > 0)
                {
                    string totalend = txtTotal.Text.Replace(",","");
                    string _return = txtreturn.Text.Replace(",","");
                    int kq2 = con.ExecStore("[RES_UPdate_BillTotalEnd]", new string[] { "@ID", "@TotalEnd", "@Return" }, new object[] { idd1, Convert.ToDecimal(totalend), Convert.ToDecimal(_return) });
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con = new Connect();
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvbill.Rows[e.RowIndex];
                txtdish.Text = datagridview.Cells[0].Value.ToString();
            }
            catch { }
        }

        //private void btnedit_Click(object sender, EventArgs e)
        //{
        //    if (txtdish.Text == "" || txtdish.Text == null)
        //    {
        //        MessageBox.Show("Bạn chưa chọn món ăn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        con = new Connect();
        //        if (txtquantity.TextLength > 0 && txtdish.Text != "" && txtdish.Text != null)
        //        {
        //            if (Convert.ToDecimal(txtquantity.Text) > 0)
        //            {
        //                int kq = con.ExecStore("RES_UPdate_BillDishQuantity", new string[] { "@BillID", "@DishID", "@Quantity" }, new object[] { idd1, Convert.ToInt32(txtdish.Text), txtquantity.Text.Trim() });
        //            }
        //            else
        //            {
        //                int kq1 = con.xulydulieu("DELETE FROM R_BillDish WHERE DishID='" + Convert.ToInt32(txtdish.Text) + "' and BillID='" + idd1 + "'");
        //            }
        //            GetTableDish();
        //        }
        //    }
        //}

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        //private void btndelete_Click(object sender, EventArgs e)
        //{
        //    con = new Connect();
        //    if (txtdish.Text != "" && txtdish.Text != null)
        //    {
        //        int kq = con.xulydulieu("DELETE FROM R_BillDish WHERE DishID='" + Convert.ToInt32(txtdish.Text) + "' and BillID='"+idd1+"'");
        //        GetTableDish();
        //    }
        //}

        private void txtreceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txtSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.';
        }

        private void txtSale_TextChanged(object sender, EventArgs e)
        {
            con = new Connect();
            txtSale.Text = con.GetTextBoxCurency(txtSale);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            con = new Connect();
            txtTotal.Text = con.GetTextBoxCurency(txtTotal);
         
           
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select rdf.FoodID,rdf.Quantity as 'QuantityFood',rbd.Quantity as 'QuantityDish',(Select Warehousing from R_Foods where ID=rdf.FoodID) as 'Warehousing' from R_BillDish rbd , R_DishFood rdf where rbd.BillID='" + idd1 + "' and rbd.DishID=rdf.DishID");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Connect _con = new Connect();
                    DataTable _dt = new DataTable();
                    int foodid = Convert.ToInt32(dt.Rows[i]["FoodID"].ToString());
                    Decimal quantityfood = Convert.ToDecimal(dt.Rows[i]["QuantityFood"].ToString(), CultureInfo.InvariantCulture);
                    Decimal quantitydish = Convert.ToDecimal(dt.Rows[i]["QuantityDish"].ToString(), CultureInfo.InvariantCulture);
                    _dt = _con.laybang("Select Warehousing from R_Foods where ID='" + foodid + "'");
                    Decimal Warehousing = Convert.ToDecimal(_dt.Rows[0]["Warehousing"].ToString(), CultureInfo.InvariantCulture);
                    string WarehousingNew = (Warehousing - quantitydish * quantityfood).ToString();
                    int kq = con.xulydulieu("Update R_Foods set Warehousing='" + WarehousingNew + "' where ID='" + foodid + "'");
                }
            }
            int kq1 = con.xulydulieu("Update R_Bill set Status=0,Note=N'" + txtNote.Text + "' where ID ='" + idd1 + "'");
            int kq2 = con.xulydulieu("Update R_Tables set Status=0 where ID in (Select TableID from R_BillTable where BillID ='" + idd1 + "')");
            con.Ghilog("In hóa đơn số:'" + idd1 + "'", userid);

            PrintPreview print = new PrintPreview(idd1);
            DialogResult dr = print.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                print.Close();
            }
            else if (dr == DialogResult.OK)
            {
                print.Close();
            }
            if (passControl != null)
            {
                passControl();
            }
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSale_TextChanged_1(object sender, EventArgs e)
        {
            txtSale.Text = con.GetTextBoxCurency(txtSale);
        }

        private void dgvbill_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvbill.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintPreview print = new PrintPreview(idd1);
            DialogResult dr = print.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                print.Close();
            }
            else if (dr == DialogResult.OK)
            {
                print.Close();
            }
        }

        private void txtreceive_TextChanged(object sender, EventArgs e)
        {
            con = new Connect();
            txtreceive.Text = con.GetTextBoxCurency(txtreceive);
        }

        private void txtreturn_TextChanged(object sender, EventArgs e)
        {
            con = new Connect();
            txtreturn.Text = con.GetTextBoxCurency(txtreturn);
        }

     
    }
}

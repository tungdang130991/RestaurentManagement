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
using System.Data.SqlClient;
using System.Globalization;

namespace RestaurentManagement
{
    public partial class BillImportDetail : Form
    {
        private int billID = 0;
        private int userid = 0;
        Connect con = null;
        public delegate void PassControl();

        public PassControl passControl;
        public BillImportDetail(int billid, int _userid)
        {
            billID = billid;
            userid = _userid;
            InitializeComponent();
        }
        private string where = "1=1";
        private void BillImportDetail_Load(object sender, EventArgs e)
        {
            try
            {
                con = new Connect();
                DataTable dt = new DataTable();
                dt = con.laybang("Select Pay,Owe,(Select SupplierName from R_Supplier where ID=R_BillImport.SupplierID) as 'SupplierName',Describle from R_BillImport where ID='" + billID + "'");
                txtowe.Text = dt.Rows[0]["Owe"].ToString();
                txtthanhtoan.Text = dt.Rows[0]["Pay"].ToString();
                con.GetComBoxx("Select ID,SupplierName from R_Supplier", cbSupplier);
                con.GetComBoxAll("Select ID,FoodGroupName from R_FoodGroup", cbgroupfood);
                if (dt.Rows[0]["SupplierName"].ToString() != "")
                {
                    cbSupplier.Text = dt.Rows[0]["SupplierName"].ToString();
                }
                txtNote.Text = dt.Rows[0]["Describle"].ToString();
                GetTableFood(where);
                GetTableBillFood();
                if (dgvFood.RowCount > 1)
                {
                    dgvFood.CurrentCell.Selected = false;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void GetTableFood(string where)
        {
            try
            {
                con = new Connect();
                //this.dgvFood.DataSource = null;
                //this.dgvFood.Rows.Clear();
                DataTable dt = new DataTable();
                dt = con.laybang("select ID,FoodName,(Select PackName from R_Packs where ID=R_Foods.PackUnit) as 'PackName',(Select FoodGroupName from R_FoodGroup where ID=R_Foods.GroupID) as 'FoodGroupName',Describle from R_Foods where " + where + "");
                dgvFood.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GetTableBillFood()
        {
            con = new Connect();
            DataTable dt = new DataTable();
            try
            {
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("ID1", typeof(int)));
                _dt.Columns.Add(new DataColumn("NameFood", typeof(string)));
                _dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
                _dt.Columns.Add(new DataColumn("PackUnit", typeof(string)));
                _dt.Columns.Add(new DataColumn("Price1", typeof(string)));
                _dt.Columns.Add(new DataColumn("PriceTotal", typeof(string)));
                dt = con.laybang("Select rbf.FoodID,(Select FoodName from R_Foods where ID=rbf.FoodID) as 'FoodName',rbf.Quantity,(Select PackName from R_Packs where ID=(select PackUnit from R_Foods where ID=rbf.FoodID)) as 'PackName',Price from R_FoodBillImport rbf where rbf.BillImportID='" + billID + "'");
                Decimal Total = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string pricenew = "";
                    string price = "";
                    if (dt.Rows[i]["Price"].ToString() != "" && dt.Rows[i]["Price"].ToString() != null)
                    {
                        pricenew = con.GetStringCurency((Convert.ToDecimal(dt.Rows[i]["Quantity"].ToString(), CultureInfo.InvariantCulture) * Convert.ToDecimal(dt.Rows[i]["Price"].ToString())).ToString());
                        price = con.GetStringCurency(dt.Rows[i].ItemArray[4].ToString());
                        Total += Convert.ToDecimal(pricenew.Replace(",",""));
                    }
                    dr = _dt.NewRow();
                    dr[0] = dt.Rows[i].ItemArray[0].ToString();
                    dr[1] = dt.Rows[i].ItemArray[1].ToString();
                    dr[2] = dt.Rows[i].ItemArray[2].ToString();
                    dr[3] = dt.Rows[i].ItemArray[3].ToString();
                    dr[4] = price;
                    dr[5] = pricenew;
                    _dt.Rows.Add(dr);
                }
                dgvbillfood.DataSource = _dt;
                txtTotal.Text = Total.ToString();
                int kq = con.xulydulieu("Update R_BillImport set Total='" + Total.ToString() + "' where ID='" + billID + "'");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            //int Total = 0;
            //int price = 0;
            //int quantity = 0;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    price = Convert.ToInt32(dt.Rows[i]["Giá"].ToString());
            //    quantity = Convert.ToInt32(dt.Rows[i]["Số lượng"].ToString());
            //    Total += price * quantity;
            //}

        }
        private void BillImportDetail_KeyDown(object sender, KeyEventArgs e)
        {
            con = new Connect();
            if (e.KeyCode == Keys.Enter)
            {
                try
                { 
                if (txtthanhtoan.TextLength > 1)
                {
                    txtowe.Text = (Convert.ToDecimal(txtTotal.Text.Replace(",","")) - Convert.ToDecimal(txtthanhtoan.Text.Replace(",",""))).ToString();
                    if (Convert.ToDecimal(txtowe.Text.Replace(",", "")) > 0)
                    {
                        int kq = con.ExecStore("RES_Update_billLiquidate", new string[] { "@ID", "@liquidate", "@owe", "@Status" }, new object[] { billID, Convert.ToDecimal(txtthanhtoan.Text.Replace(",", "")), Convert.ToDecimal(txtowe.Text.Replace(",", "")), '1' });
                    }
                    else
                    {
                        int kq = con.ExecStore("RES_Update_billLiquidate", new string[] { "@ID", "@liquidate", "@owe", "@Status" }, new object[] { billID, Convert.ToDecimal(txtTotal.Text.Replace(",", "")), '0', '0' });
                    }
                }
                if (txtNote.Text != "")
                {
                    int kq = con.xulydulieu("Update R_BillImport set Describle=N'" + txtNote.Text + "' where ID='" + billID + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Đã lưu ghi chú!");
                    }
                }
}
                catch(Exception ex)
                {
                    throw ex;
                }
            }

        }
        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con = new Connect();
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvFood.Rows[e.RowIndex];
                int iddfood = Convert.ToInt32(datagridview.Cells[0].Value.ToString());
                DataTable dt = new DataTable();
                dt = con.laybang("Select Warehousing from R_Foods where ID='" + iddfood + "'");
                DataTable _dt = con.laybang("Select * from R_FoodBillImport where BillImportID='" + billID + "' and FoodID='" + iddfood + "'");
                if (_dt.Rows.Count == 0)
                {
                    int add = con.xulydulieu("INSERT INTO R_FoodBillImport (BillImportID, FoodID,Quantity) VALUES ('" + billID + "', '" + iddfood + "',1)");
                }
                else
                {
                    string quantity111 = _dt.Rows[0]["Quantity"].ToString();
                    Decimal quantity = Convert.ToDecimal(quantity111, CultureInfo.InvariantCulture) + 1;
                    int kq1 = con.xulydulieu("Update R_FoodBillImport set Quantity='" + quantity + "' where BillImportID='" + billID + "' and FoodID='" + iddfood + "'");
                }
                string quantity2 = dt.Rows[0]["Warehousing"].ToString();
                Decimal Warehousing = Convert.ToDecimal(quantity2, CultureInfo.InvariantCulture) + 1;
                int kq = con.xulydulieu("update R_Foods set Warehousing='" + Warehousing.ToString() + "' where ID='" + iddfood + "'");
                GetTableBillFood();
                con.Ghilog("Thêm mới thực phẩm cho hóa đơn nhập số:'" + billID + "'", userid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Where2 = "1=1";
            if (Convert.ToInt32(cbgroupfood.SelectedValue) > 0)
            {
                Where2 += " and GroupID=" + Convert.ToInt32(cbgroupfood.SelectedValue) + " ";
            }
            if (txtname.TextLength > 0)
            {
                Where2 += " and FoodName Like N'%" + txtname.Text + "%'";
            }
            GetTableFood(Where2);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (passControl != null)
            {
                passControl();
            }
            this.Close();

        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbSupplier.SelectedValue) >0)
            { 
            con = new Connect();
            int kq = con.ExecStore("[RES_Update_billSupplier]", new string[] { "@ID", "@SupplierID" }, new object[] { billID, Convert.ToInt32(cbSupplier.SelectedValue) });
            if (kq > 0)
            {
                MessageBox.Show("Bạn đã lưu thành công");
            }
            else
            {
                MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
            }
            con.Ghilog("Thêm nhà cung cấp trong hóa đơn số:'" + billID + "'", userid);
            }
        }

        //private void btnedit_Click(object sender, EventArgs e)
        //{
        //    if (txtFoodID.Text == "" || txtFoodID.Text == null)
        //    {
        //        MessageBox.Show("Bạn chưa chọn thực phẩm", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            con = new Connect();
        //            DataTable dt = new DataTable();
        //            dt = con.laybang("Select Quantity from R_FoodBillImport where FoodID='" + Convert.ToInt32(txtFoodID.Text) + "' and BillImportID='" + billID + "'");
        //            Decimal quantity = Convert.ToDecimal(dt.Rows[0]["Quantity"].ToString());
        //            Connect con1 = new Connect();
        //            DataTable _dt = new DataTable();
        //            _dt = con1.laybang("Select Warehousing from R_Foods where ID='" + Convert.ToInt32(txtFoodID.Text) + "'");
        //            Decimal warehousing = Convert.ToDecimal(_dt.Rows[0]["Warehousing"].ToString()) - quantity + Convert.ToDecimal(txtquantity.Text);
        //            int kq1 = con1.xulydulieu("update R_Foods set Warehousing='" + warehousing.ToString() + "' where ID='" + Convert.ToInt32(txtFoodID.Text) + "'");

        //            if (Convert.ToDecimal(txtquantity.Text) <= 0)
        //            {
        //                int kq2 = con.xulydulieu("Delete from R_FoodBillImport where FoodID='" + Convert.ToInt32(txtFoodID.Text) + "' and BillImportID='" + billID + "'");
        //            }
        //            else
        //            {
        //                int kq = con.xulydulieu("UPDATE R_FoodBillImport SET Quantity=N'" + txtquantity.Text.Trim() + "' WHERE FoodID='" + Convert.ToInt32(txtFoodID.Text) + "' and BillImportID='" + billID + "' ");
        //            }

        //            GetTableBillFood();

        //        }
        //        catch { }
        //    }
        //}





        private void txtowe_TextChanged(object sender, EventArgs e)
        {
            con = new Connect();
            txtowe.Text = con.GetTextBoxCurency(txtowe);
        }

        private void txtthanhtoan_TextChanged(object sender, EventArgs e)
        {
            con = new Connect();
            txtthanhtoan.Text = con.GetTextBoxCurency(txtthanhtoan);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            con = new Connect();
            txtTotal.Text = con.GetTextBoxCurency(txtTotal);
        }

        private void txtthanhtoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Ghilog("In hóa đơn sô:'" + billID + "'", userid);
            BillImportPrint rpbill = new BillImportPrint(billID);
            DialogResult dr = rpbill.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                rpbill.Close();
            }
            else if (dr == DialogResult.OK)
            {
                rpbill.Close();
            }
            this.Close();

        }



        private void dgvbillfood_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con = new Connect();
                try
                {
                    if (dgvbillfood.CurrentCell.ColumnIndex == 2 || dgvbillfood.CurrentCell.ColumnIndex == 4)
                    {
                        DataTable dt1 = new DataTable();
                        dt1 = con.laybang("Select * from R_FoodBillImport where BillImportID='" + billID + "'");
                        if (dt1.Rows.Count > 0)
                        {
                            int jjjj = 0;
                            for (int i = 0; i < dt1.Rows.Count; i++)
                            {
                                int _foodid = Convert.ToInt32(dt1.Rows[i]["FoodID"].ToString());
                                int rowIndex = dgvbillfood.CurrentCell.RowIndex - 1;
                                string quantitynews = "0";
                                if (dgvbillfood.Rows[i].Cells[2].Value.ToString().Trim() != "")
                                {
                                    quantitynews = dgvbillfood.Rows[i].Cells[2].Value.ToString().Trim();
                                }

                                Decimal quantity = Convert.ToDecimal(dt1.Rows[i]["Quantity"].ToString(), CultureInfo.InvariantCulture);
                                Connect con1 = new Connect();
                                DataTable _dt = new DataTable();
                                _dt = con1.laybang("Select Warehousing from R_Foods where ID='" + _foodid + "'");
                                Decimal warehousing = Convert.ToDecimal(_dt.Rows[0]["Warehousing"].ToString(), CultureInfo.InvariantCulture) - quantity + Convert.ToDecimal(quantitynews, CultureInfo.InvariantCulture);
                                int kq1 = con1.xulydulieu("update R_Foods set Warehousing='" + warehousing.ToString() + "' where ID='" + _foodid + "'");
                                if (Convert.ToDecimal(quantitynews) == 0)
                                {
                                    int kq2 = con.xulydulieu("Delete from R_FoodBillImport where FoodID='" + _foodid + "' and BillImportID='" + billID + "'");
                                }
                                else
                                {
                                    int kq = con.xulydulieu("UPDATE R_FoodBillImport SET Quantity=N'" + quantitynews + "' WHERE FoodID='" + _foodid + "' and BillImportID='" + billID + "' ");
                                }
                                //int _foodid = Convert.ToInt32(dgvbillfood.Rows[i].Cells[0].Value.ToString().Trim());
                                if (dgvbillfood.Rows[i].Cells[4].Value.ToString().Trim() != "")
                                {
                                    string price1 = dgvbillfood.Rows[i].Cells[4].Value.ToString().Trim().Replace(",", "");
                                    Decimal price = Convert.ToDecimal(price1);
                                    int kq = con.xulydulieu("Update R_FoodBillImport set Price ='" + price + "' where  FoodID='" + _foodid + "' and BillImportID='" + billID + "'");
                                }
                                else
                                {
                                    jjjj = 1; //MessageBox.Show("Bạn chưa nhập giá tiền cho thực phẩm");
                                }

                            }
                            if(jjjj==1)
                            {
                                MessageBox.Show("Bạn chưa nhập giá tiền cho thực phẩm");
                            }
                            con.Ghilog("Thay đổi số lượng thực phẩm cho hóa đơn số:'" + billID + "'", userid);
                        }
                    }
                    //if (dgvbillfood.CurrentCell.ColumnIndex == 4)
                    //{
                    //    int count111 = dgvbillfood.RowCount - 1;
                    //    if (count111 > 0)
                    //    {
                    //        for (int i = 0; i < count111; i++)
                    //        {
                    //            int _foodid = Convert.ToInt32(dgvbillfood.Rows[i].Cells[0].Value.ToString().Trim());
                    //            if (dgvbillfood.Rows[i].Cells[4].Value.ToString().Trim() != "")
                    //            {
                    //                Decimal price = Convert.ToDecimal(dgvbillfood.Rows[i].Cells[4].Value.ToString().Trim());
                    //                int kq = con.xulydulieu("Update R_FoodBillImport set Price ='" + price + "' where  FoodID='" + _foodid + "' and BillImportID='" + billID + "'");
                    //            }
                    //            else
                    //            {
                    //                MessageBox.Show("Bạn chưa nhập giá tiền cho thực phẩm");
                    //            }
                    //        }
                    //        con.Ghilog("Thay đổi giá thực phẩm trong hóa đơn nhập số'" + billID + "'", userid);
                    //    }
                    //}
                    GetTableBillFood();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        private void dgvbillfood_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Where2 = "1=1";
            if (Convert.ToInt32(cbgroupfood.SelectedValue) > 0)
            {
                Where2 += " and GroupID=" + Convert.ToInt32(cbgroupfood.SelectedValue) + " ";
            }
            if (txtname.TextLength > 0)
            {
                Where2 += " and FoodName Like N'%" + txtname.Text + "%'";
            }
            GetTableFood(Where2);
        }

        private void dgvbillfood_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            e.Control.TextChanged -= new EventHandler(Column1_TextChanged);
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                tb.TextChanged += new EventHandler(Column1_TextChanged);
            }
        }
        private void Column1_TextChanged(object sender, EventArgs e)
        {
            if (dgvbillfood.CurrentCell.ColumnIndex == 4)
            {
            con = new Connect();
            TextBox txt66 = sender as TextBox;
            txt66.Text = con.GetTextBoxCurency(txt66);
                }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

    }
}

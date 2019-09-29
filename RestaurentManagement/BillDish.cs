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
using System.Globalization;
using System.Data.SqlClient;

namespace RestaurentManagement
{
    public partial class BillDish : Form
    {
        private int idd = 0;
        private int userid = 0;
        public delegate void PassControl();
        public PassControl passControl;
        private string tablenumber = "";
        public BillDish(int id,int _userid,string _tablenumber)
        {
            InitializeComponent();
            idd = id;
            tablenumber = _tablenumber;
            userid = _userid;
        }
        private Connect con = null;
        private void BillDish_Load(object sender, EventArgs e)
        {
            con = new Connect();
            con.GetComBoxAll("Select ID,DishGroupName from R_DishGroup", cbgroupdish);
            GetTableDish("1=1");
            GetTableBillDish();
            if (dgvDish.RowCount>1)
            {
            dgvDish.CurrentCell.Selected = false;
                }
            lblTable.Text = tablenumber;

        }
        private void GetTableDish(string where)
        {
            con = new Connect();
            //this.dgvDish.DataSource = null;
            //this.dgvDish.Rows.Clear();
            DataTable dt = new DataTable();
            dt = con.laybang("select rd.ID,rd.DishName,rd.Price,(Select PackNameDish from R_PackDish where ID=rd.PackID) as 'Pack1',(select R_DishGroup.DishGroupName from R_DishGroup where R_DishGroup.ID=rd.GroupID) as 'DishGroupName' from R_Dish rd where " + where + "");
            DataTable _dt = new DataTable();
            DataRow dr;
            _dt.Columns.Add(new DataColumn("ID", typeof(int)));
            _dt.Columns.Add(new DataColumn("DishName", typeof(string)));
            _dt.Columns.Add(new DataColumn("Price", typeof(string)));
            _dt.Columns.Add(new DataColumn("Pack1", typeof(string)));
            _dt.Columns.Add(new DataColumn("DishGroupName", typeof(string)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = _dt.NewRow();
                dr[0] = dt.Rows[i].ItemArray[0].ToString();
                dr[1] = dt.Rows[i].ItemArray[1].ToString();
                dr[2] = con.GetStringCurency(dt.Rows[i].ItemArray[2].ToString());
                dr[3] = dt.Rows[i].ItemArray[3].ToString();
                dr[4] = dt.Rows[i].ItemArray[4].ToString();
                _dt.Rows.Add(dr);
            }
            dgvDish.DataSource = _dt;
        }
        private void GetTableBillDish()
        {
            con = new Connect();
            //this.dgvbilldish.DataSource = null;
            //this.dgvbilldish.Rows.Clear();
            DataTable dt = new DataTable();
            DataTable _dt = new DataTable();
            DataRow dr;
            _dt.Columns.Add(new DataColumn("IDbilldish", typeof(int)));
            _dt.Columns.Add(new DataColumn("NameDish", typeof(string)));
            _dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
            _dt.Columns.Add(new DataColumn("GroupDish", typeof(string)));
            _dt.Columns.Add(new DataColumn("Pricedish", typeof(string)));
            dt = con.laybang("Select rbd.DishID as 'Mã món ăn',(Select DishName from R_Dish where ID=rbd.DishID) as 'Tên món ăn',rbd.Quantity as 'Số lượng',(Select PackNameDish from R_PackDish where ID=(Select PackID from R_Dish where ID=rbd.DishID)) as 'Nhóm món',(Select Price from R_Dish where ID=rbd.DishID) as 'Giá',rbd.BillID as 'Mã Bill' from R_BillDish rbd where rbd.BillID='" + idd + "'");
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

            dgvbilldish.DataSource = _dt;
            Decimal Total = 0;
            Decimal price = 0;
            Decimal quantity = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                price = Convert.ToDecimal(dt.Rows[i]["Giá"].ToString());
                quantity = Convert.ToDecimal(dt.Rows[i]["Số lượng"].ToString(), CultureInfo.InvariantCulture);
                Total += price * quantity;
            }
            int kq = con.xulydulieu("UPDATE R_Bill SET Total='" + Total + "' WHERE ID='" + idd + "' ");
            txtTotal.Text = Total.ToString("0#,0.# VNÐ");
        }
        private void dgvDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con = new Connect();
                DataTable dt = new DataTable();
               
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvDish.Rows[e.RowIndex];
                int iddish = Convert.ToInt32(datagridview.Cells[0].Value.ToString());
                dt = con.laybang("Select * from R_BillDish where BillID='" + idd + "' and DishID='" + iddish + "'");
                if(dt.Rows.Count==0)
                { 
                int add = con.xulydulieu("INSERT INTO R_BillDish (BillID, DishID,Quantity) VALUES ('" + idd + "', '" + iddish + "',1)");
                txtquantity.Text = "1";
                }
                else
                {
                    Decimal quantity = Convert.ToDecimal(dt.Rows[0]["Quantity"].ToString(), CultureInfo.InvariantCulture) + 1;
                    int kq = con.xulydulieu("Update R_BillDish set Quantity='" + quantity + "' where BillID='" + idd + "' and DishID='" + iddish + "'");
                    txtquantity.Text = quantity.ToString();
                }
                GetTableBillDish();
                txtDishID.Text = datagridview.Cells[0].Value.ToString();
                txtDishName.Text = datagridview.Cells[1].Value.ToString();
                
                txtprice.Text = datagridview.Cells[2].Value.ToString();
                con.Ghilog("Thêm món ăn trong hóa đơn số:'" + idd + "'", userid);
            }
            catch { }
        }

        private void dgvbilldish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con = new Connect();
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvbilldish.Rows[e.RowIndex];
                txtDishID.Text = datagridview.Cells[0].Value.ToString();
                txtDishName.Text = datagridview.Cells[1].Value.ToString();
                txtquantity.Text = datagridview.Cells[2].Value.ToString();
                txtprice.Text = datagridview.Cells[4].Value.ToString();
            }
            catch { }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtDishID.Text == "" || txtDishID.Text == null)
            {
                MessageBox.Show("Bạn chưa chọn món ăn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con = new Connect();
                    if (Convert.ToInt32(txtquantity.Text) < 1)
                    {
                        int kq1 = con.xulydulieu("DELETE FROM R_BillDish WHERE BillID='" + idd + "' and DishID='" + Convert.ToInt32(txtDishID.Text) + "'");
                        if (kq1 > 0)
                        {
                            GetTableBillDish();
                        }
                    }
                    else
                    {
                        Decimal totalprice = Convert.ToDecimal(txtquantity.Text, CultureInfo.InvariantCulture) * Convert.ToDecimal(txtprice.Text);
                        int kq = con.xulydulieu("UPDATE R_BillDish SET Quantity=N'" + txtquantity.Text.Trim() + "',TotalPrice='" + totalprice + "' WHERE BillID='" + idd + "' and DishID='" + Convert.ToInt32(txtDishID.Text) + "' ");
                        if (kq > 0)
                        {
                            GetTableBillDish();
                        }
                    }
                    con.Ghilog("Thay đổi số lượng món ăn trong hóa đơn số:'" + idd + "'", userid);


                }
                catch { }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (passControl != null)
            {
                passControl();
            }
            this.Close();
        }

        private void dgvbilldish_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (dgvbilldish.CurrentCell.ColumnIndex == 2)
                    {
                        con = new Connect();
                        DataTable dt = new DataTable();
                       dt = con.laybang("Select DishID from R_BillDish rbd where rbd.BillID='" + idd + "'");
                       if (dt.Rows.Count > 0)
                       {
                           for (int i = 0; i < dt.Rows.Count; i++)
                           {
                               string quantitynews = "0";
                               if( dgvbilldish.Rows[i].Cells[2].Value.ToString().Trim()!="")
                               {
                                  quantitynews= dgvbilldish.Rows[i].Cells[2].Value.ToString().Trim();
                               }
                               int _id = Convert.ToInt32(dgvbilldish.Rows[i].Cells[0].Value.ToString().Trim());
                               txtquantity.Text = quantitynews;
                               if (Convert.ToDecimal(quantitynews) <=0)
                               {
                                   int kq1 = con.xulydulieu("DELETE FROM R_BillDish WHERE BillID='" + idd + "' and DishID='" + _id + "'");
                               }
                               else
                               {
                                   int kq = con.xulydulieu("Update R_BillDish set Quantity='" + quantitynews + "' where BillID='" + idd + "' and DishID='" + _id + "'");
                               }
                           }
                       }
                       con.Ghilog("Thay đổi số lượng món ăn trong hóa đơn số:'" + idd + "'", userid);
                        GetTableBillDish();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wherename = "1=1";
            if (txtname.TextLength > 0)
            {
                wherename += " and rd.DishName Like N'%" + txtname.Text + "%' or rd.Search Like N'%" + txtname.Text + "%'";
            }
            if(Convert.ToInt32(cbgroupdish.SelectedValue)>0)
            {
                wherename += " and rd.GroupID='"+Convert.ToInt32(cbgroupdish.SelectedValue)+"'";
            }

            GetTableDish(wherename);
        }


        private void dgvbilldish_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvbilldish.CurrentCell.ColumnIndex == 2) //Desired Column
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

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            string wherename = "1=1";
            if (txtname.TextLength > 0)
            {
                wherename += " and rd.Search Like N'%" + txtname.Text + "%' or rd.DishName Like N'%" + txtname.Text + "%'";
            }
            if (Convert.ToInt32(cbgroupdish.SelectedValue) > 0)
            {
                wherename += " and rd.GroupID='" + Convert.ToInt32(cbgroupdish.SelectedValue) + "'";
            }

            GetTableDish(wherename);
        }

    }
}

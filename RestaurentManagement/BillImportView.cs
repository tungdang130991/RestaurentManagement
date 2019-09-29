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
    public partial class BillImportView : Form
    {
        private int userid = 0;
        public BillImportView(int _useri)
        {
            userid = _useri;
            InitializeComponent();
        }
        Connect con = null;
        string where1 = "1=1";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetTable(where1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string where2 = null;
            where2 = "1=1 and Status=1";
            GetTable(where2);
        }

        private void BillImportView_Load(object sender, EventArgs e)
        {
            con = new Connect();
            con.GetComBoxAll("Select ID,SupplierName from R_Supplier", comboBox1);
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }
        private void GetTable(string where)
        {
            try
            {
                con = new Connect();
                this.dgvBillImport.DataSource = null;
                this.dgvBillImport.Rows.Clear();
                DataTable dt = new DataTable();
                dt = con.laybang("select ID,DateCreate,(select UserName from R_User where ID=rbi.UserID),Owe,(select SupplierName from R_Supplier where ID=rbi.SupplierID) from R_BillImport rbi where "+where+"");
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("Mã", typeof(int)));
                _dt.Columns.Add(new DataColumn("Ngày Tạo", typeof(string)));
                _dt.Columns.Add(new DataColumn("Người tạo", typeof(string)));
                _dt.Columns.Add(new DataColumn("Còn nợ", typeof(string)));
                _dt.Columns.Add(new DataColumn("Nhà cung cấp", typeof(string)));
                Decimal Total = 0;
                if(dt.Rows.Count>0)
                {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string pricenew = con.GetStringCurency(dt.Rows[i]["Owe"].ToString());
                    dr = _dt.NewRow();
                    dr[0] = dt.Rows[i].ItemArray[0].ToString();
                    dr[1] = Convert.ToDateTime(dt.Rows[i].ItemArray[1]).ToString("dd/MM/yyyy HH:mm");
                    dr[2] = dt.Rows[i].ItemArray[2].ToString();
                    dr[3] = pricenew;
                    dr[4] = dt.Rows[i].ItemArray[4].ToString();
                    _dt.Rows.Add(dr);
                    Total = Total + Convert.ToDecimal(pricenew.Replace(",",""));
                }
                    }

                dgvBillImport.DataSource = _dt;
                txtTotalOwe.Text = con.GetStringCurency(Total.ToString());
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string where2 = null;
            if(radioButton1.Checked == true)
            { 
            where2 = "SupplierID='"+Convert.ToInt32(comboBox1.SelectedValue)+"'";
            GetTable(where2);
            }
            else
            {
                where2 = "SupplierID='" + Convert.ToInt32(comboBox1.SelectedValue) + "' and Status=1";
                GetTable(where2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,Owe,Total,Pay from R_BillImport where Status=1 and SupplierID='" + Convert.ToInt32(comboBox1.SelectedValue) + "'");
            if(txtOwe.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập số tiền thanh toán!");
            }
            else if(comboBox1.SelectedValue.ToString().Trim()=="0")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp!");
            }
            else
            {
                Decimal PayOwe =Convert.ToDecimal(txtOwe.Text.Replace(",",""));
                if(dt.Rows.Count>0)
                { 
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    int id1 = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    Decimal Owe = Convert.ToDecimal(dt.Rows[i]["Owe"].ToString());
                    string total = dt.Rows[i]["Total"].ToString();
                    Decimal pay = Convert.ToDecimal(dt.Rows[i]["Pay"].ToString());
                    PayOwe = PayOwe - Owe;
                    if(PayOwe>=0)
                    {
                        int kq1 = con.xulydulieu("Update R_BillImport set Status=0,Owe=0,Pay='"+total+"' where ID='"+id1+"'");
                    }
                    else
                    {
                        PayOwe = 0 - PayOwe;
                        pay = pay + Owe - PayOwe;
                        int kq1 = con.xulydulieu("Update R_BillImport set Owe='"+PayOwe+"',Pay='"+pay+"' where ID='" + id1 + "'");
                        break;
                    }
                }
                con.Ghilog("Thanh toán tiền nợ cho Nhà cung cấp:'" + comboBox1.Text + "'", userid);
                }
                string where2 = null;
                where2 = "SupplierID='" + Convert.ToInt32(comboBox1.SelectedValue) + "' and Status=1";
                GetTable(where2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked==false)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nợ");
            }
            else if(comboBox1.SelectedValue.ToString().Trim()=="0")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp muốn thanh toán");
            }
            else
            {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,Owe,Total from R_BillImport where Status=1 and SupplierID='" + Convert.ToInt32(comboBox1.SelectedValue) + "'");
            if(dt.Rows.Count>0)
            {

                int kq = con.xulydulieu("Update R_BillImport set Status=0,Owe=0,Pay='" + Convert.ToDecimal(dt.Rows[0]["Total"].ToString()) + "' where Status=1 and SupplierID='" + Convert.ToInt32(comboBox1.SelectedValue) + "'");
                string where2 = null;
                where2 = "SupplierID='" + Convert.ToInt32(comboBox1.SelectedValue) + "' and Status=1";
                GetTable(where2);
                con.Ghilog("Xóa hết nợ của nhà cung cấp "+comboBox1.Text+"",userid);
            }

            }
        }

        private void dgvBillImport_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con = new Connect();
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvBillImport.Rows[e.RowIndex];
                int idbill=Convert.ToInt32(datagridview.Cells[0].Value.ToString());
                if(idbill>=0)
                {
                    BillImportDetail billimport = new BillImportDetail(idbill, userid);
                DialogResult dr = billimport.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    billimport.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    billimport.Close();
                }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void dgvBillImport_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if(e.RowIndex!=-1)
                {
                    try
                    {
                        DataGridViewRow datagridview = new DataGridViewRow();
                        datagridview = dgvBillImport.Rows[e.RowIndex];
                        int idbill = Convert.ToInt32(datagridview.Cells[0].Value.ToString());
                        ContextMenuStrip Menu = new ContextMenuStrip();
                        ToolStripMenuItem MenuOpenPO = new ToolStripMenuItem();
                        MenuOpenPO.MouseDown += new MouseEventHandler(MenuOpenPO_Click);
                        MenuOpenPO.Text = "Xem chi tiet";
                        MenuOpenPO.Name = "" + idbill + "";
                        Menu.Items.AddRange(new ToolStripItem[] { MenuOpenPO });

                        //Assign created context menu strip to the DataGridView
                        dgvBillImport.ContextMenuStrip = Menu;
                    }
                    catch (Exception ex)
                    { throw ex; }
                    }
            }
            else
                dgvBillImport.ContextMenuStrip = null;
        }
        private void MenuOpenPO_Click(object sender, EventArgs e)
        {
            con =new Connect();
            ToolStripMenuItem idd10 = sender as ToolStripMenuItem;
            int id = Convert.ToInt32(idd10.Name);
            con.Ghilog("Xem chi tiết hóa đơn nhập số:'"+id+"'",userid);
            BillImportDetail billimport = new BillImportDetail(id,userid);
            DialogResult dr = billimport.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                billimport.Close();
            }
            else if (dr == DialogResult.OK)
            {
                billimport.Close();
            }
        }

        private void txtOwe_TextChanged(object sender, EventArgs e)
        {
            con = new Connect();
            txtOwe.Text = con.GetTextBoxCurency(txtOwe);
        }

        private void txtOwe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 ;
        }
    }
}

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
    public partial class ListBillImport : Form
    {
        Connect con = null;
        private int userid1 = 0;
        public ListBillImport(int userid)
        {
            userid1 = userid;
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con = new Connect();
            int billiid = con.GetIDExStore("[RES_Insert_BillImport]", new string[] { "@UserID","@Status" }, new object[] { userid1, 0 });
            con.Ghilog("Thêm mới hóa đơn",userid1);
            BillImportDetail billimport = new BillImportDetail(billiid,userid1);
            billimport.passControl = new BillImportDetail.PassControl(GetTable);
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
        private void GetTable()
        {
            try
            {
                con = new Connect();
                this.dgvbill.DataSource = null;
                this.dgvbill.Rows.Clear();
                DataTable dt = new DataTable();
                dt = con.laybang("select ID,DateCreate,(select UserName from R_User where ID=rbi.UserID),Owe,(select SupplierName from R_Supplier where ID=rbi.SupplierID) from R_BillImport rbi where convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00',103) <= rbi.DateCreate and rbi.DateCreate  <= convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59',103)");
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("Mã", typeof(int)));
                _dt.Columns.Add(new DataColumn("Ngày Tạo", typeof(string)));
                _dt.Columns.Add(new DataColumn("Người tạo", typeof(string)));
                _dt.Columns.Add(new DataColumn("Còn nợ", typeof(string)));
                _dt.Columns.Add(new DataColumn("Nhà cung cấp", typeof(string)));
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string pricenew = con.GetStringCurency(dt.Rows[i]["Owe"].ToString());
                        dr = _dt.NewRow();
                        dr[0] = dt.Rows[i].ItemArray[0].ToString();
                        dr[1] = dt.Rows[i].ItemArray[1].ToString();
                        dr[2] = dt.Rows[i].ItemArray[2].ToString();
                        dr[3] = pricenew;
                        dr[4] = dt.Rows[i].ItemArray[4].ToString();
                        _dt.Rows.Add(dr);
                    }
                }

                dgvbill.DataSource = _dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ListBillImport_Load(object sender, EventArgs e)
        {
            GetTable();
            if(dgvbill.RowCount>1)
            { 
            dgvbill.CurrentCell.Selected = false;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvbill.Rows[e.RowIndex];
                lblBillID.Text = datagridview.Cells[0].Value.ToString();
            }
            catch { }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (lblBillID.Text != null && lblBillID.Text != "")
            {
                BillImportDetail billimport = new BillImportDetail(Convert.ToInt32(lblBillID.Text),userid1);
                billimport.passControl = new BillImportDetail.PassControl(GetTable);
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
            else
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBillID_Click(object sender, EventArgs e)
        {

        }

        //private void btndelete_Click(object sender, EventArgs e)
        //{
        //    con = new Connect();
        //    if (lblBillID.Text != null && lblBillID.Text != "")
        //    {
        //        try
        //        {
        //            DataTable dt = new DataTable();
        //            Decimal warehousingnew = 0;
        //            dt = con.laybang("select rf.ID,fbi.Quantity,rf.Warehousing from R_FoodBillImport fbi,R_Foods rf where rf.ID=fbi.FoodID and fbi.BillImportID='" + Convert.ToInt32(lblBillID.Text) + "'");
        //            if (dt.Rows.Count > 0)
        //            {
        //                for (int i = 0; i < dt.Rows.Count; i++)
        //                {
        //                    string quantity = null;
        //                    string warehousing = null;
        //                    int foodid = 0;
        //                    foodid = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
        //                    quantity = dt.Rows[i]["Quantity"].ToString();
        //                    warehousing = dt.Rows[i]["Warehousing"].ToString();
        //                    warehousingnew = Convert.ToDecimal(warehousing) - Convert.ToDecimal(quantity);
        //                    int kq = con.xulydulieu("Update R_Foods set Warehousing='" + warehousingnew.ToString() + "' where ID='" + foodid + "'");
        //                }
        //            }
        //            int kq1 = con.xulydulieu("Delete from R_BillImport where ID='" + Convert.ToInt32(lblBillID.Text) + "'");
        //            GetTable();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Bạn chưa chọn hóa đơn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
    }
}

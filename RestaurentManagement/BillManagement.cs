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
    public partial class BillManagement : Form
    {
        Connect con = null;
        private int userid1 = 0;
        public BillManagement(int useridd)
        {
            InitializeComponent();
            userid1 = useridd;
        }

        private void BillManagement_Load(object sender, EventArgs e)
        {
            string where = "Status=0";
            GetTableBill(where);
            if (dgvBill.RowCount>1)
            {
            dgvBill.CurrentCell.Selected = false;
                }
        }
        private void GetTableBill(string where)
        {
            try
            {
                con = new Connect();
               // this.dgvBill.DataSource = null;
                //this.dgvBill.Rows.Clear();
                DataTable dt = new DataTable();
                dt = con.laybang("select ID,DateEnd,(select UserName from R_User where ID=rb.UserID),Total,Sale,TotalEnd from R_Bill rb where "+where+"");
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("ID", typeof(int)));
                _dt.Columns.Add(new DataColumn("TableNumber", typeof(string)));
                _dt.Columns.Add(new DataColumn("DateEnd", typeof(string)));
                _dt.Columns.Add(new DataColumn("UserName", typeof(string)));
                _dt.Columns.Add(new DataColumn("Total", typeof(string)));
                _dt.Columns.Add(new DataColumn("Sale", typeof(string)));
                _dt.Columns.Add(new DataColumn("TotalEnd", typeof(string)));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string total = con.GetStringCurency(dt.Rows[i].ItemArray[5].ToString());
                    string sale = con.GetStringCurency(dt.Rows[i].ItemArray[4].ToString());
                    string totals = con.GetStringCurency(dt.Rows[i].ItemArray[3].ToString());
                    int idbill = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
                    DataTable dt1 = new DataTable();
                    dt1 = con.laybang("Select TableNumber from R_Tables,R_BillTable where ID=R_BillTable.TableID and R_BillTable.BillID='" + idbill + "'");
                    string tablename = "";
                    for (int g = 0; g < dt1.Rows.Count;g++)
                    {
                        tablename += dt1.Rows[g]["TableNumber"].ToString() +",";
                    }
                        dr = _dt.NewRow();
                    dr[0] = dt.Rows[i].ItemArray[0].ToString();
                    dr[1] = tablename;
                    dr[2] = Convert.ToDateTime(dt.Rows[i].ItemArray[1]).ToString("dd/MM/yyyy HH:mm");
                    dr[3] = dt.Rows[i].ItemArray[2].ToString();
                    dr[4] = totals;
                    dr[5] = sale;
                    dr[6] = total;
                    _dt.Rows.Add(dr);
                }

                dgvBill.DataSource = _dt;
                // dgvBillAllDay.Columns[0].HeaderText = "Mã hóa đơn";
                //dgvBillAllDay.Columns[1].HeaderText = "Ngày Tạo";
                //dgvBillAllDay.Columns[2].HeaderText = "Người tạo";
                // dgvBillAllDay.Columns[3].HeaderText = "Triết khấu";
                //dgvBillAllDay.Columns[4].HeaderText = "Tổng thanh toán";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string where2 = null;
            where2 = "Status=0";
            where2 += " and DateEnd >= convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) ";
            where2 += " and DateEnd <= convert(datetime,'" + Convert.ToDateTime(dtTo.Value).ToString("dd/MM/yyyy") + " 23:59:59',103) ";
            GetTableBill(where2);
        }
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
            con = new Connect();
            DataGridViewRow datagridview = new DataGridViewRow();
            if (e.RowIndex>=0)
            { 
            datagridview = dgvBill.Rows[e.RowIndex];
            int idbill = Convert.ToInt32(datagridview.Cells[0].Value.ToString());
            lblBillID.Text = idbill.ToString();
            lbldate.Text = datagridview.Cells[2].Value.ToString();

            this.dgvdish.DataSource = null;
            this.dgvdish.Rows.Clear();
            DataTable dt = new DataTable();
            DataTable _dt = new DataTable();
            DataRow dr;
            _dt.Columns.Add(new DataColumn("Mã món ăn", typeof(int)));
            _dt.Columns.Add(new DataColumn("Tên món ăn", typeof(string)));
            _dt.Columns.Add(new DataColumn("Số lượng", typeof(string)));
            _dt.Columns.Add(new DataColumn("Nhóm món", typeof(string)));
            _dt.Columns.Add(new DataColumn("Giá", typeof(string)));
            dt = con.laybang("Select rbd.DishID as 'Mã món ăn',(Select DishName from R_Dish where ID=rbd.DishID) as 'Tên món ăn',rbd.Quantity as 'Số lượng',(select R_DishGroup.DishGroupName from R_DishGroup where R_DishGroup.ID=(Select GroupID from R_Dish where ID=rbd.DishID)) as 'Nhóm món',(Select Price from R_Dish where ID=rbd.DishID) as 'Giá',rbd.BillID as 'Mã Bill' from R_BillDish rbd where rbd.BillID='" + idbill + "'");
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

            dgvdish.DataSource = _dt;
            }
                }
            catch(Exception ex)
            { throw ex; }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblBillID.Text == "" || lblBillID.Text == null)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new Connect();
                con.Ghilog("Xem chi tiết hóa đơn xuất số:'" + lblBillID.Text.Trim() + "'", userid1);
                BillDetail billdetail = new BillDetail(Convert.ToInt32(lblBillID.Text), userid1);
                //PrintPreview printbill = new PrintPreview(Convert.ToInt32(lblBillID.Text));
                DialogResult dr = billdetail.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    billdetail.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    billdetail.Close();
                }
            }
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

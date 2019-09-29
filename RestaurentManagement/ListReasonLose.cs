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
    public partial class ListReasonLose : Form
    {
        private Connect con = null;

        public ListReasonLose()
        {
            InitializeComponent();
        }

        private void ListReasonLose_Load(object sender, EventArgs e)
        {
            GetTable("1=1");
        }
        private void GetTable(string where)
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select * from R_ReasonLose where "+where+"");
            DataTable _dt = new DataTable();
            DataRow dr;
            //_dt.Columns.Add(new DataColumn("ID", typeof(int)));
            _dt.Columns.Add(new DataColumn("TableNumber", typeof(string)));
            _dt.Columns.Add(new DataColumn("DateTime", typeof(string)));
            _dt.Columns.Add(new DataColumn("Reason", typeof(string)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = _dt.NewRow();
                dr[0] = dt.Rows[i].ItemArray[1].ToString();
                dr[1] = Convert.ToDateTime(dt.Rows[i].ItemArray[2].ToString()).ToString("dd/MM/yyy HH:mm");
                dr[2] = dt.Rows[i].ItemArray[3].ToString();
                _dt.Rows.Add(dr);
            }
            dgvBill.DataSource = _dt;
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvBill.Rows[e.RowIndex];
                txtnumber.Text = datagridview.Cells[0].Value.ToString();
                txtdatetime.Text = datagridview.Cells[1].Value.ToString();
                lblreason.Text = datagridview.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string where2 = null;
            where2 = "1=1";
            where2 += " and DateCreate >= convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) ";
            where2 += " and DateCreate <= convert(datetime,'" + Convert.ToDateTime(dtTo.Value).ToString("dd/MM/yyyy") + " 23:59:59',103) ";
            GetTable(where2);
        }

    }
}

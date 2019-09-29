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
    public partial class GhiLogView : Form
    {
        public GhiLogView()
        {
            InitializeComponent();
        }
        Connect con = null;
        private void GhiLogView_Load(object sender, EventArgs e)
        {
            string where1 = "1=1";
            GetTable(where1);
            con = new Connect();
            con.GetComBoxx("Select ID,UserName from R_User",cbUser);
        }
        private void GetTable(string where)
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select ID,(Select UserName from R_User where ID=R_GhiLog.Userid) as 'UserName',DateCreate,Note from R_GhiLog where " + where + "");
            DataTable _dt = new DataTable();
            DataRow dr;
            //_dt.Columns.Add(new DataColumn("ID", typeof(int)));
            _dt.Columns.Add(new DataColumn("User", typeof(string)));
            _dt.Columns.Add(new DataColumn("Datetime", typeof(string)));
            _dt.Columns.Add(new DataColumn("Action", typeof(string)));
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string where2 = null;
            where2 = "1=1";
            if(cbUser.SelectedValue.ToString()!="0")
            {
                where2 += " and Userid='" + cbUser.SelectedValue.ToString().Trim() + "'";
            }
            if(txtAction.Text!="")
            {
                where2 += " and Note Like N'%" + txtAction.Text + "%'";
            }
            where2 += " and DateCreate >= convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) ";
            where2 += " and DateCreate <= convert(datetime,'" + Convert.ToDateTime(dtTo.Value).ToString("dd/MM/yyyy") + " 23:59:59',103) ";
            GetTable(where2);
        }
    }
}

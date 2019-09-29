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
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace RestaurentManagement
{
    public partial class BillImportPrint : Form
    {
        Connect con = null;
        private int billimport = 0;
        public BillImportPrint(int id)
        {
            billimport = id;
            InitializeComponent();
        }

        private void BillImportPrint_Load(object sender, EventArgs e)
        {

            try
            {
                ReportDataSource datasource = null;
                ReportDataSource data = null;
                DataTable dsSupplier = new DataTable();
                dsSupplier = GetData(billimport);
                DataTable dt = new DataTable();
                dt = GetDataBill(billimport);

                datasource = new ReportDataSource("DataSet1", dsSupplier);
                data = new ReportDataSource("DataSet2", dt);
                //this.reportViewer2.LocalReport.ReportPath="R_Bill.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.LocalReport.DataSources.Add(data);
                PageSettings pg = new PageSettings();
                pg.Landscape = false;
                pg.Margins.Top = 15;
                pg.Margins.Bottom = 0;
                pg.Margins.Left = 15;
                pg.Margins.Right = 0;
                PaperSize size = new PaperSize("A5", 583, 827);
                size.RawKind = (int)PaperKind.A5;
                pg.PaperSize = size;
                this.reportViewer1.SetPageSettings(pg);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable GetData(int id)
        {
            try
            {
                con = new Connect();
                DataTable dt = new DataTable();
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("FoodName", typeof(string)));
                _dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
                _dt.Columns.Add(new DataColumn("Pack", typeof(string)));
                _dt.Columns.Add(new DataColumn("Price", typeof(string)));
                _dt.Columns.Add(new DataColumn("PriceTotal", typeof(string)));
                _dt.Columns.Add(new DataColumn("STT", typeof(string)));
                dt = con.ExecStoreTable("[RES_Select_BillImportFoods]", new string[] { "@billid" }, new object[] { id });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string pricenew = "";
                    if (dt.Rows[i]["Price"].ToString() != "" && dt.Rows[i]["Price"].ToString() != null)
                    {
                        pricenew = con.GetStringCurency((Convert.ToDecimal(dt.Rows[i]["Quantity"].ToString()) * Convert.ToDecimal(dt.Rows[i]["Price"].ToString())).ToString());
                    }
                    dr = _dt.NewRow();
                    dr[0] = dt.Rows[i].ItemArray[0].ToString();
                    dr[1] = dt.Rows[i].ItemArray[1].ToString().Trim();
                    dr[2] = dt.Rows[i].ItemArray[2].ToString();
                    dr[3] = con.GetStringCurency(dt.Rows[i].ItemArray[3].ToString().Trim());
                    dr[4] = pricenew;
                    dr[5] = i+1;
                    _dt.Rows.Add(dr);
                }
                return _dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable GetDataBill(int id)
        {
            try
            {
                con = new Connect();
                DataTable dt = new DataTable();
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("ID", typeof(string)));
                _dt.Columns.Add(new DataColumn("DateCreate", typeof(string)));
                _dt.Columns.Add(new DataColumn("Total", typeof(string)));
                _dt.Columns.Add(new DataColumn("Owe", typeof(string)));
                _dt.Columns.Add(new DataColumn("Column1", typeof(string)));
                _dt.Columns.Add(new DataColumn("Pay", typeof(string)));
                _dt.Columns.Add(new DataColumn("UserFullName", typeof(string)));
                dt = con.ExecStoreTable("[RES_Select_BillImport]", new string[] { "@billid" }, new object[] { id });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string pay = "";
                    if (dt.Rows[i].ItemArray[2].ToString() != "" && dt.Rows[i].ItemArray[3].ToString()!="")
                    { 
                    pay = (Convert.ToDecimal(dt.Rows[i].ItemArray[2].ToString()) - Convert.ToDecimal(dt.Rows[i].ItemArray[3].ToString())).ToString();
                    }
                    dr = _dt.NewRow();
                    dr[0] = "0000" + dt.Rows[i].ItemArray[0].ToString();
                    dr[1] = Convert.ToDateTime(dt.Rows[i].ItemArray[1].ToString()).ToString("dd/MM/yyyy HH:mm");
                    dr[2] = con.GetStringCurency(dt.Rows[i].ItemArray[2].ToString());
                    dr[3] = con.GetStringCurency(dt.Rows[i].ItemArray[3].ToString());
                    dr[4] = dt.Rows[i].ItemArray[4].ToString();
                    dr[5] = con.GetStringCurency(pay);
                    dr[6] = dt.Rows[i].ItemArray[6].ToString();
                    _dt.Rows.Add(dr);
                }
                return _dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

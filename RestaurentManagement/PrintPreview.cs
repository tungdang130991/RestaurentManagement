using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using RestaurentManagement.Function1;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Drawing.Imaging;
using System.Reflection;

namespace RestaurentManagement
{
    public partial class PrintPreview : Form
    {
        private int printid = 0;
        Connect con = null;
        public PrintPreview(int id)
        {
            printid = id;
            InitializeComponent();
           
        }

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            try
            {
                 ReportDataSource datasource=null;
                ReportDataSource data=null;
                ReportDataSource datatable = null;
                
                con = new Connect();
                DataTable dt = new DataTable();
                dt = GetDataBill(printid);
            DataTable dsCustomers = GetData(printid);
            DataTable table = GetDataTable(printid);
            datatable = new ReportDataSource("DataSet3", table);
            datasource = new ReportDataSource("DataSet1", dsCustomers);
            data = new ReportDataSource("DataSet2", dt);
            //this.reportViewer2.LocalReport.ReportPath="R_Bill.rdlc";
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(datasource);
            this.reportViewer2.LocalReport.DataSources.Add(data);
            this.reportViewer2.LocalReport.DataSources.Add(datatable);
            PageSettings pg = new PageSettings();

            pg.Landscape = false;
            pg.Margins.Top = 15;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 15;
            pg.Margins.Right = 0;
            PaperSize size = new PaperSize("A5",583 , 827);
            size.RawKind = (int)PaperKind.A5;
            pg.PaperSize = size;
                
            this.reportViewer2.SetPageSettings(pg);
            this.reportViewer2.RefreshReport(); 
            ReportPageSettings rst = reportViewer2.LocalReport.GetDefaultPageSettings();
           
            //if (reportViewer2.ParentForm.Width > rst.PaperSize.Width)
            //{
            //    int vPad = (reportViewer1.ParentForm.Width - rst.PaperSize.Width) / 2;
            //    reportViewer2.Padding = new Padding(vPad - 20, 1, vPad - 20, 1);
            //}

          
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
            
            _dt.Columns.Add(new DataColumn("DishName", typeof(string)));
            _dt.Columns.Add(new DataColumn("PackID", typeof(string)));
            _dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
            _dt.Columns.Add(new DataColumn("Price", typeof(string)));
            _dt.Columns.Add(new DataColumn("STT", typeof(string)));
            _dt.Columns.Add(new DataColumn("PriceTotal", typeof(string)));
            dt = con.ExecStoreTable("RES_Select_BillDish", new string[] { "@billId" },new object[]{id});
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string pricenew = con.GetStringCurency((Convert.ToDecimal(dt.Rows[i]["Quantity"].ToString()) * Convert.ToDecimal(dt.Rows[i]["Price"].ToString())).ToString());
                dr = _dt.NewRow();
                dr[0] = dt.Rows[i].ItemArray[0].ToString();
                dr[1] = dt.Rows[i].ItemArray[1].ToString().Trim();
                dr[2] = dt.Rows[i].ItemArray[2].ToString().Trim();
                dr[3] = con.GetStringCurency(dt.Rows[i].ItemArray[3].ToString().Trim());
                dr[4] = (i+1).ToString().Trim();
                dr[5] = pricenew;
                _dt.Rows.Add(dr);
            }
            return _dt;
                }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private DataTable GetDataTable(int id)
        {
            try
            { 
            con = new Connect();
            DataTable dt = new DataTable();
            DataTable _dt = new DataTable();
            DataRow dr;
            _dt.Columns.Add(new DataColumn("TableNumber", typeof(string)));
            dt = con.ExecStoreTable("RES_Select_TableBill", new string[] { "@billid" }, new object[] { id });
            string table = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                table += dt.Rows[i].ItemArray[0].ToString() + ", ";
            }
            dr = _dt.NewRow();
            dr[0] = table;
            _dt.Rows.Add(dr);
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
                _dt.Columns.Add(new DataColumn("UserName", typeof(string)));
                _dt.Columns.Add(new DataColumn("Sale", typeof(string)));
                _dt.Columns.Add(new DataColumn("Moneyreceive", typeof(string)));
                _dt.Columns.Add(new DataColumn("DateEnd", typeof(string)));
                _dt.Columns.Add(new DataColumn("TotalEnd", typeof(string)));
                _dt.Columns.Add(new DataColumn("MoneyReturn", typeof(string)));
                dt = con.ExecStoreTable("RES_Select_Bill", new string[] { "@billId" }, new object[] { id });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    dr = _dt.NewRow();
                    dr[0] = "0000"+dt.Rows[i].ItemArray[0].ToString();
                    dr[1] = Convert.ToDateTime(dt.Rows[i].ItemArray[1].ToString()).ToString("dd/MM/yyyy HH:mm");
                    dr[2] = con.GetStringCurency(dt.Rows[i].ItemArray[2].ToString());
                    dr[3] = dt.Rows[i].ItemArray[3].ToString();
                    dr[4] = con.GetStringCurency(dt.Rows[i].ItemArray[4].ToString());
                    dr[5] = con.GetStringCurency(dt.Rows[i].ItemArray[5].ToString());
                    dr[6] = Convert.ToDateTime(dt.Rows[i].ItemArray[6].ToString()).ToString("dd/MM/yyyy HH:mm");
                    dr[7] = con.GetStringCurency(dt.Rows[i].ItemArray[7].ToString());
                    dr[8] = con.GetStringCurency(dt.Rows[i].ItemArray[8].ToString());

                    _dt.Rows.Add(dr);
                }
                return _dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        private DataTable LoadSalesData()
        {
            // Create a new DataSet and read sales data file 
            //    data.xml into the first DataTable.
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"..\..\data.xml");
            return dataSet.Tables[0];
        }
        private Stream CreateStream(string name,
     string fileNameExtension, Encoding encoding,
     string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        // Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>1.5in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }
        // Create a local report for Report.rdlc, load the data,
        //    export the report to an .emf file, and print it.
        private void Run()
        {
            try
            { 
            ReportDataSource datasource = null;
            ReportDataSource data = null;
            ReportDataSource datatable = null;

            con = new Connect();
            DataTable dt = new DataTable();
            dt = GetDataBill(printid);
            DataTable dsCustomers = GetData(printid);
            DataTable table = GetDataTable(printid);
            datatable = new ReportDataSource("DataSet3", table);
            datasource = new ReportDataSource("DataSet1", dsCustomers);
            data = new ReportDataSource("DataSet2", dt);
            //this.reportViewer2.LocalReport.ReportPath="R_Bill.rdlc";
            LocalReport report = new LocalReport();
            //PageSettings pg = new PageSettings();

            //pg.Landscape = false;
            //pg.Margins.Top = 15;
            //pg.Margins.Bottom = 0;
            //pg.Margins.Left = 15;
            //pg.Margins.Right = 0;
            //PaperSize size = new PaperSize("A5", 583, 827);
            //size.RawKind = (int)PaperKind.A5;
            //pg.PaperSize = size;

            //this.reportViewer2.SetPageSettings(pg);
            //this.reportViewer2.RefreshReport();
            //ReportPageSettings rst = reportViewer2.LocalReport.GetDefaultPageSettings();
            string exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string reportPath = Path.Combine(exeFolder, @"Report2.rdlc");
            report.ReportPath = reportPath;
            report.DataSources.Add(
               new ReportDataSource("DataSet3", table));
            report.DataSources.Add(
               new ReportDataSource("DataSet1", dsCustomers));
            report.DataSources.Add(
               new ReportDataSource("DataSet2", dt));
           
            Export(report);
            Print();
                }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurentManagement.Function1;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Globalization;

namespace RestaurentManagement
{
    public partial class DayReport : Form
    {
        Connect con = null;
        public DayReport()
        {
            InitializeComponent();
        }

        private void DayReport_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            try
            {
                con = new Connect();
                DataTable dt = new DataTable();
                dt = con.laybang("select ID,DateEnd,(select UserName from R_User where ID=rb.UserID) as 'UserName',Total,Sale,TotalEnd from R_Bill rb where convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00',103) <= rb.DateEnd and rb.DateEnd  <= convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59',103) and Status=0");
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("TT", typeof(int)));
                _dt.Columns.Add(new DataColumn("DishID", typeof(string)));
                _dt.Columns.Add(new DataColumn("DishName", typeof(string)));
                _dt.Columns.Add(new DataColumn("Pack", typeof(string)));
                _dt.Columns.Add(new DataColumn("Price", typeof(string)));
                _dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
                _dt.Columns.Add(new DataColumn("Total", typeof(string)));
                Decimal sale = 0;
                Decimal totalall = 0;
                int b = 1;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //dr = _dt.NewRow();
                        int billid = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
                        //dr[0] = dt.Rows[i].ItemArray[0].ToString();
                        //dr[1] = Convert.ToDateTime(dt.Rows[i].ItemArray[1]).ToString("dd/MM/yyyy HH:mm");
                        //dr[2] = dt.Rows[i].ItemArray[2].ToString();
                        //dr[5] = con.GetStringCurency(dt.Rows[i].ItemArray[5].ToString().Trim());
                        //_dt.Rows.Add(dr);
                        if (dt.Rows[i]["Sale"].ToString()!="")
                        { 
                        sale += Convert.ToDecimal(dt.Rows[i]["Sale"].ToString());
                        }
                        if (dt.Rows[i]["Total"].ToString()!="")
                        { 
                        totalall += Convert.ToDecimal(dt.Rows[i]["Total"].ToString());
                        }
                        DataTable dt1 = new DataTable();
                        dt1 = con.laybang("Select rbd.DishID,(Select DishName from R_Dish where ID=rbd.DishID) as 'DishName',rbd.Quantity,(Select Price from R_Dish where ID=rbd.DishID) as 'Price',(Select PackNameDish from R_PackDish where ID=(Select PackID from R_Dish where ID=rbd.DishID)) as 'Pack' from R_BillDish rbd where rbd.BillID='" + billid + "'");
                        for (int k = 0; k < dt1.Rows.Count; k++)
                        {
                            
                        string dishid = dt1.Rows[k].ItemArray[0].ToString().Trim();
                        string sl1=dt1.Rows[k].ItemArray[2].ToString().Trim();
                        if (_dt.Rows.Count > 0)
                        {
                            int gggg = 0;
                            for (int h = 0; h < _dt.Rows.Count; h++)
                            {
                                string dishidnew = _dt.Rows[h].ItemArray[1].ToString().Trim();
                                string sl2=_dt.Rows[h].ItemArray[5].ToString().Trim();
                                string price2 = _dt.Rows[h].ItemArray[4].ToString().Trim();
                                if(dishid==dishidnew)
                                {
                                    Decimal sl3 = Convert.ToDecimal(sl1, CultureInfo.InvariantCulture) + Convert.ToDecimal(sl2, CultureInfo.InvariantCulture);
                                    string price3 = (Convert.ToDecimal(price2)*sl3).ToString();
                                    _dt.Rows[h]["Quantity"]=sl3;
                                    _dt.Rows[h]["Total"]=con.GetStringCurency(price3);
                                    gggg = 1;
                                    break;
                                }
                            }
                            if (gggg == 0)
                            {
                                 Decimal totaldish = Convert.ToDecimal(dt1.Rows[k].ItemArray[2].ToString()) * Convert.ToDecimal(dt1.Rows[k].ItemArray[3].ToString());
                            dr = _dt.NewRow();
                            dr[0] = b ++;
                            dr[1] = dt1.Rows[k].ItemArray[0].ToString();
                            dr[2] = dt1.Rows[k].ItemArray[1].ToString();
                            dr[3] = dt1.Rows[k].ItemArray[4].ToString();
                            dr[4] = con.GetStringCurency(dt1.Rows[k].ItemArray[3].ToString().Trim());
                            dr[5] = dt1.Rows[k].ItemArray[2].ToString().Trim();
                            dr[6] = con.GetStringCurency(totaldish.ToString());
                            _dt.Rows.Add(dr);
                            }
                        }
                        else
                        {
                            Decimal totaldish = Convert.ToDecimal(dt1.Rows[k].ItemArray[2].ToString()) * Convert.ToDecimal(dt1.Rows[k].ItemArray[3].ToString());
                            dr = _dt.NewRow();
                            dr[0] = b ++;
                            dr[1] = dt1.Rows[k].ItemArray[0].ToString();
                            dr[2] = dt1.Rows[k].ItemArray[1].ToString();
                            dr[3] = dt1.Rows[k].ItemArray[4].ToString();
                            dr[4] = con.GetStringCurency(dt1.Rows[k].ItemArray[3].ToString().Trim());
                            dr[5] = dt1.Rows[k].ItemArray[2].ToString().Trim();
                            dr[6] = con.GetStringCurency(totaldish.ToString());
                            _dt.Rows.Add(dr);
                        }
                        }
                    }
                    Decimal totalend = totalall - sale;
                    dr = _dt.NewRow();
                    dr[5] = "Tổng tiền:";
                    dr[6] = con.GetStringCurency(totalall.ToString());
                    _dt.Rows.Add(dr);
                    dr = _dt.NewRow();
                    dr[5] = "Triết khấu:";
                    dr[6] = con.GetStringCurency(sale.ToString());
                    _dt.Rows.Add(dr);
                    dr = _dt.NewRow();
                    dr[5] = "Tổng thanh toán:";
                    dr[6] = con.GetStringCurency(totalend.ToString());
                    _dt.Rows.Add(dr);
                }

                dgvFloor.DataSource = _dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.ValidateNames = true;
            saveFileDialog1.DereferenceLinks = false; // Will return .lnk in shortcuts.
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.Title = "Save an Report File";
            saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(saveFileDialog1_FileOk);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //saveFileDialog1.FileOk -= new System.ComponentModel.CancelEventHandler(saveFileDialog1_FileOk);
            //string _filename = saveFileDialog1.FileName;
            //export(dgvFloor,_filename);
            saveFileDialog1.FileOk -= new System.ComponentModel.CancelEventHandler(saveFileDialog1_FileOk);
            try
            {
                string _filename = saveFileDialog1.FileName;
                if (_filename != "")
                {
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    xlWorkSheet.Range["A1:G1"].Merge(true);
                    xlWorkSheet.Range["A2:G2"].Merge(true);
                    xlWorkSheet.Range["A3:G3"].Merge(true);
                    xlWorkSheet.Range["A4:G4"].Merge(true);
                    xlWorkSheet.Range["A5:G5"].Merge(true);
                    //xlApp.get_Range("A1:G1,A2:G2,A3:G3,A4:G4,A5:G5", Type.Missing).Merge(Type.Missing);
                    xlWorkSheet.Cells[1, 1].Value = "Nhà hàng MECO - Bia hơi Hà Nội";
                    xlWorkSheet.Cells[2, 1].Value = "Địa chỉ: Số 35 Ngõ 102 đường Trường Trinh, Đống Đa, Hà Nội";
                    xlWorkSheet.Cells[3, 1].Value = "Số Đ.Thoại: -0432151440  -0912311113";
                    xlWorkSheet.Cells[4, 1].Value = "Ngày Giờ: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "";
                    xlWorkSheet.Cells[5, 1].Value = "Báo Cáo Doanh Thu Theo Các Món";
                    xlWorkSheet.Cells[1, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                    xlWorkSheet.Range["A5"].Font.Size = "14";
                    xlWorkSheet.Range["A5"].Font.Bold = true;
                    xlWorkSheet.Range["A1"].Font.Bold = true;
                    xlWorkSheet.Range["A6:G6"].Font.Bold = true;
                    xlWorkSheet.Range["A6:G6"].Borders.LineStyle = BorderStyle.Fixed3D;
                    xlWorkSheet.Columns[3].ColumnWidth = 27;
                    xlWorkSheet.Columns[6].ColumnWidth = 16;
                    xlWorkSheet.Range["A5"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Range["A6:G6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Cells[6, 1].Value = "TT";
                    xlWorkSheet.Cells[6, 2].Value = "Mã M.ăn";
                    xlWorkSheet.Cells[6, 3].Value = "Tên món ăn";
                    xlWorkSheet.Cells[6, 4].Value = "Đơn vị";
                    xlWorkSheet.Cells[6, 5].Value = "Đơn giá";
                    xlWorkSheet.Cells[6, 6].Value = "Số lượng";
                    xlWorkSheet.Cells[6, 7].Value = "Tổng thu";
                    for (int i = 0; i <= dgvFloor.RowCount - 5; i++)
                    {
                        xlWorkSheet.Cells[i + 7, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[i + 7, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[i + 7, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[i + 7, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[i + 7, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                    for (int i = dgvFloor.RowCount - 4; i <= dgvFloor.RowCount - 1; i++)
                    {
                        xlWorkSheet.Cells[i + 7, 6].Font.Italic = true;
                        xlWorkSheet.Cells[i + 7, 7].Font.Italic = true;
                    }
                    for (int i = 0; i <= dgvFloor.RowCount - 1; i++)
                    {
                        for (int j = 0; j <= dgvFloor.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dgvFloor[j, i];
                            xlWorkSheet.Cells[i + 7, j + 1] = cell.Value;
                        }
                    }

                    xlWorkBook.SaveAs(_filename, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    //MessageBox.Show("Excel file created , you can find the file "++"");
                }
            }
            catch (Exception ex)
            { throw ex; }
        }


        //private void export(DataGridView dgvFloor1,string file)
        //{
        //    if (dgvFloor1.Rows.Count > 0)
        //    {
        //        try
        //        {
        //            // Bind Grid Data to Datatable
        //            DataTable dt = new DataTable();
        //            foreach (DataGridViewColumn col in dgvFloor1.Columns)
        //            {
        //                dt.Columns.Add(col.HeaderText, col.ValueType);
        //            }
        //            int count = 0;
        //            foreach (DataGridViewRow row in dgvFloor1.Rows)
        //            {
        //                if (count < dgvFloor1.Rows.Count - 1)
        //                {
        //                    dt.Rows.Add();
        //                    foreach (DataGridViewCell cell in row.Cells)
        //                    {
        //                        if(cell.Value.ToString()!="")
        //                        { 
        //                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
        //                        }
        //                    }
        //                }
        //                count++;
        //            }
        //            // Bind table data to Stream Writer to export data to respective folder
        //            StreamWriter wr = new StreamWriter(@"E:\\hungviet.xlsx");
        //            // Write Columns to excel file
        //            for (int i = 0; i < dt.Columns.Count; i++)
        //            {
        //                wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
        //            }
        //            wr.WriteLine();
        //            //write rows to excel file
        //            for (int i = 0; i < (dt.Rows.Count); i++)
        //            {
        //                for (int j = 0; j < dt.Columns.Count; j++)
        //                {
        //                    if (dt.Rows[i][j] != null)
        //                    {
        //                        wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
        //                    }
        //                    else
        //                    {
        //                        wr.Write("\t");
        //                    }
        //                }
        //                wr.WriteLine();
        //            }
        //            wr.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //}


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con = new Connect();
                DataTable dt = new DataTable();
                dt = con.laybang("select ID,DateEnd,(select UserName from R_User where ID=rb.UserID) as 'UserName',Total,Sale,TotalEnd from R_Bill rb where convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) <= rb.DateEnd and rb.DateEnd  <= convert(datetime,'" + Convert.ToDateTime(dtTo.Value).ToString("dd/MM/yyyy") + " 23:59:59',103) and Status=0");
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("TT", typeof(int)));
                _dt.Columns.Add(new DataColumn("DishID", typeof(string)));
                _dt.Columns.Add(new DataColumn("DishName", typeof(string)));
                _dt.Columns.Add(new DataColumn("Pack", typeof(string)));
                _dt.Columns.Add(new DataColumn("Price", typeof(string)));
                _dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
                _dt.Columns.Add(new DataColumn("Total", typeof(string)));
                Decimal sale = 0;
                Decimal totalall = 0;
                int b = 1;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int billid = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());                        if (dt.Rows[i]["Sale"].ToString() != "")
                        {
                            sale += Convert.ToDecimal(dt.Rows[i]["Sale"].ToString());
                        }
                        if (dt.Rows[i]["Total"].ToString() != "")
                        {
                            totalall += Convert.ToDecimal(dt.Rows[i]["Total"].ToString());
                        }
                        DataTable dt1 = new DataTable();
                        dt1 = con.laybang("Select rbd.DishID,(Select DishName from R_Dish where ID=rbd.DishID) as 'DishName',rbd.Quantity,(Select Price from R_Dish where ID=rbd.DishID) as 'Price',(Select PackNameDish from R_PackDish where ID=(Select PackID from R_Dish where ID=rbd.DishID)) as 'Pack' from R_BillDish rbd where rbd.BillID='" + billid + "'");
                        for (int k = 0; k < dt1.Rows.Count; k++)
                        {

                            string dishid = dt1.Rows[k].ItemArray[0].ToString().Trim();
                            string sl1 = dt1.Rows[k].ItemArray[2].ToString().Trim();
                            if (_dt.Rows.Count > 0)
                            {
                                int gggg = 0;
                                for (int h = 0; h < _dt.Rows.Count; h++)
                                {
                                    string dishidnew = _dt.Rows[h].ItemArray[1].ToString().Trim();
                                    string sl2 = _dt.Rows[h].ItemArray[5].ToString().Trim();
                                    string price2 = _dt.Rows[h].ItemArray[4].ToString().Trim();
                                    if (dishid == dishidnew)
                                    {
                                        Decimal sl3 = Convert.ToDecimal(sl1, CultureInfo.InvariantCulture) + Convert.ToDecimal(sl2, CultureInfo.InvariantCulture);
                                        string price3 = (Convert.ToDecimal(price2) * sl3).ToString();
                                        _dt.Rows[h]["Quantity"] = sl3;
                                        _dt.Rows[h]["Total"] = con.GetStringCurency(price3);
                                        gggg = 1;
                                        break;
                                    }
                                }
                                if (gggg == 0)
                                {
                                    Decimal totaldish = Convert.ToDecimal(dt1.Rows[k].ItemArray[2].ToString()) * Convert.ToDecimal(dt1.Rows[k].ItemArray[3].ToString());
                                    dr = _dt.NewRow();
                                    dr[0] = b++;
                                    dr[1] = dt1.Rows[k].ItemArray[0].ToString();
                                    dr[2] = dt1.Rows[k].ItemArray[1].ToString();
                                    dr[3] = dt1.Rows[k].ItemArray[4].ToString();
                                    dr[4] = con.GetStringCurency(dt1.Rows[k].ItemArray[3].ToString().Trim());
                                    dr[5] = dt1.Rows[k].ItemArray[2].ToString().Trim();
                                    dr[6] = con.GetStringCurency(totaldish.ToString());
                                    _dt.Rows.Add(dr);
                                }
                            }
                            else
                            {
                                Decimal totaldish = Convert.ToDecimal(dt1.Rows[k].ItemArray[2].ToString()) * Convert.ToDecimal(dt1.Rows[k].ItemArray[3].ToString());
                                dr = _dt.NewRow();
                                dr[0] = b++;
                                dr[1] = dt1.Rows[k].ItemArray[0].ToString();
                                dr[2] = dt1.Rows[k].ItemArray[1].ToString();
                                dr[3] = dt1.Rows[k].ItemArray[4].ToString();
                                dr[4] = con.GetStringCurency(dt1.Rows[k].ItemArray[3].ToString().Trim());
                                dr[5] = dt1.Rows[k].ItemArray[2].ToString().Trim();
                                dr[6] = con.GetStringCurency(totaldish.ToString());
                                _dt.Rows.Add(dr);
                            }
                        }
                    }
                    Decimal totalend = totalall - sale;
                    dr = _dt.NewRow();
                    dr[5] = "Tổng tiền:";
                    dr[6] = con.GetStringCurency(totalall.ToString());
                    _dt.Rows.Add(dr);
                    dr = _dt.NewRow();
                    dr[5] = "Triết khấu:";
                    dr[6] = con.GetStringCurency(sale.ToString());
                    _dt.Rows.Add(dr);
                    dr = _dt.NewRow();
                    dr[5] = "Tổng thanh toán:";
                    dr[6] = con.GetStringCurency(totalend.ToString());
                    _dt.Rows.Add(dr);
                }

                dgvFloor.DataSource = _dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

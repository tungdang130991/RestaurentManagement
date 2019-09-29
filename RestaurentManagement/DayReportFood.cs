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
using System.Globalization;

namespace RestaurentManagement
{
    public partial class DayReportFood : Form
    {
        Connect con = null;
        public DayReportFood()
        {
            InitializeComponent();
        }
        private void GetTable()
        {
            try
            {
                con = new Connect();
                DataTable dt = new DataTable();
                dt = con.laybang("Select rdf.FoodID,rdf.Quantity as 'QuantityFood',rbd.Quantity as 'QuantityDish',(Select Warehousing from R_Foods where ID=rdf.FoodID) as 'Warehousing' from R_BillDish rbd , R_DishFood rdf where convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00',103) <= (Select DateEnd from R_Bill where ID=rbd.BillID) and (Select DateEnd from R_Bill where ID=rbd.BillID)  <= convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59',103) and rbd.DishID=rdf.DishID and (Select Status from R_Bill where ID=rbd.BillID)=0");
                DataTable dt1 = new DataTable();
                dt1 = con.laybang("Select ID,FoodName,(Select PackName from R_Packs where ID=R_Foods.PackUnit) as 'PackName',Warehousing from R_Foods");
                DataTable _dt = new DataTable();
                DataRow dr;
                int m = 1;
                _dt.Columns.Add(new DataColumn("TT", typeof(int)));
                _dt.Columns.Add(new DataColumn("FoodID", typeof(string)));
                _dt.Columns.Add(new DataColumn("FoodName", typeof(string)));
                _dt.Columns.Add(new DataColumn("Pack", typeof(string)));
                _dt.Columns.Add(new DataColumn("QuantityFirst", typeof(string)));
                _dt.Columns.Add(new DataColumn("QuantityEnd", typeof(string)));
                _dt.Columns.Add(new DataColumn("export", typeof(string)));
                _dt.Columns.Add(new DataColumn("import", typeof(string)));
                if (dt1.Rows.Count > 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        dr = _dt.NewRow();
                        dr[0] = m++;
                        dr[1] = dt1.Rows[i]["ID"].ToString().Trim();
                        dr[2] = dt1.Rows[i]["FoodName"].ToString().Trim();
                        dr[3] = dt1.Rows[i]["PackName"].ToString().Trim();
                        dr[5] = dt1.Rows[i]["Warehousing"].ToString().Trim();
                        _dt.Rows.Add(dr);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    if (_dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            string idfood1 = dt.Rows[j]["FoodID"].ToString().Trim();
                            Decimal foodexport = Convert.ToDecimal(dt.Rows[j]["QuantityFood"].ToString(), CultureInfo.InvariantCulture) * Convert.ToDecimal(dt.Rows[j]["QuantityDish"].ToString(), CultureInfo.InvariantCulture);
                            for (int i = 0; i < _dt.Rows.Count; i++)
                            {
                                string idfood2 = _dt.Rows[i]["FoodID"].ToString().Trim();
                                if (idfood1 == idfood2)
                                {
                                    string exportolder = _dt.Rows[i]["export"].ToString().Trim();
                                    if (exportolder == "")
                                    {
                                        _dt.Rows[i]["export"] = foodexport.ToString();
                                    }
                                    else
                                    {
                                        Decimal exportnew = Convert.ToDecimal(exportolder, CultureInfo.InvariantCulture) + foodexport;
                                        _dt.Rows[i]["export"] = exportnew.ToString();
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                DataTable dt2 = new DataTable();
                dt2 = con.laybang("Select rfbi.FoodID,rfbi.Quantity from R_FoodBillImport rfbi,R_BillImport rbi where convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00',103) <= rbi.DateCreate and rbi.DateCreate  <= convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59',103) and rfbi.BillImportID =rbi.ID");
                if (dt2.Rows.Count > 0)
                {
                    if (_dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            string idfood1 = dt2.Rows[i]["FoodID"].ToString().Trim();
                            Decimal foodimport = Convert.ToDecimal(dt2.Rows[i]["Quantity"].ToString(), CultureInfo.InvariantCulture);
                            for (int j = 0; j < _dt.Rows.Count; j++)
                            {
                                string idfood2 = _dt.Rows[j]["FoodID"].ToString().Trim();
                                if (idfood1 == idfood2)
                                {
                                    string importolder = _dt.Rows[j]["import"].ToString().Trim();
                                    if (importolder == "")
                                    {
                                        _dt.Rows[j]["import"] = foodimport.ToString();
                                    }
                                    else
                                    {
                                        Decimal foodimportnew = foodimport + Convert.ToDecimal(importolder, CultureInfo.InvariantCulture);
                                        _dt.Rows[j]["import"] = foodimportnew.ToString();
                                    }
                                    break;
                                }

                            }
                        }
                    }
                }
                if (_dt.Rows.Count > 0)
                {
                    for (int g = 0; g < _dt.Rows.Count; g++)
                    {
                        string quantity2 = _dt.Rows[g]["QuantityEnd"].ToString().Trim();
                        string export1 = _dt.Rows[g]["export"].ToString().Trim();
                        string import1 = _dt.Rows[g]["import"].ToString().Trim();
                        if (export1 != "" && import1 == "")
                        {
                            Decimal quantityfirst1 = Convert.ToDecimal(quantity2, CultureInfo.InvariantCulture) + Convert.ToDecimal(export1, CultureInfo.InvariantCulture);
                            _dt.Rows[g]["QuantityFirst"] = quantityfirst1.ToString();
                        }
                        if (export1 == "" && import1 != "")
                        {
                            Decimal quantityfirst1 = Convert.ToDecimal(quantity2, CultureInfo.InvariantCulture) - Convert.ToDecimal(import1, CultureInfo.InvariantCulture);
                            _dt.Rows[g]["QuantityFirst"] = quantityfirst1.ToString();
                        }
                        if (export1 != "" && import1 != "")
                        {
                            Decimal quantityfirst1 = Convert.ToDecimal(quantity2, CultureInfo.InvariantCulture) - Convert.ToDecimal(import1, CultureInfo.InvariantCulture) + Convert.ToDecimal(export1, CultureInfo.InvariantCulture);
                            _dt.Rows[g]["QuantityFirst"] = quantityfirst1.ToString();
                        }
                    }
                }
                dgvFloor.DataSource = _dt;
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void DayReportFood_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.ValidateNames = true;
            saveFileDialog1.DereferenceLinks = false; 
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
            saveFileDialog1.FileOk -= new System.ComponentModel.CancelEventHandler(saveFileDialog1_FileOk);
            try
            {
                string _filename = saveFileDialog1.FileName;
                if(_filename!="")
                {
                    //_filename += ".xls";
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 8]].Merge();
                xlWorkSheet.Range[xlWorkSheet.Cells[2, 1], xlWorkSheet.Cells[2, 8]].Merge();
                xlWorkSheet.Range[xlWorkSheet.Cells[3, 1], xlWorkSheet.Cells[3, 8]].Merge();
                xlWorkSheet.Range[xlWorkSheet.Cells[4, 1], xlWorkSheet.Cells[4, 8]].Merge();
                xlWorkSheet.Range[xlWorkSheet.Cells[5, 1], xlWorkSheet.Cells[5, 8]].Merge();
                //xlWorkSheet.Range["A1:H1,A2:H2,A3:H3,A4:H4,A5:H5"].Merge(true);
                //Excel.Range range = xlWorkSheet.get_Range(["A1:H1,A2:H2,A3:H3,A4:H4,A5:H5"]);
                //xlApp.get_Range("A1:H1,A2:H2,A3:H3,A4:H4,A5:H5", Type.Missing).Merge(Type.Missing);
                xlWorkSheet.Cells[1, 1].Value = "Nhà hàng MECO - Bia hơi Hà Nội";
                xlWorkSheet.Cells[2, 1].Value = "Địa chỉ: Số 35 Ngõ 102 đường Trường Trinh, Đống Đa, Hà Nội";
                xlWorkSheet.Cells[3, 1].Value = "Số Đ.Thoại: -0432151440  -0912311113";
                xlWorkSheet.Cells[4, 1].Value = "Ngày Giờ: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "";
                xlWorkSheet.Cells[5, 1].Value = "Báo Cáo Sử Dụng Thực Phẩm";
                xlWorkSheet.Range["A5"].Font.Size = "14";
                xlWorkSheet.Range["A5"].Font.Bold = true;
                xlWorkSheet.Range["A1"].Font.Bold = true;
                xlWorkSheet.Range["A6:H6"].Font.Bold = true;
                //xlWorkSheet.Range["A5,A1,A6:H6"].Font.Bold = true;
                //xlWorkSheet.Range[xlWorkSheet.Cells[1, 1]].Font.Bold();
                //xlWorkSheet.Range[xlWorkSheet.Cells[5, 1]].Font.Bold();
                //xlWorkSheet.Range[xlWorkSheet.Cells[6, 1], xlWorkSheet.Cells[6, 8]].Font.Bold();
                xlWorkSheet.Range["A6:H6"].Borders.LineStyle = BorderStyle.Fixed3D;
                xlWorkSheet.Columns[3].ColumnWidth = 27;
                xlWorkSheet.Columns[1].ColumnWidth = 7;
                xlWorkSheet.Columns[2].ColumnWidth = 7;
                xlWorkSheet.Columns[4].ColumnWidth = 12;
                xlWorkSheet.Columns[5].ColumnWidth = 16;
                xlWorkSheet.Columns[6].ColumnWidth = 16;
                //xlWorkSheet.Range["A5,C6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //xlWorkSheet.Cells[1,1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[5,1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[6, 1].Value = "TT";
                xlWorkSheet.Cells[6, 2].Value = "Mã";
                xlWorkSheet.Cells[6, 3].Value = "Tên thực phẩm";
                xlWorkSheet.Cells[6, 4].Value = "Đơn vị";
                xlWorkSheet.Cells[6, 5].Value = "Lượng tồn đầu";
                xlWorkSheet.Cells[6, 6].Value = "Lượng tồn cuối";
                xlWorkSheet.Cells[6, 7].Value = "Xuất ra";
                xlWorkSheet.Cells[6, 8].Value = "Nhập vào";
                for (int i = 0; i <= dgvFloor.RowCount - 1; i++)
                {
                    xlWorkSheet.Cells[i + 6, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Cells[i + 6, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Cells[i + 6, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Cells[i + 6, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Cells[i + 6, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Cells[i + 6, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Cells[i + 6, 8].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
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

               // MessageBox.Show("Excel file created , you can find the file " + _filename + "");

                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con = new Connect();
                DataTable dt = new DataTable();
                dt = con.laybang("Select rdf.FoodID,rdf.Quantity as 'QuantityFood',rbd.Quantity as 'QuantityDish',(Select Warehousing from R_Foods where ID=rdf.FoodID) as 'Warehousing' from R_BillDish rbd , R_DishFood rdf where convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) <= (Select DateEnd from R_Bill where ID=rbd.BillID) and (Select DateEnd from R_Bill where ID=rbd.BillID)  <= convert(datetime,'" + Convert.ToDateTime(dtTo.Value).ToString("dd/MM/yyyy") + " 23:59:59',103) and rbd.DishID=rdf.DishID and (Select Status from R_Bill where ID=rbd.BillID)=0");
                DataTable dt1 = new DataTable();
                dt1 = con.laybang("Select ID,FoodName,(Select PackName from R_Packs where ID=R_Foods.PackUnit) as 'PackName',Warehousing from R_Foods");
                DataTable _dt = new DataTable();
                DataRow dr;
                int m = 1;
                _dt.Columns.Add(new DataColumn("TT", typeof(int)));
                _dt.Columns.Add(new DataColumn("FoodID", typeof(string)));
                _dt.Columns.Add(new DataColumn("FoodName", typeof(string)));
                _dt.Columns.Add(new DataColumn("Pack", typeof(string)));
                _dt.Columns.Add(new DataColumn("QuantityFirst", typeof(string)));
                _dt.Columns.Add(new DataColumn("QuantityEnd", typeof(string)));
                _dt.Columns.Add(new DataColumn("export", typeof(string)));
                _dt.Columns.Add(new DataColumn("import", typeof(string)));
                _dt.Columns.Add(new DataColumn("exportnow", typeof(string)));
                _dt.Columns.Add(new DataColumn("importnow", typeof(string)));
                _dt.Columns.Add(new DataColumn("QuantityEndNow", typeof(string)));
                if (dt1.Rows.Count > 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        dr = _dt.NewRow();
                        dr[0] = m++;
                        dr[1] = dt1.Rows[i]["ID"].ToString().Trim();
                        dr[2] = dt1.Rows[i]["FoodName"].ToString().Trim();
                        dr[3] = dt1.Rows[i]["PackName"].ToString().Trim();
                        dr[10] = dt1.Rows[i]["Warehousing"].ToString().Trim();
                        _dt.Rows.Add(dr);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    if (_dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            string idfood1 = dt.Rows[j]["FoodID"].ToString().Trim();
                            Decimal foodexport = Convert.ToDecimal(dt.Rows[j]["QuantityFood"].ToString()) * Convert.ToDecimal(dt.Rows[j]["QuantityDish"].ToString());
                            for (int i = 0; i < _dt.Rows.Count; i++)
                            {
                                string idfood2 = _dt.Rows[i]["FoodID"].ToString().Trim();
                                if (idfood1 == idfood2)
                                {
                                    string exportolder = _dt.Rows[i]["export"].ToString().Trim();
                                    if (exportolder == "")
                                    {
                                        _dt.Rows[i]["export"] = foodexport.ToString();
                                    }
                                    else
                                    {
                                        Decimal exportnew = Convert.ToDecimal(exportolder) + foodexport;
                                        _dt.Rows[i]["export"] = exportnew.ToString();
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                DataTable dt2 = new DataTable();
                dt2 = con.laybang("Select rfbi.FoodID,rfbi.Quantity from R_FoodBillImport rfbi,R_BillImport rbi where convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) <= rbi.DateCreate and rbi.DateCreate  <= convert(datetime,'" + Convert.ToDateTime(dtTo.Value).ToString("dd/MM/yyyy") + " 23:59:59',103) and rfbi.BillImportID =rbi.ID");
                if (dt2.Rows.Count > 0)
                {
                    if (_dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            string idfood1 = dt2.Rows[i]["FoodID"].ToString().Trim();
                            Decimal foodimport = Convert.ToDecimal(dt2.Rows[i]["Quantity"].ToString());
                            for (int j = 0; j < _dt.Rows.Count; j++)
                            {
                                string idfood2 = _dt.Rows[j]["FoodID"].ToString().Trim();
                                if (idfood1 == idfood2)
                                {
                                    string importolder = _dt.Rows[j]["import"].ToString().Trim();
                                    if (importolder == "")
                                    {
                                        _dt.Rows[j]["import"] = foodimport.ToString();
                                    }
                                    else
                                    {
                                        Decimal foodimportnew = foodimport + Convert.ToDecimal(importolder);
                                        _dt.Rows[j]["import"] = foodimportnew.ToString();
                                    }
                                    break;
                                }

                            }
                        }
                    }
                }
                DataTable dt3 = new DataTable();
                dt3 = con.laybang("Select rdf.FoodID,rdf.Quantity as 'QuantityFood',rbd.Quantity as 'QuantityDish',(Select Warehousing from R_Foods where ID=rdf.FoodID) as 'Warehousing' from R_BillDish rbd , R_DishFood rdf where convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) <= (Select DateEnd from R_Bill where ID=rbd.BillID) and (Select DateEnd from R_Bill where ID=rbd.BillID)  <= convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59',103) and rbd.DishID=rdf.DishID and (Select Status from R_Bill where ID=rbd.BillID)=0");
                if (dt3.Rows.Count > 0)
                {
                    if (_dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt3.Rows.Count; j++)
                        {
                            string idfood1 = dt3.Rows[j]["FoodID"].ToString().Trim();
                            Decimal foodexport = Convert.ToDecimal(dt3.Rows[j]["QuantityFood"].ToString()) * Convert.ToDecimal(dt3.Rows[j]["QuantityDish"].ToString());
                            for (int i = 0; i < _dt.Rows.Count; i++)
                            {
                                string idfood2 = _dt.Rows[i]["FoodID"].ToString().Trim();
                                if (idfood1 == idfood2)
                                {
                                    string exportolder = _dt.Rows[i]["exportnow"].ToString().Trim();
                                    if (exportolder == "")
                                    {
                                        _dt.Rows[i]["exportnow"] = foodexport.ToString();
                                    }
                                    else
                                    {
                                        Decimal exportnew = Convert.ToDecimal(exportolder) + foodexport;
                                        _dt.Rows[i]["exportnow"] = exportnew.ToString();
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                DataTable dt4 = new DataTable();
                dt4 = con.laybang("Select rfbi.FoodID,rfbi.Quantity from R_FoodBillImport rfbi,R_BillImport rbi where convert(datetime,'" + Convert.ToDateTime(dtFrom.Value).ToString("dd/MM/yyyy") + " 00:00:00',103) <= rbi.DateCreate and rbi.DateCreate  <= convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59',103) and rfbi.BillImportID =rbi.ID");
                if (dt4.Rows.Count > 0)
                {
                    if (_dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt4.Rows.Count; i++)
                        {
                            string idfood1 = dt4.Rows[i]["FoodID"].ToString().Trim();
                            Decimal foodimport = Convert.ToDecimal(dt4.Rows[i]["Quantity"].ToString());
                            for (int j = 0; j < _dt.Rows.Count; j++)
                            {
                                string idfood2 = _dt.Rows[j]["FoodID"].ToString().Trim();
                                if (idfood1 == idfood2)
                                {
                                    string importolder = _dt.Rows[j]["importnow"].ToString().Trim();
                                    if (importolder == "")
                                    {
                                        _dt.Rows[j]["importnow"] = foodimport.ToString();
                                    }
                                    else
                                    {
                                        Decimal foodimportnew = foodimport + Convert.ToDecimal(importolder);
                                        _dt.Rows[j]["importnow"] = foodimportnew.ToString();
                                    }
                                    break;
                                }

                            }
                        }
                    }
                }
                if (_dt.Rows.Count > 0)
                {
                    for (int g = 0; g < _dt.Rows.Count; g++)
                    {
                        string quantity2 = _dt.Rows[g]["QuantityEndNow"].ToString().Trim();
                        string export1 = _dt.Rows[g]["exportnow"].ToString().Trim();
                        string import1 = _dt.Rows[g]["importnow"].ToString().Trim();
                        string export2 = _dt.Rows[g]["export"].ToString().Trim();
                        string import2 = _dt.Rows[g]["import"].ToString().Trim();
                        if (export2 != "" && import2 == "")
                        {
                            Decimal quantityfirst1 = Convert.ToDecimal(quantity2) + Convert.ToDecimal(export1);
                            _dt.Rows[g]["QuantityFirst"] = quantityfirst1.ToString();
                            Decimal quantityend1 = quantityfirst1 - Convert.ToDecimal(export2);
                            _dt.Rows[g]["QuantityEnd"] = quantityend1.ToString();
                        }
                        if (export2 == "" && import2 != "")
                        {
                            Decimal quantityfirst1 = Convert.ToDecimal(quantity2) - Convert.ToDecimal(import1);
                            _dt.Rows[g]["QuantityFirst"] = quantityfirst1.ToString();
                            Decimal quantityend1 = quantityfirst1 + Convert.ToDecimal(import2);
                            _dt.Rows[g]["QuantityEnd"] = quantityend1.ToString();
                        }
                        if (export2 != "" && import2 != "")
                        {
                            Decimal quantityfirst1 = Convert.ToDecimal(quantity2) - Convert.ToDecimal(import1) + Convert.ToDecimal(export1);
                            _dt.Rows[g]["QuantityFirst"] = quantityfirst1.ToString();
                            Decimal quantityend1 = quantityfirst1 + Convert.ToDecimal(import2) - Convert.ToDecimal(export2);
                            _dt.Rows[g]["QuantityEnd"] = quantityend1.ToString();
                        }
                    }
                }
                _dt.Columns.RemoveAt(10);
                _dt.Columns.RemoveAt(9);
                _dt.Columns.RemoveAt(8);
                dgvFloor.DataSource = _dt;
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}

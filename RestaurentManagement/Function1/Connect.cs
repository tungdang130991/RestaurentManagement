using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography;
using System.Configuration;

namespace RestaurentManagement.Function1
{
    class Connect
    {

        public SqlConnection con = new SqlConnection();
        public void kn_csdl()
        {
            //string chuoikn = "Data Source=(local);Initial Catalog=Restaurent;Integrated Security=True";
            string chuoikn = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            con.ConnectionString = chuoikn;
            con.Open();
        }
        public string GetTextBoxCurency(TextBox textbox)
        {
            Decimal _price = 0;
            if (textbox.TextLength > 3)
            {
                string ggg = textbox.Text.Replace(",", "");
                _price = Convert.ToDecimal(ggg);
                textbox.Text = string.Format(CultureInfo.InvariantCulture, "{0:#,#}", _price);
                textbox.Focus();
                textbox.SelectionStart = textbox.Text.Length;
            }
            return textbox.Text;
        }
        public string GetStringCurency(string text)
        {
            Decimal _price = 0;
            string newtext = "0";
            if (text.Length > 3)
            {
                string ggg = text.Replace(",", "");
                _price = Convert.ToDecimal(ggg);
                newtext = string.Format(CultureInfo.InvariantCulture, "{0:#,#}", _price);
            }
            return newtext;

        }
        public string lay1giatri(string sql)
        {
            string kq = "";
            try
            {
                kn_csdl();

                SqlCommand sqlComm = new SqlCommand(sql, con);
                SqlDataReader r = sqlComm.ExecuteReader();
                if (r.Read())
                {
                    kq = r["tong"].ToString();
                }
            }
            catch
            { }
            return kq;
        }


        public void dongketnoi()
        {
            if (con.State == ConnectionState.Open)
            { con.Close(); }
        }
        public DataTable bangdulieu = null;
        public DataTable laybang(string caulenh)
        {
            bangdulieu = new DataTable();
            try
            {
                kn_csdl();
                SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, con);
                DataSet ds = new DataSet();

                Adapter.Fill(bangdulieu);
                bangdulieu.Dispose();
            }
            catch (System.Exception)
            {
                bangdulieu = null;
            }
            finally
            {
                dongketnoi();
            }

            return bangdulieu;
        }
        public void updatedatagridview(string caulenh, DataGridView dgv)
        {
            bangdulieu = new DataTable();
            try
            {
                kn_csdl();
                SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, con);
                DataSet ds = new DataSet();
                Adapter.Fill(ds, "News_table");
                dgv.DataSource = ds.Tables[0];
                bangdulieu.Dispose();
            }
            catch (System.Exception)
            {
                bangdulieu = null;
            }
            finally
            {
                dongketnoi();
            }

        }
        public string EncodePasswordToBase64(string password)
        {
            try
            { 
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
                }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public int xulydulieu(string caulenhsql)
        {
            int kq = 0;
            try
            {
                kn_csdl();
                SqlCommand lenh = new SqlCommand(caulenhsql, con);
                kq = lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                kq = 0;
            }
            finally
            {
                dongketnoi();
            }
            return kq;
        }
        //public void GetCombox1(string sql, ComboBox cbox)
        //{
        //    try 
        //    { 
        //    DataTable dt = null;
        //    dt = new DataTable();
        //    dt = laybang(sql);
        //    DataTable _dt = new DataTable();
        //    DataRow dr;
        //    _dt.Columns.Add(new DataColumn("ID", typeof(int)));
        //    _dt.Columns.Add(new DataColumn("FoodName", typeof(string)));
        //    dr = _dt.NewRow();
        //    dr[0] = "0";
        //    dr[1] = "--------Tất cả--------";
        //    _dt.Rows.Add(dr);
        //    if (dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            int id = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
        //            string groupname = dt.Rows[i].ItemArray[1].ToString();
        //            dr = _dt.NewRow();
        //            dr[0] = id;
        //            dr[1] = groupname;
        //            _dt.Rows.Add(dr);
        //        }
        //    }
        //    cbox.DataSource = _dt;
        //    cbox.DisplayMember = _dt.Columns[1].ToString();
        //    cbox.ValueMember = _dt.Columns[0].ToString();
        //        }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        dongketnoi();
        //    }

        //}
        public void GetComBoxAll(string sql, ComboBox cbbox)
        {
            try
            {
                DataTable dt = null;
                dt = new DataTable();
                dt = laybang(sql);
                

                if (dt.Rows.Count > 0)
                {
                    List<ComboboxItem> list = new List<ComboboxItem>();

                    ComboboxItem item = null;
                    item = new ComboboxItem();
                    item.Text = "--------Tất cả--------";
                    item.Value = 0;
                    list.Add(item);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        item = new ComboboxItem();
                        int id = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
                        string groupname = dt.Rows[i].ItemArray[1].ToString();
                        item.Text = groupname;
                        item.Value = id;
                        list.Add(item);
                    }
                   
                    cbbox.DataSource = list;
                    cbbox.DisplayMember = "Text";
                    cbbox.ValueMember = "Value";
                }

                con.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dongketnoi();
            }
        }
 
        public void GetComBoxx(string sql, ComboBox cbbox)
        {
            try
            {
                SqlCommand mysqlcommand = new SqlCommand();
                mysqlcommand.Connection = con;
                mysqlcommand.CommandText = sql;
                kn_csdl();
                SqlDataAdapter mysqladatareader = new SqlDataAdapter();
                mysqladatareader.SelectCommand = mysqlcommand;
                DataSet mydataset = new DataSet();
                mysqladatareader.Fill(mydataset, "KQ");
                DataTable table_MK = new DataTable();
                table_MK = mydataset.Tables["KQ"];
                cbbox.DataSource = table_MK;
                cbbox.DisplayMember =table_MK.Columns[1].ToString();
                cbbox.ValueMember =table_MK.Columns[0].ToString();

                    con.Close();
                }
            
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dongketnoi();
            }
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public int ExecStore(string StoreName, string[] param1, object[] value)
        {
            int kq = 0;
            string _sql = StoreName;
            try
            {
                kn_csdl();
                SqlCommand cmd = new SqlCommand(_sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < param1.Length; i++)
                {
                    cmd.Parameters.AddWithValue(param1[i], value[i]);
                }
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dongketnoi();
            }
            return kq;
        }
        public DataSet ExecStores(string StoreName)
        {
            string _sql = StoreName;
            //DataTable dt1 = new DataTable();
            DataSet _ds = new DataSet();
            try
            {
                SqlDataAdapter mysqladatareader = new SqlDataAdapter();
                kn_csdl();
                SqlCommand cmd = new SqlCommand(_sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                mysqladatareader.SelectCommand = cmd;
                mysqladatareader.Fill(_ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dongketnoi();
            }
            return _ds;
        }
        public DataTable ExecStoreTable(string StoreName, string[] param1, object[] value)
        {
            string _sql = StoreName;
            //DataTable dt1 = new DataTable();
            DataTable _ds = new DataTable();
            try
            {
                SqlDataAdapter mysqladatareader = new SqlDataAdapter();
                kn_csdl();
                SqlCommand cmd = new SqlCommand(_sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < param1.Length; i++)
                {
                    cmd.Parameters.AddWithValue(param1[i], value[i]);
                }
                mysqladatareader.SelectCommand = cmd;
                mysqladatareader.Fill(_ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dongketnoi();
            }
            return _ds;
        }
        public int SPInsertBillTable(string caulenhsql, int id1, int id2)
        {
            int kq = 0;
            try
            {
                kn_csdl();
                SqlCommand cmd = new SqlCommand(caulenhsql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableID", id1);
                cmd.Parameters.AddWithValue("@BillID", id2);
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                kq = 0;
            }
            finally
            {
                dongketnoi();
            }
            return kq;
        }
        public int GetIDExStore(string StoreName, string[] param1, object[] value)
        {
            string _sql = StoreName;
            try
            {
                kn_csdl();
                SqlCommand cmd = new SqlCommand(_sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < param1.Length; i++)
                {
                    cmd.Parameters.AddWithValue(param1[i], value[i]);
                }
                SqlParameter paraOutput = new SqlParameter("@ReturnValue", SqlDbType.Int);
                paraOutput.Value = 0;
                paraOutput.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paraOutput);
                cmd.ExecuteNonQuery();

                return (int)paraOutput.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dongketnoi();
            }
        }
        public int GetIDBill(int id)
        {
            try
            {
                kn_csdl();
                string sql = "Res_Insert_Bill";
                SqlCommand cmdBill = new SqlCommand(sql, con);
                cmdBill.CommandType = CommandType.StoredProcedure;
                cmdBill.Parameters.AddWithValue("@UserID", id);
                cmdBill.Parameters.AddWithValue("@Status", 1);
                cmdBill.Parameters.AddWithValue("@DateCreate", DateTime.Now);

                SqlParameter paraOutput = new SqlParameter("@ReturnValue", SqlDbType.Int);
                paraOutput.Value = 0;
                paraOutput.Direction = ParameterDirection.Output;
                cmdBill.Parameters.Add(paraOutput);
                cmdBill.ExecuteNonQuery();

                return (int)paraOutput.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dongketnoi();
            }
        }
        public void Ghilog(string content,int userid)
        {
            int kq = ExecStore("[RES_Insert_GhiLog]", new string[] { "@Userid", "@Note"}, new object[] { userid, content });
        }

        //public int InsertObjectReturn(object obj, string spName)
        //{
        //    kn_csdl();
        //    string sql = spName;
        //    foreach (PropertyInfo propertyinfo in obj.GetType().GetProperties())
        //    {
        //        if (propertyinfo.PropertyType.ToString() == "System.DateTime")
        //        {
        //            if ((DateTime)propertyinfo.GetValue(obj, null) == DateTime.MinValue || (DateTime)propertyinfo.GetValue(obj, null) == DateTime.MaxValue)
        //                _sql.AddParameter(new SqlParameter("@" + propertyinfo.Name, DBNull.Value));
        //            else
        //                _sql.AddParameter(new SqlParameter("@" + propertyinfo.Name, propertyinfo.GetValue(obj, null)));
        //        }
        //        else
        //            _sql.AddParameter(new SqlParameter("@" + propertyinfo.Name, propertyinfo.GetValue(obj, null)));
        //    }
        //    SqlParameter paraOutput = new SqlParameter("@ReturnValue", SqlDbType.Int);
        //    paraOutput.Value = 0;
        //    paraOutput.Direction = ParameterDirection.Output;
        //    _sql.AddParameter(paraOutput);
        //    try
        //    {
        //        _sql.ExecuteSP(sql);
        //        return (int)paraOutput.Value;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        dongketnoi();
        //    }
        //}
    }
}

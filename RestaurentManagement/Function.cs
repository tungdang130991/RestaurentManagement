using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RestaurentManagement
{
    class Function
    {
       
        private SqlConnection con = new SqlConnection();
        
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();

        //Function User
         public DataTable GetAccount()
        {
            string chuoikn = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            con.ConnectionString = chuoikn;
            da = new SqlDataAdapter("SELECT * from R_User", con);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
            con.Close();
        }
       
    }
}

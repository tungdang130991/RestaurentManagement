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
using System.Data.SqlClient;

namespace RestaurentManagement
{
    public partial class TableManagement : Form
    {
        private int userid = 0;
        public TableManagement()
        {
            InitializeComponent();
        }
        Connect con = null;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TableManagement_Load(object sender, EventArgs e)
        {
            GetComBox();
            GetTable();
            if (dgvTable.RowCount > 1)
            {
                dgvTable.CurrentCell.Selected = false;
            }
        }
        private void GetTable()
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("select ID,TableName,TableNumber,(select FloorName from R_Floor where R_Floor.ID=R_Tables.FloorID) from R_Tables");
            dgvTable.DataSource = dt;
            dgvTable.Columns[0].HeaderText = "Mã Bản";
            dgvTable.Columns[1].HeaderText = "Tên Bàn";
            dgvTable.Columns[2].HeaderText = "Số Bàn";
            dgvTable.Columns[3].HeaderText = "Tầng";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txttablename.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên bàn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txttablenumber.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số bàn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dt = new DataTable();
                dt = con.laybang("Select TableNumber from R_Tables");
                int sss = 0;
                string tablename = null;
                string tablenamenew = txttablenumber.Text.ToString().Trim();
                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    tablename = dt.Rows[i]["TableNumber"].ToString().Trim();
                    if(tablename==tablenamenew)
                    {
                        sss = 1;
                    }
                }
                if (sss == 0)
                {
                    txttableid.Text = String.Empty;
                    int kq = con.xulydulieu("INSERT INTO R_Tables (TableName, TableNumber,FloorID,Status,TableOrder) VALUES (N'" + txttablename.Text + "', N'" + txttablenumber.Text + "','" + Convert.ToInt32(cbfloor.SelectedValue.ToString()) + "',0,0)");
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã thêm mới thành công");
                        GetTable();
                        con.Ghilog("Thêm mới bàn", userid);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Số bàn bạn nhập đã bị trùng xin vui lòng nhập lại");
                }
            }
        }
        private void GetComBox()
        {
            con = new Connect();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = con.con;
            mysqlcommand.CommandText = "select ID,FloorName from R_Floor";
            con.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbfloor.DataSource = table_MK;
            cbfloor.DisplayMember = table_MK.Columns["FloorName"].ToString();
            cbfloor.ValueMember = table_MK.Columns["ID"].ToString();


            con.con.Close();


        }
        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvTable.Rows[e.RowIndex];
                txttableid.Text = datagridview.Cells[0].Value.ToString();
                txttablename.Text = datagridview.Cells[1].Value.ToString();
                txttablenumber.Text = datagridview.Cells[2].Value.ToString();
                cbfloor.Text = datagridview.Cells[3].Value.ToString();
            }
            catch { }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            con = new Connect();
             if (txttableid.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txttablename.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên bàn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txttablenumber.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số bàn", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                DataTable dt = new DataTable();
                dt = con.laybang("Select TableNumber from R_Tables where ID <>'" + Convert.ToInt32(txttableid.Text) + "'");
                int sss = 0;
                string tablename = null;
                string tablenamenew = txttablenumber.Text.ToString().Trim();
                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    tablename = dt.Rows[i]["TableNumber"].ToString().Trim();
                    if(tablename==tablenamenew)
                    {
                        sss = 1;
                    }
                }
                if (sss == 0)
                {
                    int kq = con.xulydulieu("UPDATE R_Tables SET TableName=N'" + txttablename.Text + "', TableNumber=N'" + txttablenumber.Text + "',FloorID='" + Convert.ToInt32(cbfloor.SelectedValue.ToString()) + "' WHERE ID='" + Convert.ToInt32(txttableid.Text) + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã sửa mới thành công");
                        GetTable();
                        con.Ghilog("Sửa bàn số:'"+txttableid.Text.Trim()+"'", userid);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Số bàn bạn nhập đã bị trùng xin vui lòng nhập lại");
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txttableid.Text != "" && txttableid.Text != null)
            {
                int kq = con.xulydulieu("DELETE FROM R_Tables WHERE ID='" + Convert.ToInt32(txttableid.Text) + "'");

                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    GetTable();
                    con.Ghilog("Xóa bàn số:'" + txttableid.Text.Trim() + "'", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn cần xóa.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

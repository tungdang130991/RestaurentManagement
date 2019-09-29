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
    public partial class Floor : Form
    {
        private int userid=0;
        public Floor(int _userid)
        {
            userid = _userid;
            InitializeComponent();
        }
        Connect con = null;
        private void Floor_Load(object sender, EventArgs e)
        {
            GetTable();
            if (dgvFloor.RowCount > 1)
            {
                dgvFloor.CurrentCell.Selected = false;
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtfloor.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tầng", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtfloorid.Text = String.Empty;
                int kq = con.xulydulieu("INSERT INTO R_Floor (FloorName, Describle) VALUES (N'" + txtfloor.Text + "', N'" + txtdes.Text + "')");
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã thêm mới thành công");
                    GetTable();
                    con.Ghilog("Thêm mới tầng",userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }
        private void GetTable()
        {
            con = new Connect();
            this.dgvFloor.DataSource = null;
            this.dgvFloor.Rows.Clear();
            DataTable dt = new DataTable();
            dt = con.laybang("Select * from R_Floor");
            dgvFloor.DataSource = dt;
            dgvFloor.Columns[0].HeaderText = "Mã Tầng";
            dgvFloor.Columns[1].HeaderText = "Tên tầng";
            dgvFloor.Columns[2].HeaderText = "Mô tả";

        }
        private void dgvFloor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvFloor.Rows[e.RowIndex];
                txtfloorid.Text = datagridview.Cells[0].Value.ToString();
                txtfloor.Text = datagridview.Cells[1].Value.ToString();
                txtdes.Text = datagridview.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtfloorid.Text != "" && txtfloorid.Text != null)
            {
                int kq = con.xulydulieu("DELETE FROM R_Floor WHERE ID='" + Convert.ToInt32(txtfloorid.Text) + "'");

                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    GetTable();
                    con.Ghilog("Xóa tầng số:'"+txtfloorid.Text.Trim()+"'",userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tầng cần xóa.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            con = new Connect();
            if (txtfloorid.Text == "" || txtfloorid.Text == null)
            {
                MessageBox.Show("Bạn chưa chọn tầng muốn sửa", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtfloor.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tầng", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int kq = con.xulydulieu("UPDATE R_Floor SET FloorName=N'" + txtfloor.Text + "', Describle=N'" + txtdes.Text + "' WHERE ID='" + Convert.ToInt32(txtfloorid.Text) + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã sửa mới thành công");
                    GetTable();
                    con.Ghilog("Sửa tầng số:'" + txtfloorid.Text.Trim() + "'", userid);
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }

        }

        private void dgvFloor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvFloor.Rows[e.RowIndex];
                txtfloorid.Text = datagridview.Cells[0].Value.ToString();
                txtfloor.Text = datagridview.Cells[1].Value.ToString();
                txtdes.Text = datagridview.Cells[2].Value.ToString();
            }
            catch { }
        }



    }
}

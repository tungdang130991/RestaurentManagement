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
    public partial class WareHousing : Form
    {
        public WareHousing()
        {
            InitializeComponent();
        }
        Connect con = null;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetTableFood(string where)
        {
            try
            {
                con = new Connect();
                //this.dgvfood.DataSource = null;
                //this.dgvfood.Rows.Clear();
                DataTable dt = new DataTable();
                dt = con.laybang("select FoodName,Warehousing,Price,(Select PackName from R_Packs where ID=R_Foods.PackUnit),Describle from R_Foods where " + where + "");
                dgvfood.DataSource = dt;
                dgvfood.Columns[0].HeaderText = "Tên thực phẩm";
                dgvfood.Columns[1].HeaderText = "Số lượng kho";
                dgvfood.Columns[2].HeaderText = "Giá";
                dgvfood.Columns[3].HeaderText = "Đơn vị tính";
                dgvfood.Columns[4].HeaderText = "Mô tả";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string where2 = null;
            where2 = "1=1";
            if (Convert.ToInt32(cbfoodgroup.SelectedValue) > 0)
            {
                where2 += " and GroupID='" + Convert.ToInt32(cbfoodgroup.SelectedValue) + "'";
            }
            if(textBox1.TextLength>0)
            {
                where2 += " and FoodName Like N'%" + textBox1.Text + "%'";
            }

            GetTableFood(where2);
        }

        private void WareHousing_Load(object sender, EventArgs e)
        {
            con = new Connect();
            con.GetComBoxAll("Select ID,FoodGroupName from R_FoodGroup", cbfoodgroup);
            string where = "1=1";
            GetTableFood(where);
            if (dgvfood.RowCount > 1)
            {
                dgvfood.CurrentCell.Selected = false;
            }
        }
    }
}

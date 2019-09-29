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
    public partial class DishFoodView : Form
    {
        Connect con = null;
        public DishFoodView()
        {
            InitializeComponent();
        }
        string where = "1=1";
        private void DishFoodView_Load(object sender, EventArgs e)
        {
            con = new Connect();
            con.GetComBoxAll("Select ID,DishGroupName from R_DishGroup", cbDishGroup);
            BinTable(where);
        }
        private void BinTable(string whereDish)
        {
            con = new Connect();
            Connect _con = null;
            this.dgvbill.DataSource = null;
            this.dgvbill.Rows.Clear();
            DataTable dt = new DataTable();
            DataTable _dt = new DataTable();
            DataRow dr;
            _dt.Columns.Add(new DataColumn("DishName", typeof(string)));
            _dt.Columns.Add(new DataColumn("FoodName", typeof(string)));
            _dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
            _dt.Columns.Add(new DataColumn("Packs", typeof(string)));
            _dt.Columns.Add(new DataColumn("Price", typeof(string)));

            dt = con.laybang("Select ID,DishName,Price from R_Dish where " + whereDish + "");
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    _con = new Connect();
                    dr = _dt.NewRow();
                    dr[0] = dt.Rows[i].ItemArray[1].ToString();
                    dr[2] = "1";
                    dr[4] = con.GetStringCurency(dt.Rows[i].ItemArray[2].ToString());
                    _dt.Rows.Add(dr);
                    int DishId = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
                    DataTable dt1 = new DataTable();
                    dt1 = _con.laybang("Select rf.ID,rf.FoodName,rdf.Quantity,rf.Price,(Select PackName from R_Packs where ID=rf.PackUnit) from R_Foods rf,R_DishFood rdf where rdf.FoodID=rf.ID and rdf.DishID='" + DishId + "'");
                    if (dt1.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt1.Rows.Count; j++)
                        {
                            dr = _dt.NewRow();
                            dr[1] = dt1.Rows[j].ItemArray[1].ToString();
                            dr[2] = dt1.Rows[j].ItemArray[2].ToString();
                            dr[3] = dt1.Rows[j].ItemArray[4].ToString();
                            dr[4] = con.GetStringCurency(((Convert.ToDecimal(dt1.Rows[j].ItemArray[3].ToString())) * (Convert.ToDecimal(dt1.Rows[j].ItemArray[2].ToString()))).ToString());
                            _dt.Rows.Add(dr);
                        }

                    }

                }
                dgvbill.DataSource = _dt;
                dgvbill.Columns[0].HeaderText = "Tên món ăn";
                dgvbill.Columns[0].DefaultCellStyle.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
                dgvbill.Columns[1].HeaderText = "Thực phẩm cần dùng";
                dgvbill.Columns[2].HeaderText = "Số lượng";
                dgvbill.Columns[3].HeaderText = "Tính theo";
                dgvbill.Columns[4].HeaderText = "Giá";
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
           
               
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string where1 = null;
            where1 += where;
            if(cbDishGroup.SelectedValue.ToString().Trim() != "0")
            { 
            where1 += " and GroupID=" + cbDishGroup.SelectedValue + "";
            }
            if(txtDishName.TextLength>0)
            {
                where1 += " and DishName Like N'%" + txtDishName.Text + "%'";
            }
            BinTable(where1);
        }

        private void txtDishName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string where1 = null;
            where1 += where;
            if (cbDishGroup.SelectedValue.ToString().Trim() != "0")
            {
                where1 += " and GroupID=" + cbDishGroup.SelectedValue + "";
            }
            if (txtDishName.TextLength > 0)
            {
                where1 += " and DishName Like N'%" + txtDishName.Text + "%' or Search Like N'%" + txtDishName.Text + "%'";
            }
            BinTable(where1);
        }
    }
}

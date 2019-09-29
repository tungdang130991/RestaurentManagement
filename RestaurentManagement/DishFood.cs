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
using System.Globalization;

namespace RestaurentManagement
{
    public partial class DishFood : Form
    {
        Connect con = null;
        private int dishid1 = 0;
        private int userid = 0;
        public DishFood(int id,int _userid)
        {
            dishid1 = id;
            userid = _userid;
            InitializeComponent();
        }

        private void DishFood_Load(object sender, EventArgs e)
        {
            string where1 = "1=1";
            BinData();
            GetTableFood(where1);
            GetTableDishFood();
            if (dgvFood.RowCount > 1)
            {
                dgvFood.CurrentCell.Selected = false;
            }
        }
        private void BinData()
        {
            con = new Connect();
            DataTable dt = new DataTable();
            try
            {
                dt = con.laybang("Select DishName from R_Dish where ID='" + dishid1 + "'");
                lblDishName.Text = dt.Rows[0]["DishName"].ToString();
                con.GetComBoxAll("Select ID,FoodGroupName from R_FoodGroup", cbgroupfood);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GetTableFood(string where)
        {
            try
            {
                con = new Connect();
                //this.dgvFood.DataSource = null;
                //this.dgvFood.Rows.Clear();
                DataTable dt = new DataTable();
                dt = con.laybang("select ID,FoodName,Price,(Select FoodGroupName from R_FoodGroup where ID=R_Foods.GroupID) as 'FoodGroupName',(Select PackName from R_Packs where ID=R_Foods.PackUnit) as 'PackName' from R_Foods where " + where + "");
                dgvFood.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GetTableDishFood()
        {
            con = new Connect();
            //this.dgvdishfood.DataSource = null;
            //this.dgvdishfood.Rows.Clear();
            DataTable dt = new DataTable();
            //DataTable _dt = new DataTable();
            //DataRow dr;
            //_dt.Columns.Add(new DataColumn("ID1", typeof(int)));
            //_dt.Columns.Add(new DataColumn("FoodName1", typeof(string)));
            //_dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
            //_dt.Columns.Add(new DataColumn("Pack", typeof(string)));
            //_dt.Columns.Add(new DataColumn("Price1", typeof(string)));
            dt = con.laybang("Select rf.ID as 'ID1',rf.FoodName as 'FoodName1',rdf.Quantity,(Select PackName from R_Packs where ID=rf.PackUnit) as 'Pack',rf.Price as 'Price1' from R_Foods rf,R_DishFood rdf where rf.ID=rdf.FoodID and rdf.DishID='" + dishid1 + "'");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    dr = _dt.NewRow();
            //    dr[0] = dt.Rows[i].ItemArray[0].ToString();
            //    dr[1] = dt.Rows[i].ItemArray[1].ToString();
            //    dr[2] = dt.Rows[i].ItemArray[2].ToString();
            //    dr[3] = dt.Rows[i].ItemArray[3].ToString();
            //    dr[4] = con.GetStringCurency(dt.Rows[i].ItemArray[4].ToString());
            //    _dt.Rows.Add(dr);
            //}
            dgvdishfood.DataSource = dt;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar !='.';
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con = new Connect();
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvFood.Rows[e.RowIndex];
                int iddfood = Convert.ToInt32(datagridview.Cells[0].Value.ToString());
                DataTable dt = new DataTable();
                dt = con.laybang("Select * from R_DishFood where DishID='" + dishid1 + "' and FoodID='" + iddfood + "'");
                if (dt.Rows.Count == 0)
                {
                    int add = con.xulydulieu("INSERT INTO R_DishFood (DishID, FoodID,Quantity) VALUES ('" + dishid1 + "', '" + iddfood + "',1)");
                }
                else
                {
                    Decimal quantity = Convert.ToDecimal(dt.Rows[0]["Quantity"].ToString(), CultureInfo.InvariantCulture) + 1;
                    int kq = con.xulydulieu("Update R_DishFood set Quantity='" + quantity + "' where DishID='" + dishid1 + "' and FoodID='" + iddfood + "'");
                }
                GetTableDishFood();
                txtFoodID.Text = datagridview.Cells[0].Value.ToString();
                txtFoodName.Text = datagridview.Cells[1].Value.ToString();
                txtquantity.Text = "1";
                txtprice.Text = datagridview.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvbilldish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                DataGridViewRow datagridview = new DataGridViewRow();
                datagridview = dgvdishfood.Rows[e.RowIndex];
                txtFoodID.Text = datagridview.Cells[0].Value.ToString();
                txtFoodName.Text = datagridview.Cells[1].Value.ToString();
                txtquantity.Text = datagridview.Cells[2].Value.ToString().Trim();
                txtprice.Text = datagridview.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Where2 = "1=1";
            if (Convert.ToInt32(cbgroupfood.SelectedValue) > 0)
            {
                Where2 += " and GroupID=" + Convert.ToInt32(cbgroupfood.SelectedValue) + " ";
            }
            if(txtname.TextLength>0)
            {
                Where2 += " and FoodName Like N'%" + txtname.Text + "%'";
            }
            GetTableFood(Where2);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtFoodID.Text == "" || txtFoodID.Text == null)
            {
                MessageBox.Show("Bạn chưa chọn thực phẩm muốn sửa", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con = new Connect();
                    int kq = 0;
                    if(txtquantity.Text.Trim() !="")
                    { 
                    if(Convert.ToDecimal(txtquantity.Text)<=0)
                    {
                        kq = con.xulydulieu("Delete from R_DishFood where FoodID='" + Convert.ToInt32(txtFoodID.Text) + "' and DishID='" + dishid1 + "' ");
                    }
                    else
                    { 
                    kq = con.xulydulieu("UPDATE R_DishFood SET Quantity=N'" + txtquantity.Text + "' WHERE FoodID='" + Convert.ToInt32(txtFoodID.Text) + "' and DishID='" + dishid1 + "' ");
                    }
                    }
                        if (kq > 0)
                    {
                        GetTableDishFood();
                        con.Ghilog("Thay đổi Số lượng thực phẩm dùng cho món ăn số:'"+dishid1+"'",userid);
                    }
                }
                catch { }
            }
        }

        private void dgvdishfood_KeyUp(object sender, KeyEventArgs e)
        {
            con = new Connect();
            if (e.KeyCode == Keys.Enter)
            {

                if (dgvdishfood.CurrentCell != null)
                {
                    if (dgvdishfood.CurrentCell.ColumnIndex == 2)
                    {
                        int rowIndex = dgvdishfood.CurrentCell.RowIndex - 1;
                        DataTable dt = new DataTable();
                        dt = con.laybang("Select * from R_DishFood rbd where rbd.DishID='" + dishid1 + "'");
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                string quantitynews = "0";
                                if(dgvdishfood.Rows[i].Cells[2].Value.ToString().Trim()!="")
                                {
                                  quantitynews=dgvdishfood.Rows[i].Cells[2].Value.ToString().Trim();
                                }
                                int _id = Convert.ToInt32(dgvdishfood.Rows[i].Cells[0].Value.ToString().Trim());
                                if (Convert.ToDecimal(quantitynews) <= 0)
                                {
                                    int kq1 = con.xulydulieu("DELETE FROM R_DishFood WHERE DishID='" + dishid1 + "' and FoodID='" + _id + "'");
                                }
                                else
                                {
                                    int kq = con.xulydulieu("Update R_DishFood set Quantity='" + quantitynews + "' where DishID='" + dishid1 + "' and FoodID='" + _id + "'");
                                }
                                con.Ghilog("Thay đổi Số lượng thực phẩm dùng cho món ăn số:'" + dishid1 + "'", userid);
                            }
                        }
                        GetTableDishFood();
                    }
                }
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Where2 = "1=1";
            if (Convert.ToInt32(cbgroupfood.SelectedValue)>0)
            {
            Where2 += " and GroupID=" + Convert.ToInt32(cbgroupfood.SelectedValue) + " ";
                }
            if (txtname.TextLength > 0)
            {
                Where2 += " and FoodName Like N'%" + txtname.Text + "%'";
            }
            GetTableFood(Where2);
        }

        private void dgvdishfood_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void dgvdishfood_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class RestaurentManagementSystem : Form
    {
        private int userid1 = 0;
        public RestaurentManagementSystem(int userid)
        {
            userid1 = userid;
            InitializeComponent();
        }

        private void RestaurentManagementSystem_Load(object sender, EventArgs e)
        {
            if (IsAdmin() == 0)
            {
                tổngHợpToolStripMenuItem.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem4.Enabled = false;
                quảnLýHóaĐơnToolStripMenuItem.Enabled = false;
                quảnLýThựcPhẩmToolStripMenuItem.Enabled = false;
                quảnLýLoạiToolStripMenuItem.Enabled = false;
                toolStripMenuItem7.Enabled = false;
            }
        }

   

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private int IsAdmin()
        {
            int kq = 0;
            Connect con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select * from R_User where ID='" + userid1 + "' and Status=1");
            if (dt.Rows.Count > 0)
            {
                kq = 1;
            }
            return kq;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaodichBanhang giaodichbanhang = new GiaodichBanhang(userid1);

            DialogResult dr = giaodichbanhang.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                giaodichbanhang.Close();
            }
            else if (dr == DialogResult.OK)
            {
                giaodichbanhang.Close();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
                Floor floor = new Floor(userid1);
                DialogResult dr = floor.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    floor.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    floor.Close();
                }
        }
        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                WareHousing housing = new WareHousing();
                DialogResult dr = housing.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    housing.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    housing.Close();
                }
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
                TableManagement table = new TableManagement();
                DialogResult dr = table.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    table.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    table.Close();
                }
        }

        private void qUảnLýMụcMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
                GroupDish groupdish = new GroupDish(userid1);
                DialogResult dr = groupdish.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    groupdish.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    groupdish.Close();
                }
        }

        private void danhSáchMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackDish packdish = new PackDish(userid1);
            DialogResult dr = packdish.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                packdish.Close();
            }
            else if (dr == DialogResult.OK)
            {
                packdish.Close();
            }  
        }

        private void quảnLýLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ListBillImport listbill = new ListBillImport(userid1);
                DialogResult dr = listbill.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    listbill.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    listbill.Close();
                }

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
                GroupFood groupfood = new GroupFood(userid1);
                DialogResult dr = groupfood.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    groupfood.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    groupfood.Close();
                }
        }

        private void loạiThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
                PackUnit pack = new PackUnit();
                DialogResult dr = pack.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    pack.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    pack.Close();
                }
        }

        private void thựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Food food = new Food(userid1);
                DialogResult dr = food.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    food.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    food.Close();
                }
        }

        private void đăngKýNhómHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DishFoodView dishfoodview = new DishFoodView();
                DialogResult dr = dishfoodview.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    dishfoodview.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    dishfoodview.Close();
                }
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Suplier supplier = new Suplier(userid1);
                DialogResult dr = supplier.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    supplier.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    supplier.Close();
                }
        }

        private void thuwcjToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Failfood failfood = new Failfood(userid1);
                DialogResult dr = failfood.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    failfood.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    failfood.Close();
                }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            User user = new User(userid1);
            DialogResult dr = user.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                user.Close();
            }
            else if (dr == DialogResult.OK)
            {
                user.Close();
            }

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
              ChangePassWord changepass = new ChangePassWord(userid1);
                DialogResult dr = changepass.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    changepass.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    changepass.Close();
                }
        }

        private void đăngKýNhómHàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                BillManagement bill = new BillManagement(userid1);
                DialogResult dr = bill.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    bill.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    bill.Close();
                }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void danhSáchHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillImportView bill = new BillImportView(userid1);
            DialogResult dr = bill.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                bill.Close();
            }
            else if (dr == DialogResult.OK)
            {
                bill.Close();
            }
        }

        private void danhSáchBànHủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListReasonLose reasonlose = new ListReasonLose();
            DialogResult dr = reasonlose.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                reasonlose.Close();
            }
            else if (dr == DialogResult.OK)
            {
                reasonlose.Close();
            }
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dish listbill = new Dish(userid1);
            DialogResult dr = listbill.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                listbill.Close();
            }
            else if (dr == DialogResult.OK)
            {
                listbill.Close();
            }
        }

        private void hoạtĐộngNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GhiLogView ghilog = new GhiLogView();
            DialogResult dr = ghilog.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                ghilog.Close();
            }
            else if (dr == DialogResult.OK)
            {
                ghilog.Close();
            }
        }


        private void sủDụngThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DayReportFood dayreportfood = new DayReportFood();
            DialogResult dr = dayreportfood.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                dayreportfood.Close();
            }
            else if (dr == DialogResult.OK)
            {
                dayreportfood.Close();
            }
        }

        private void báoCáoDoanhThuTrongNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DayReport dayreport = new DayReport();
            DialogResult dr = dayreport.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                dayreport.Close();
            }
            else if (dr == DialogResult.OK)
            {
                dayreport.Close();
            }
        }

    }
}

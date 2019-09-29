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
    public partial class GiaodichBanhang : Form
    {
        private int userid = 0;
        public GiaodichBanhang(int id)
        {
            userid = id;
            InitializeComponent();

            dgvBillAllDay.DataSourceChanged += new EventHandler(dataGridView1_DataSourceChanged);
        }
        private Connect con = null;
        private void GiaodichBanhang_Load(object sender, EventArgs e)
        {
            GetQUantityTable();
            GetControlTable();
            GetTableBill();
            if (dgvBillAllDay.RowCount > 1)
            {
                dgvBillAllDay.CurrentCell.Selected = false;
            }
        }

        private void GetTableBill()
        {
            try
            {
                con = new Connect();
                //this.dgvBillAllDay.DataSource = null;
                //this.dgvBillAllDay.Rows.Clear();
                DataTable dt = new DataTable();
                dt = con.laybang("select ID,DateEnd,(select UserName from R_User where ID=rb.UserID),Total,Sale,TotalEnd from R_Bill rb where convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00',103) <= rb.DateEnd and rb.DateEnd  <= convert(datetime,'" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59',103) and Status=0 order by DateEnd asc");
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("ID", typeof(int)));
                _dt.Columns.Add(new DataColumn("TableNumber", typeof(string)));
                _dt.Columns.Add(new DataColumn("DateEnd", typeof(string)));
                _dt.Columns.Add(new DataColumn("UserName", typeof(string)));
                _dt.Columns.Add(new DataColumn("Total", typeof(string)));
                _dt.Columns.Add(new DataColumn("Sale", typeof(string)));
                _dt.Columns.Add(new DataColumn("TotalEnd", typeof(string)));
                if(dt.Rows.Count>0)
                {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string total = con.GetStringCurency(dt.Rows[i].ItemArray[5].ToString());
                    string sale = con.GetStringCurency(dt.Rows[i].ItemArray[4].ToString());
                    string totals = con.GetStringCurency(dt.Rows[i].ItemArray[3].ToString());
                    int idbill = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
                    DataTable dt1 = new DataTable();
                    dt1 = con.laybang("Select TableNumber from R_Tables,R_BillTable where ID=R_BillTable.TableID and R_BillTable.BillID='" + idbill + "'");
                    string tablename = "";
                    for (int g = 0; g < dt1.Rows.Count; g++)
                    {
                        tablename += dt1.Rows[g]["TableNumber"].ToString() + ",";
                    }
                    dr = _dt.NewRow();
                    dr[0] = dt.Rows[i].ItemArray[0].ToString();
                    dr[1] = tablename;
                    dr[2] = Convert.ToDateTime(dt.Rows[i].ItemArray[1]).ToString("HH:mm");
                    dr[3] = dt.Rows[i].ItemArray[2].ToString();
                    dr[4] = totals;
                    dr[5] = sale;
                    dr[6] = total;
                    _dt.Rows.Add(dr);
                }
                }

                dgvBillAllDay.DataSource = _dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private int Idtable(string _tblnumber)
        {
            int id10 = 0;
            con = new Connect();
            DataTable dt = null;
            dt = new DataTable();
            dt = con.laybang("Select ID from R_Tables where TableNumber='" + _tblnumber + "'");
            id10 = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            return id10;
        }

        private void GetNewControl()
        {
            GetQUantityTable();
            lblStatus.Text = null;
            lbltable.Text = null;
            lblTableName.Text = null;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel)
                {
                    Panel tempanel = ctrl as Panel;
                    tempanel.Refresh();
                    tempanel.Dispose();
                }
            }
            GetControlTable();
            GetTableBill();
            dgvBillDish.DataSource = null;
        }
        private void GetNewControl1(string tablenew1)
        {
            con = new Connect();
            DataTable dt = new DataTable();
            dt = con.laybang("Select Status,TableOrder,TableName from R_Tables where TableNumber='" + tablenew1 + "'");
            string status = dt.Rows[0]["Status"].ToString();
            string order = dt.Rows[0]["TableOrder"].ToString();
            string name1 = dt.Rows[0]["TableName"].ToString();
            if (status == "True")
            {

                lblStatus.Text = "Bàn đã có khách";
                lblStatus.ForeColor = Color.Red;
                lbltable.Text = tablenew1;
                lblTableName.Text = name1;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Panel)
                    {
                        Panel tempanel = ctrl as Panel;
                        tempanel.Refresh();
                        tempanel.Dispose();
                    }
                }
            }
            else if (order == "True")
            {
                lblStatus.Text = "Bàn khách đặt";
                lblStatus.ForeColor = Color.Yellow;
                lbltable.Text = tablenew1;
                lblTableName.Text = name1;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Panel)
                    {
                        Panel tempanel = ctrl as Panel;
                        tempanel.Refresh();
                        tempanel.Dispose();
                    }
                }
            }
            GetQUantityTable();
            GetControlTable();
            GetTable();
        }
        private void GetControlTable()
        {
            con = new Connect();
            Panel newpanel = null;
            Panel newpanel1 = null;
            newpanel1 = new Panel();
            newpanel1.Size = new Size(616, 455);
            newpanel1.AutoSize = false;
            newpanel1.AutoScrollMinSize = new System.Drawing.Size(616, 455);
            newpanel1.Location = new Point(26, 35);
            newpanel1.Name = "pnTotal";
            this.Controls.Add(newpanel1);
            Function1.Connect con1 = null;
            DataTable dt1 = new DataTable();
            DataTable dt = null;
            dt1 = con.laybang("Select* from R_Floor");

            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                con1 = new Function1.Connect();
                dt = new DataTable();
                newpanel = new Panel();
                dt = con1.laybang("Select * from R_Tables where FloorID='" + Convert.ToInt32(dt1.Rows[j]["ID"].ToString()) + "'");
                newpanel.Size = new Size(609, 87);
                //newpanel.AutoSize = true;
                newpanel.Name = "pnFloor" + dt1.Rows[j]["ID"].ToString();
                newpanel.Location = new Point(3, 3 + (j * 90));
                newpanel.AutoScroll = true;
                newpanel1.Controls.Add(newpanel);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Button newButton = new Button();
                    newButton.Text = dt.Rows[i]["TableName"].ToString();
                    newButton.Name = "btn" + dt.Rows[i]["TableNumber"].ToString();
                    string tesst = dt.Rows[i]["Status"].ToString();
                    string tesstorder = dt.Rows[i]["TableOrder"].ToString();

                    newButton.Click += new EventHandler(button_Click);
                    newButton.MouseUp += new MouseEventHandler(Control_DoubleClick);
                    newButton.Height = 35;
                    newButton.Width = 70;
                    if (tesst == "True" && tesstorder == "False")
                    {
                        newButton.BackColor = Color.Red;
                    }
                    else if (tesstorder == "True" && tesst == "False")
                    {
                        newButton.BackColor = Color.Yellow;
                        //newButton.MouseUp += new MouseEventHandler(Order_DoubleClick);
                    }
                    else
                    {
                        newButton.BackColor = Color.White;
                    }
                    if (i > 7 && i < 15)
                    {
                        newButton.Location = new Point(3 + ((i - 8) * 74), 90);
                    }
                    else if (i > 15)
                    {
                        newButton.Location = new Point(3 + ((i - 15) * 74), 151);
                    }
                    else
                    {
                        newButton.Location = new Point(3 + (i * 74), 29);
                    }
                    newpanel.Controls.Add(newButton);
                    CheckBox newcheckbox = new CheckBox();
                    newcheckbox.Name = "ckb" + dt.Rows[i]["TableNumber"].ToString();
                    if (tesst == "True")
                    {
                        newcheckbox.Enabled = false;
                        newcheckbox.Checked = false;
                    }
                    newcheckbox.Size = new Size(15, 14);
                    if (i > 7 && i < 15)
                    {
                        newcheckbox.Location = new Point(30 + ((i - 8) * 74), 131);
                    }
                    else if (i > 15)
                    {
                        newcheckbox.Location = new Point(30 + ((i - 15) * 74), 192);
                    }
                    else
                    {
                        newcheckbox.Location = new Point(30 + (i * 74), 70);
                    }
                    newpanel.Controls.Add(newcheckbox);
                }
                TextBox textbox = new TextBox();
                textbox.Text = dt1.Rows[j]["FloorName"].ToString();
                textbox.BackColor = Color.LightGray;
                textbox.Name = "txtfloor" + dt1.Rows[j]["ID"].ToString();
                textbox.Size = new Size(595, 20);
                textbox.TextAlign = HorizontalAlignment.Center;
                textbox.Anchor = AnchorStyles.Bottom;
                textbox.Anchor = AnchorStyles.Top;
                textbox.Anchor = AnchorStyles.Left;
                textbox.Anchor = AnchorStyles.Right;
                textbox.Enabled = false;
                textbox.Location = new Point(3, 3);
                newpanel.Controls.Add(textbox);
                dt.Dispose();
                con1.dongketnoi();
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button btn1 = sender as Button;
            string nametable = btn1.Name.Remove(0, 3);
            lbltable.Text = nametable;
            if (btn1.BackColor == Color.Red)
            {
                lblStatus.Text = "Bàn đã có khách";
                lblStatus.ForeColor = Color.Red;
                GetTable();
            }
            if (btn1.BackColor == Color.White)
            {
                dgvBillDish.DataSource = null;
                dgvBillDish.Rows.Clear();
                dgvBillDish.Refresh();
                lblStatus.Text = "Bàn chưa có khách";
                lblStatus.ForeColor = Color.Green;
            }
            if (btn1.BackColor == Color.Yellow)
            {
                dgvBillDish.DataSource = null;
                dgvBillDish.Rows.Clear();
                dgvBillDish.Refresh();
                lblStatus.Text = "Bàn khách đặt";
                lblStatus.ForeColor = Color.Yellow;
            }
            lblTableName.Text = btn1.Text;
        }
        private void Control_DoubleClick(object sender, MouseEventArgs e)
        {
            Button btn1 = sender as Button;
            string nametable = btn1.Name.Remove(0, 3);
            con = new Connect();
            DataTable _dt = new DataTable();
            _dt = con.laybang("Select * from R_Tables where TableNumber=N'" + nametable + "'");
            string status = _dt.Rows[0]["Status"].ToString();
            string order = _dt.Rows[0]["TableOrder"].ToString();
            if (e.Button == MouseButtons.Right)
            {
                if(btn1.BackColor==Color.White)
                {
                    int ggg = 0;
                    if (status == "False" && order == "False")
                    {
                       
                        int id = con.GetIDBill(userid);
                        BillDish frmdetail = new BillDish(id, userid,nametable);
                        //frmdetaol.MdiParent = this;
                        DialogResult dr = frmdetail.ShowDialog(this);
                        if (dr == DialogResult.Cancel)
                        {
                            frmdetail.Close();
                        }
                        else if (dr == DialogResult.OK)
                        {
                            frmdetail.Close();
                        }
                        DataTable dt1 = new DataTable();
                        dt1 = con.laybang("Select * from R_BillDish where BillID='" + id + "'");
                        if (dt1.Rows.Count > 0)
                        {
                            ggg = 1;
                            DataTable dt11 = new DataTable();
                            dt11 = con.laybang("Select * from R_Tables where TableNumber='" + nametable + "'");
                            int kq = con.xulydulieu("UPDATE R_Tables SET Status=1,TableOrder=0  WHERE TableNumber='" + nametable + "'");
                            con.xulydulieu("Delete from R_CustomerTable where TableID=(Select ID from R_Tables where TableNumber='" + nametable + "')");
                                string tablename = _dt.Rows[0]["TableName"].ToString();
                                int idtable = Convert.ToInt32(_dt.Rows[0]["ID"].ToString());
                                int kq1 = con.SPInsertBillTable("Res_Insert_BillTable", idtable, id);
                                dt11.Dispose();
                                dt11.Clear();
                                btn1.BackColor = Color.Red;
                                GetQUantityTable();
                                lbltable.Text = nametable;
                                lblStatus.Text = "Bàn đã có khách";
                                lblStatus.ForeColor = Color.Red;
                                lblTableName.Text = tablename;
                                lblTableName.ForeColor = Color.Red;
                                GetTable();
                                foreach (Control ctrl in this.Controls)
                                {
                                    if (ctrl is Panel)
                                    {
                                        Panel tempanel = ctrl as Panel;
                                        foreach (Control ctrl1 in tempanel.Controls)
                                        {
                                            if (ctrl1 is Panel)
                                            {
                                                Panel tempanel1 = ctrl1 as Panel;
                                                foreach (Control ctrl12 in tempanel1.Controls)
                                                {
                                                    if (ctrl12 is CheckBox)
                                                    {
                                                        CheckBox tempCheckBox = ctrl12 as CheckBox;
                                                        string nameBox = "ckb" + nametable;
                                                        if(tempCheckBox.Name==nameBox)
                                                        {
                                                            tempCheckBox.Enabled = false;
                                                            break;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                        }
                        else
                        {
                            int kkkk = con.xulydulieu("Delete from R_Bill where ID='" + id + "'");
                        }
                    }
                    if(ggg==1)
                    {
                        con.Ghilog("Thêm hóa đơn cho bàn:'" + nametable + "'", userid);
                    }
                }
                else if (btn1.BackColor == Color.Red)
                {
                    if (status == "True" && order=="False")
                    {
                        DataTable dt = new DataTable();

                        dt = con.ExecStoreTable("RES_Select_BillID", new string[] { "@idtable" }, new object[] { Idtable(nametable) });

                        if (dt.Rows[0].ItemArray[0].ToString() != "")
                        {

                            int id = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                            lbltable.Text = nametable;
                            lblStatus.Text = "Bàn đã có khách";
                            lblStatus.ForeColor = Color.Red;
                            lblTableName.Text = btn1.Text;
                            lblTableName.ForeColor = Color.Red;
                            BillDish frmdetail = new BillDish(id, userid,nametable);
                            frmdetail.passControl = new BillDish.PassControl(GetTable);
                            DialogResult dr = frmdetail.ShowDialog(this);

                            if (dr == DialogResult.Cancel)
                            {
                                frmdetail.Close();
                            }
                            else if (dr == DialogResult.OK)
                            {
                                frmdetail.Close();
                            }

                        }
                    }
                }
                else
                {
                    if (status == "False" && order == "True")
                    {
                        if (btn1.BackColor == Color.Yellow)
                        {
                            DataTable dt = new DataTable();
                            dt = con.laybang("select MAX(CustomerID) from R_CustomerTable where TableID=(Select ID from R_Tables where TableNumber='" + nametable + "'and TableOrder=1)");
                            if (dt.Rows[0]["Column1"].ToString() != "")
                            {
                                int idd = Convert.ToInt32(dt.Rows[0]["Column1"].ToString());
                                Customer customer = new Customer(idd, nametable, userid);
                                //frmdetaol.MdiParent = this;
                                DialogResult dr = customer.ShowDialog(this);
                                if (dr == DialogResult.Cancel)
                                {
                                    customer.Close();
                                }
                                else if (dr == DialogResult.OK)
                                {
                                    customer.Close();
                                }
                            }
                        }
                    }
                }
                
            }
        }
        private void GetTable()
        {
            if (lblStatus.ForeColor == Color.Red && lblStatus.Text != null && lblStatus.Text != "" && lbltable.Text != "")
            {
                con = new Connect();
                DataTable dt = new DataTable();
                DataTable _dt1 = new DataTable();
                _dt1 = con.ExecStoreTable("RES_Select_BillID", new string[] { "@idtable" }, new object[] { Idtable(lbltable.Text) });
                int iddbilll = Convert.ToInt32(_dt1.Rows[0].ItemArray[0].ToString());

                this.dgvBillDish.DataSource = null;
                this.dgvBillDish.Rows.Clear();
                dt = con.laybang("Select rd.DishName,rbd.Quantity,(select R_DishGroup.DishGroupName from R_DishGroup where R_DishGroup.ID=rd.GroupID),rd.Price from R_BillDish rbd, R_Dish rd where rbd.BillID='" + iddbilll + "' and rbd.DishID=rd.ID");
                DataTable _dt = new DataTable();
                DataRow dr;
                _dt.Columns.Add(new DataColumn("Tên món ăn", typeof(string)));
                _dt.Columns.Add(new DataColumn("Số lượng", typeof(string)));
                _dt.Columns.Add(new DataColumn("Nhóm món", typeof(string)));
                _dt.Columns.Add(new DataColumn("Giá", typeof(string)));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string total = con.GetStringCurency(dt.Rows[i].ItemArray[3].ToString());

                    dr = _dt.NewRow();
                    dr[0] = dt.Rows[i].ItemArray[0].ToString();
                    dr[1] = dt.Rows[i].ItemArray[1].ToString().Trim();
                    dr[2] = dt.Rows[i].ItemArray[2].ToString();
                    dr[3] = total;
                    _dt.Rows.Add(dr);
                }
                dgvBillDish.DataSource = _dt;
                //dgvBillDish.Columns[0].HeaderText = "Mã món ăn";
                //dgvBillDish.Columns[1].HeaderText = "Tên món ăn";
                //dgvBillDish.Columns[2].HeaderText = "Số lượng";
                //dgvBillDish.Columns[3].HeaderText = "Nhóm món";
                //dgvBillDish.Columns[4].HeaderText = "Giá";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblStatus.ForeColor == Color.Red && lbltable.Text != "")
            {
                con = new Connect();
                string nametable = lbltable.Text;
                DataTable dt = new DataTable();

                dt = con.ExecStoreTable("RES_Select_BillID", new string[] { "@idtable" }, new object[] { Idtable(lbltable.Text) });

                if (dt.Rows[0].ItemArray[0].ToString() != "")
                {
                    int id = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                    BillDish frmdetail = new BillDish(id, userid,nametable);
                    frmdetail.passControl = new BillDish.PassControl(GetTable);
                    DialogResult dr = frmdetail.ShowDialog(this);

                    if (dr == DialogResult.Cancel)
                    {
                        frmdetail.Close();
                    }
                    else if (dr == DialogResult.OK)
                    {
                        frmdetail.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn để thêm món");
            }
        }
        private void btnaddbill_Click(object sender, EventArgs e)
        {
            con = new Connect();
            Connect con3 = null;
            con3 = new Connect();
            int id = 0;
            DataTable _dt = new DataTable();
            int ssss = 0;
            int ggg = 0;
            string tablenumber = "";
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel)
                {
                    Panel tempanel = ctrl as Panel;
                    foreach (Control ctrl1 in tempanel.Controls)
                    {
                        if (ctrl1 is Panel)
                        {
                            Panel tempanel1 = ctrl1 as Panel;
                            foreach (Control ctrl12 in tempanel1.Controls)
                            {
                                if (ctrl12 is CheckBox)
                                {
                                    CheckBox tempCheckBox = ctrl12 as CheckBox;

                                    if (tempCheckBox.Checked == true)
                                    {
                                        tablenumber = tempCheckBox.Name.Remove(0, 3);
                                        ssss = 1;
                                        id = con.GetIDBill(userid);
                                        BillDish frmdetail = new BillDish(id, userid,tablenumber);
                                        //frmdetaol.MdiParent = this;
                                        DialogResult dr = frmdetail.ShowDialog(this);
                                        if (dr == DialogResult.Cancel)
                                        {
                                            frmdetail.Close();
                                        }
                                        else if (dr == DialogResult.OK)
                                        {
                                            frmdetail.Close();
                                        }
                                        break;
                                    }
                                }
                            }
                            foreach (Control ctrl2 in tempanel1.Controls)
                            {
                                if (ctrl2 is CheckBox)
                                {
                                    CheckBox tempCheckBox = ctrl2 as CheckBox;

                                    if (tempCheckBox.Checked == true)
                                    {

                                        foreach (Control ctrl3 in tempanel1.Controls)
                                        {
                                            if (ctrl3 is Button)
                                            {
                                                DataTable dt1 = new DataTable();
                                                dt1 = con.laybang("Select * from R_BillDish where BillID='" + id + "'");
                                                if (dt1.Rows.Count > 0)
                                                {
                                                    Button tempbutton = ctrl3 as Button;
                                                    tablenumber = tempCheckBox.Name.Remove(0, 3);
                                                    string s = "btn" + tempCheckBox.Name.Remove(0, 3);
                                                    if (tempbutton.Name == s)
                                                    {
                                                        tempbutton.BackColor = Color.Red;
                                                        tempCheckBox.Enabled = false;
                                                        tempCheckBox.Checked = false;
                                                        _dt = con3.laybang("Select * from R_Tables where TableNumber='" + tablenumber + "'");
                                                        int kq = con.xulydulieu("UPDATE R_Tables SET Status=1,TableOrder=0  WHERE TableNumber='" + tablenumber + "'");
                                                        con.xulydulieu("Delete from R_CustomerTable where TableID=(Select ID from R_Tables where TableNumber='" + tablenumber + "')");
                                                        string tablename = _dt.Rows[0]["TableName"].ToString();
                                                        int idtable = Convert.ToInt32(_dt.Rows[0]["ID"].ToString());
                                                        int kq1 = con.SPInsertBillTable("Res_Insert_BillTable", idtable, id);
                                                        _dt.Dispose();
                                                        _dt.Clear();
                                                        GetQUantityTable();
                                                        lbltable.Text = tablenumber;
                                                        lblStatus.Text = "Bàn đã có khách";
                                                        lblStatus.ForeColor = Color.Red;
                                                        lblTableName.Text = tablename;
                                                        lblTableName.ForeColor = Color.Red;
                                                        //tempbutton.MouseUp += new MouseEventHandler(Control_DoubleClick);
                                                        GetTable();
                                                        ggg = 1;
                                                    }
                                                }
                                                else
                                                {
                                                    int kkkk = con.xulydulieu("Delete from R_Bill where ID='" + id + "'");
                                                    tempCheckBox.Checked = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (ssss == 0)
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (ggg == 1)
            {
                con.Ghilog("Thêm hóa đơn cho bàn:'" + tablenumber + "'", userid);
            }
        }

        private void GetQUantityTable()
        {
            con = new Connect();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = con.ExecStores("RES_Select_Tables");
            dt = ds.Tables[0];
            lblbancokhach.Text = dt.Rows.Count.ToString();
            DataTable _dt = new DataTable();
            _dt = ds.Tables[1];
            lblnocustomer.Text = _dt.Rows.Count.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string namebutton = "btn" + lbltable.Text;
            string namechekbox = "ckb" + lbltable.Text;
            con = new Connect();
            DataTable dt = new DataTable();
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is Panel)
                {
                    Panel tempanel = ctrl as Panel;
                    foreach (Control ctrl1 in tempanel.Controls)
                    {
                        if (ctrl1 is Panel)
                        {
                            Panel tempanel1 = ctrl1 as Panel;
                            foreach (Control ctrl12 in tempanel1.Controls)
                            {
                                if (ctrl12 is Button)
                                {
                                    Button tempButton = ctrl12 as Button;

                                    if (tempButton.Name == namebutton)
                                    {
                                        if (lblStatus.ForeColor == Color.Red && lblStatus.Text != "")
                                        {
                                            dt = con.ExecStoreTable("RES_Select_BillID", new string[] { "@idtable" }, new object[] { Idtable(lbltable.Text) });
                                            int _billid = Convert.ToInt32(dt.Rows[0]["column1"].ToString());
                                            ReasonLose reasonlose = new ReasonLose(lbltable.Text, _billid, userid);
                                            reasonlose.passControl = new ReasonLose.PassControl(GetNewControl);
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
                                        if (lblStatus.ForeColor == Color.Yellow && lblStatus.Text != "")
                                        {
                                            con.xulydulieu("Update R_Tables set TableOrder=0 where TableNumber='" + lbltable.Text + "'");
                                            con.xulydulieu("Delete from R_CustomerTable where TableID=(Select ID from R_Tables where TableNumber='" + lbltable.Text + "')");
                                            tempButton.BackColor = Color.White;
                                            con.Ghilog("Hủy bàn đặt:" + lbltable.Text.Trim() + "", userid);
                                            lblStatus.Text = null;
                                            lbltable.Text = null;
                                            lblTableName.Text = null;
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new Connect();
            DataTable _Dt = new DataTable();
            Connect con1 = new Connect();
            DataTable dt = new DataTable();
            if (lbltable.Text != "" && lbltable.Text != null)
            {
                dt = con1.laybang("Select ID,Status,TableOrder from R_Tables where TableNumber='" + lbltable.Text + "'");
                string status = dt.Rows[0]["Status"].ToString();
                string order = dt.Rows[0]["TableOrder"].ToString();
                if (status == "True")
                {

                    _Dt = con.ExecStoreTable("RES_Select_BillID", new string[] { "@idtable" }, new object[] { Idtable(lbltable.Text) });
                    int billid = Convert.ToInt32(_Dt.Rows[0]["column1"].ToString());
                    string tablenumber = lbltable.Text;
                    ChangeTable frmdetail1 = new ChangeTable(billid, tablenumber, userid);
                    frmdetail1.passControl = new ChangeTable.PassControl(GetNewControl1);
                    DialogResult dr = frmdetail1.ShowDialog(this);
                    if (dr == DialogResult.Cancel)
                    {
                        frmdetail1.Close();
                    }
                    else if (dr == DialogResult.OK)
                    {
                        frmdetail1.Close();
                    }
                    //this.Close();
                }
                else if (order == "True")
                {
                    string tablenumber = lbltable.Text;
                    ChangeTable frmdetail1 = new ChangeTable(0, tablenumber, userid);
                    frmdetail1.passControl = new ChangeTable.PassControl(GetNewControl1);
                    DialogResult dr = frmdetail1.ShowDialog(this);
                    if (dr == DialogResult.Cancel)
                    {
                        frmdetail1.Close();
                    }
                    else if (dr == DialogResult.OK)
                    {
                        frmdetail1.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn bàn muốn chuyển!");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblStatus.ForeColor == Color.Red && lbltable.Text != "" && lbltable.Text != null)
            {
                con = new Connect();
                DataTable dt = new DataTable();
                dt = con.ExecStoreTable("RES_Select_BillID", new string[] { "@idtable" }, new object[] { Idtable(lbltable.Text) });
                int billid = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                int kq = con.xulydulieu("Update R_Bill set DateEnd=getdate() where ID='" + billid + "'");
                BillDetail billdetail = new BillDetail(billid, userid);
                billdetail.passControl = new BillDetail.PassControl(GetNewControl);
                DialogResult dr = billdetail.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    billdetail.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    billdetail.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn thanh toán!");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            con = new Connect();
            Connect con2 = null;
            con2 = new Connect();
            int ssss = 0;
            int id = 0;
            DataTable _dt = new DataTable();
            int kkk = 0;


            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel)
                {
                    Panel tempanel = ctrl as Panel;
                    foreach (Control ctrl1 in tempanel.Controls)
                    {
                        if (ctrl1 is Panel)
                        {
                            Panel tempanel1 = ctrl1 as Panel;
                            foreach (Control ctrl12 in tempanel1.Controls)
                            {
                                if (ctrl12 is CheckBox)
                                {
                                    CheckBox tempCheckBox = ctrl12 as CheckBox;

                                    if (tempCheckBox.Checked == true)
                                    {
                                        try
                                        {
                                            string tablenumber = tempCheckBox.Name.Remove(0, 3);
                                            DataTable dt3 = new DataTable();
                                            dt3 = con2.laybang("Select TableOrder from R_Tables where TableNumber='" + tablenumber + "'");
                                            string order = dt3.Rows[0]["TableOrder"].ToString();
                                            if (order == "False")
                                            {
                                                ssss = 1;
                                                id = con2.GetIDExStore("[RES_Insert_Customers]", new string[] { "@DateCreate" }, new object[] { DateTime.Now.ToString() });
                                                Customer customer = new Customer(id, tablenumber, userid);
                                                DialogResult dr = customer.ShowDialog(this);
                                                if (dr == DialogResult.Cancel)
                                                {
                                                    customer.Close();
                                                }
                                                else if (dr == DialogResult.OK)
                                                {
                                                    customer.Close();
                                                }
                                                break;
                                            }
                                        }
                                        catch (System.Exception ex)
                                        {
                                            throw ex;
                                        }

                                    }
                                }
                            }
                            foreach (Control ctrl2 in tempanel1.Controls)
                            {
                                if (ctrl2 is CheckBox)
                                {
                                    CheckBox tempCheckBox = ctrl2 as CheckBox;

                                    if (tempCheckBox.Checked == true)
                                    {

                                        foreach (Control ctrl3 in tempanel1.Controls)
                                        {
                                            if (ctrl3 is Button)
                                            {
                                                Button tempbutton = ctrl3 as Button;
                                                string tablenumber = tempCheckBox.Name.Remove(0, 3);
                                                string s = "btn" + tempCheckBox.Name.Remove(0, 3);
                                                if (tempbutton.Name == s)
                                                {
                                                    _dt = con2.laybang("Select ID,TableOrder,TableName from R_Tables where TableNumber='" + tablenumber + "'");
                                                    string order = _dt.Rows[0]["TableOrder"].ToString();
                                                    string name1 = _dt.Rows[0]["TableName"].ToString();
                                                    if (order == "False")
                                                    {
                                                        try
                                                        {
                                                            kkk = 1;
                                                            tempbutton.BackColor = Color.Yellow;
                                                           // tempbutton.MouseUp += new MouseEventHandler(Order_DoubleClick);
                                                            tempCheckBox.Checked = false;
                                                            lblStatus.Text = "Bàn khách đặt";
                                                            lblStatus.ForeColor = Color.Yellow;
                                                            lbltable.Text = tablenumber;
                                                            lblTableName.Text = name1;
                                                            int idtable = Convert.ToInt32(_dt.Rows[0]["ID"].ToString());
                                                            int kq3 = con.ExecStore("RES_Insert_CustomerTable", new string[] { "@TableID", "@CustomerID" }, new object[] { idtable, id });
                                                            int kq = con.xulydulieu("UPDATE R_Tables SET TableOrder=1 WHERE TableNumber='" + tablenumber + "'");
                                                            //int idtable = Convert.ToInt32(_dt.Rows[0]["ID"].ToString());
                                                            GetQUantityTable();
                                                            con.Ghilog("Đặt bàn " + tablenumber + "", userid);
                                                        }

                                                        catch (System.Exception ex)
                                                        {
                                                            throw ex;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        tempCheckBox.Checked = false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }


                        }
                    }
                }
            }

            if (lblStatus.ForeColor == Color.Yellow && kkk == 0)
            {
                ssss = 1;
                string nametable = lbltable.Text;
                DataTable dt = new DataTable();

                dt = con.laybang("select MAX(CustomerID) from R_CustomerTable where TableID=(Select ID from R_Tables where TableNumber='" + nametable + "'and TableOrder=1)");
                if (dt.Rows[0]["Column1"].ToString() != "")
                {
                    int idd = Convert.ToInt32(dt.Rows[0]["Column1"].ToString());
                    Customer customer = new Customer(idd, nametable, userid);
                    //frmdetaol.MdiParent = this;
                    DialogResult dr = customer.ShowDialog(this);
                    if (dr == DialogResult.Cancel)
                    {
                        customer.Close();
                    }
                    else if (dr == DialogResult.OK)
                    {
                        customer.Close();
                    }
                }
            }
            if (ssss == 0)
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            con = new Connect();
            Decimal sum = 0;
            if (dgvBillAllDay.RowCount>1)
            { 
            for (int i = 0; i < dgvBillAllDay.Rows.Count - 1; i++)
            {
                if (dgvBillAllDay["TotalEnd", i].Value != DBNull.Value)
                {
                    sum += (Decimal)Convert.ToDecimal(dgvBillAllDay["TotalEnd", i].Value.ToString().Replace(",",""));
                }
            }
            dgvBillAllDay["TotalEnd", dgvBillAllDay.Rows.Count - 1].Value = con.GetStringCurency(sum.ToString());
            }
        }

        private void dgvBillAllDay_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    try
                    {
                        DataGridViewRow datagridview = new DataGridViewRow();
                        datagridview = dgvBillAllDay.Rows[e.RowIndex];
                        int idbill = Convert.ToInt32(datagridview.Cells[0].Value.ToString());
                        ContextMenuStrip Menu = new ContextMenuStrip();
                        ToolStripMenuItem MenuOpenPO = new ToolStripMenuItem();
                        MenuOpenPO.MouseDown += new MouseEventHandler(MenuOpenPO_Click);
                        MenuOpenPO.Text = "Xem chi tiet";
                        MenuOpenPO.Name = "" + idbill + "";
                        Menu.Items.AddRange(new ToolStripItem[] { MenuOpenPO });

                        //Assign created context menu strip to the DataGridView
                        dgvBillAllDay.ContextMenuStrip = Menu;
                    }
                    catch (Exception ex)
                    { throw ex; }
                }
            }
            else
                dgvBillAllDay.ContextMenuStrip = null;
        }
        private void MenuOpenPO_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem idd10 = sender as ToolStripMenuItem;
                int id = Convert.ToInt32(idd10.Name);
                BillDetail billdetail = new BillDetail(id, userid);
                DialogResult dr = billdetail.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    billdetail.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    billdetail.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             con = new Connect();
            DataTable _Dt = new DataTable();
            Connect con1 = new Connect();
            DataTable dt = new DataTable();
            if (lbltable.Text != "" && lbltable.Text != null)
            {
                dt = con1.laybang("Select ID,Status,TableOrder from R_Tables where TableNumber='" + lbltable.Text + "'");
                string status = dt.Rows[0]["Status"].ToString();
                if (status == "True")
                {

                    _Dt = con.ExecStoreTable("RES_Select_BillID", new string[] { "@idtable" }, new object[] { Idtable(lbltable.Text) });
                    int billid = Convert.ToInt32(_Dt.Rows[0]["column1"].ToString());
                    string tablenumber = lbltable.Text;
                    GhepBan frmdetail1 = new GhepBan(billid, tablenumber, userid);
                    frmdetail1.passControl = new GhepBan.PassControl(GetNewControl1);
                    DialogResult dr = frmdetail1.ShowDialog(this);
                    if (dr == DialogResult.Cancel)
                    {
                        frmdetail1.Close();
                    }
                    else if (dr == DialogResult.OK)
                    {
                        frmdetail1.Close();
                    }
                }
            }
        }
    }
}

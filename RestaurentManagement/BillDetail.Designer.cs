namespace RestaurentManagement
{
    partial class BillDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbBill = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txttimepay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttimecome = new System.Windows.Forms.TextBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblbilldate = new System.Windows.Forms.Label();
            this.lblbillnumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtsalepercen = new System.Windows.Forms.TextBox();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotals = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtreturn = new System.Windows.Forms.TextBox();
            this.txtreceive = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtdish = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbBill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBill
            // 
            this.grbBill.Controls.Add(this.label15);
            this.grbBill.Controls.Add(this.txttimepay);
            this.grbBill.Controls.Add(this.label3);
            this.grbBill.Controls.Add(this.txttimecome);
            this.grbBill.Controls.Add(this.txtTable);
            this.grbBill.Controls.Add(this.label2);
            this.grbBill.Location = new System.Drawing.Point(12, 57);
            this.grbBill.Name = "grbBill";
            this.grbBill.Size = new System.Drawing.Size(518, 79);
            this.grbBill.TabIndex = 0;
            this.grbBill.TabStop = false;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(4, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 35);
            this.label15.TabIndex = 2;
            this.label15.Text = "Số Bàn:";
            // 
            // txttimepay
            // 
            this.txttimepay.BackColor = System.Drawing.Color.GreenYellow;
            this.txttimepay.Enabled = false;
            this.txttimepay.Location = new System.Drawing.Point(324, 53);
            this.txttimepay.Name = "txttimepay";
            this.txttimepay.Size = new System.Drawing.Size(100, 20);
            this.txttimepay.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giờ ra:";
            // 
            // txttimecome
            // 
            this.txttimecome.BackColor = System.Drawing.Color.GreenYellow;
            this.txttimecome.Enabled = false;
            this.txttimecome.Location = new System.Drawing.Point(167, 53);
            this.txttimecome.Name = "txttimecome";
            this.txttimecome.Size = new System.Drawing.Size(100, 20);
            this.txttimecome.TabIndex = 1;
            // 
            // txtTable
            // 
            this.txtTable.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTable.Enabled = false;
            this.txtTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTable.Location = new System.Drawing.Point(100, 13);
            this.txtTable.Multiline = true;
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(400, 35);
            this.txtTable.TabIndex = 0;
            this.txtTable.Text = "Bàn 1";
            this.txtTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giờ vào:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblbilldate);
            this.groupBox1.Controls.Add(this.lblbillnumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 41);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblbilldate
            // 
            this.lblbilldate.AutoSize = true;
            this.lblbilldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbilldate.Location = new System.Drawing.Point(223, 14);
            this.lblbilldate.Name = "lblbilldate";
            this.lblbilldate.Size = new System.Drawing.Size(0, 15);
            this.lblbilldate.TabIndex = 2;
            // 
            // lblbillnumber
            // 
            this.lblbillnumber.AutoSize = true;
            this.lblbillnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillnumber.Location = new System.Drawing.Point(73, 14);
            this.lblbillnumber.Name = "lblbillnumber";
            this.lblbillnumber.Size = new System.Drawing.Size(92, 15);
            this.lblbillnumber.TabIndex = 2;
            this.lblbillnumber.Text = "lblbillnumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(177, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú:";
            // 
            // dgvbill
            // 
            this.dgvbill.AllowUserToResizeColumns = false;
            this.dgvbill.AllowUserToResizeRows = false;
            this.dgvbill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvbill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DishName,
            this.Quantity,
            this.FoodGroup,
            this.Price});
            this.dgvbill.Location = new System.Drawing.Point(15, 197);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.RowHeadersVisible = false;
            this.dgvbill.Size = new System.Drawing.Size(515, 217);
            this.dgvbill.TabIndex = 17;
            this.dgvbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            this.dgvbill.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvbill_EditingControlShowing);
            this.dgvbill.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvbill_KeyUp);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DishName.DataPropertyName = "DishName";
            this.DishName.FillWeight = 364.0719F;
            this.DishName.HeaderText = "Tên món ăn";
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            this.DishName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 11.97604F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 70;
            // 
            // FoodGroup
            // 
            this.FoodGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoodGroup.DataPropertyName = "FoodGroup";
            this.FoodGroup.FillWeight = 11.97604F;
            this.FoodGroup.HeaderText = "Nhóm món ăn";
            this.FoodGroup.Name = "FoodGroup";
            this.FoodGroup.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 11.97604F;
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 524);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(359, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "In và Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(124, 533);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(104, 20);
            this.txtTotal.TabIndex = 36;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSale_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tổng thanh toán:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtsalepercen);
            this.groupBox2.Controls.Add(this.txtSale);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(275, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 79);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Triết khấu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(200, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 16);
            this.label16.TabIndex = 48;
            this.label16.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(198, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 49;
            this.label14.Text = "VND";
            // 
            // txtsalepercen
            // 
            this.txtsalepercen.Location = new System.Drawing.Point(84, 47);
            this.txtsalepercen.Name = "txtsalepercen";
            this.txtsalepercen.Size = new System.Drawing.Size(104, 20);
            this.txtsalepercen.TabIndex = 3;
            this.txtsalepercen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSale_KeyPress);
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(84, 21);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(104, 20);
            this.txtSale.TabIndex = 2;
            this.txtSale.TextChanged += new System.EventHandler(this.txtSale_TextChanged_1);
            this.txtSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSale_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Theo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(385, 423);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Tổng:";
            // 
            // txtTotals
            // 
            this.txtTotals.Enabled = false;
            this.txtTotals.Location = new System.Drawing.Point(426, 420);
            this.txtTotals.Name = "txtTotals";
            this.txtTotals.Size = new System.Drawing.Size(104, 20);
            this.txtTotals.TabIndex = 37;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtreturn);
            this.groupBox3.Controls.Add(this.txtreceive);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(16, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 79);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // txtreturn
            // 
            this.txtreturn.Enabled = false;
            this.txtreturn.Location = new System.Drawing.Point(100, 48);
            this.txtreturn.Name = "txtreturn";
            this.txtreturn.Size = new System.Drawing.Size(104, 20);
            this.txtreturn.TabIndex = 41;
            this.txtreturn.TextChanged += new System.EventHandler(this.txtreturn_TextChanged);
            this.txtreturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSale_KeyPress);
            // 
            // txtreceive
            // 
            this.txtreceive.Location = new System.Drawing.Point(100, 20);
            this.txtreceive.Name = "txtreceive";
            this.txtreceive.Size = new System.Drawing.Size(104, 20);
            this.txtreceive.TabIndex = 1;
            this.txtreceive.TextChanged += new System.EventHandler(this.txtreceive_TextChanged);
            this.txtreceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSale_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Tiền trả lại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tiền nhận:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(74, 139);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(456, 52);
            this.txtNote.TabIndex = 47;
            // 
            // txtdish
            // 
            this.txtdish.ForeColor = System.Drawing.SystemColors.Control;
            this.txtdish.Location = new System.Drawing.Point(18, 168);
            this.txtdish.Name = "txtdish";
            this.txtdish.Size = new System.Drawing.Size(54, 23);
            this.txtdish.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 49;
            this.button1.Text = "In Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(539, 568);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdish);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotals);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvbill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbBill);
            this.Controls.Add(this.label5);
            this.KeyPreview = true;
            this.Name = "BillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Thanh Toán";
            this.Load += new System.EventHandler(this.BillDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillDetail_KeyDown);
            this.grbBill.ResumeLayout(false);
            this.grbBill.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBill;
        private System.Windows.Forms.TextBox txttimepay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttimecome;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblbillnumber;
        private System.Windows.Forms.Label lblbilldate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtsalepercen;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotals;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtreturn;
        private System.Windows.Forms.TextBox txtreceive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label txtdish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button button1;
    }
}
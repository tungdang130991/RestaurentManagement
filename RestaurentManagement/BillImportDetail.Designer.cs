namespace RestaurentManagement
{
    partial class BillImportDetail
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgroupfood = new System.Windows.Forms.ComboBox();
            this.dgvbillfood = new System.Windows.Forms.DataGridView();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtowe = new System.Windows.Forms.TextBox();
            this.txtthanhtoan = new System.Windows.Forms.TextBox();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbillfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tổng:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(436, 510);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 49;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(420, 268);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(116, 25);
            this.btnexit.TabIndex = 39;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(432, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên thực phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nhóm thực phẩm:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(326, 15);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 37;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // cbgroupfood
            // 
            this.cbgroupfood.FormattingEnabled = true;
            this.cbgroupfood.Location = new System.Drawing.Point(105, 14);
            this.cbgroupfood.Name = "cbgroupfood";
            this.cbgroupfood.Size = new System.Drawing.Size(121, 21);
            this.cbgroupfood.TabIndex = 35;
            // 
            // dgvbillfood
            // 
            this.dgvbillfood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbillfood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvbillfood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvbillfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbillfood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.NameFood,
            this.Quantity,
            this.PackUnit,
            this.Price1,
            this.PriceTotal});
            this.dgvbillfood.Location = new System.Drawing.Point(14, 299);
            this.dgvbillfood.Name = "dgvbillfood";
            this.dgvbillfood.RowHeadersVisible = false;
            this.dgvbillfood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbillfood.Size = new System.Drawing.Size(522, 200);
            this.dgvbillfood.TabIndex = 34;
            this.dgvbillfood.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvbillfood_EditingControlShowing);
            this.dgvbillfood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvbillfood_KeyPress);
            this.dgvbillfood.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvbillfood_KeyUp);
            // 
            // dgvFood
            // 
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FoodName,
            this.PackName,
            this.FoodGroupName,
            this.Describle});
            this.dgvFood.Location = new System.Drawing.Point(14, 42);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(522, 188);
            this.dgvFood.TabIndex = 33;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtowe);
            this.groupBox1.Controls.Add(this.txtthanhtoan);
            this.groupBox1.Location = new System.Drawing.Point(12, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 63);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Còn nợ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Thanh Toán:";
            // 
            // txtowe
            // 
            this.txtowe.Enabled = false;
            this.txtowe.Location = new System.Drawing.Point(253, 28);
            this.txtowe.Name = "txtowe";
            this.txtowe.Size = new System.Drawing.Size(100, 20);
            this.txtowe.TabIndex = 61;
            this.txtowe.TextChanged += new System.EventHandler(this.txtowe_TextChanged);
            this.txtowe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtthanhtoan_KeyPress);
            // 
            // txtthanhtoan
            // 
            this.txtthanhtoan.Location = new System.Drawing.Point(79, 28);
            this.txtthanhtoan.Name = "txtthanhtoan";
            this.txtthanhtoan.Size = new System.Drawing.Size(100, 20);
            this.txtthanhtoan.TabIndex = 1;
            this.txtthanhtoan.TextChanged += new System.EventHandler(this.txtthanhtoan_TextChanged);
            this.txtthanhtoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtthanhtoan_KeyPress);
            // 
            // btnsupplier
            // 
            this.btnsupplier.ForeColor = System.Drawing.Color.Red;
            this.btnsupplier.Location = new System.Drawing.Point(420, 237);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Size = new System.Drawing.Size(116, 26);
            this.btnsupplier.TabIndex = 56;
            this.btnsupplier.Text = "Lưu nhà cung cấp";
            this.btnsupplier.UseVisualStyleBackColor = true;
            this.btnsupplier.Click += new System.EventHandler(this.btnsupplier_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(109, 238);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(305, 21);
            this.cbSupplier.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Nhà cung cấp:";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(399, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 32);
            this.button2.TabIndex = 56;
            this.button2.Text = "In Hóa Đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(81, 270);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(333, 20);
            this.txtNote.TabIndex = 2;
            // 
            // ID1
            // 
            this.ID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID1.DataPropertyName = "ID1";
            this.ID1.HeaderText = "Mã";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Width = 30;
            // 
            // NameFood
            // 
            this.NameFood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameFood.DataPropertyName = "NameFood";
            this.NameFood.HeaderText = "Tên thực phẩm";
            this.NameFood.Name = "NameFood";
            this.NameFood.ReadOnly = true;
            this.NameFood.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 75;
            // 
            // PackUnit
            // 
            this.PackUnit.DataPropertyName = "PackUnit";
            this.PackUnit.HeaderText = "Đơn vị ";
            this.PackUnit.Name = "PackUnit";
            this.PackUnit.ReadOnly = true;
            // 
            // Price1
            // 
            this.Price1.DataPropertyName = "Price1";
            this.Price1.HeaderText = "Giá";
            this.Price1.Name = "Price1";
            // 
            // PriceTotal
            // 
            this.PriceTotal.DataPropertyName = "PriceTotal";
            this.PriceTotal.HeaderText = "Tổng giá";
            this.PriceTotal.Name = "PriceTotal";
            this.PriceTotal.ReadOnly = true;
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
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Tên thực phẩm";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            this.FoodName.Width = 200;
            // 
            // PackName
            // 
            this.PackName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PackName.DataPropertyName = "PackName";
            this.PackName.HeaderText = "Đơn vị";
            this.PackName.Name = "PackName";
            this.PackName.ReadOnly = true;
            this.PackName.Width = 70;
            // 
            // FoodGroupName
            // 
            this.FoodGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoodGroupName.DataPropertyName = "FoodGroupName";
            this.FoodGroupName.HeaderText = "Nhóm";
            this.FoodGroupName.Name = "FoodGroupName";
            this.FoodGroupName.ReadOnly = true;
            this.FoodGroupName.Width = 80;
            // 
            // Describle
            // 
            this.Describle.DataPropertyName = "Describle";
            this.Describle.HeaderText = "Mô tả";
            this.Describle.Name = "Describle";
            this.Describle.ReadOnly = true;
            // 
            // BillImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsupplier);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cbgroupfood);
            this.Controls.Add(this.dgvbillfood);
            this.Controls.Add(this.dgvFood);
            this.KeyPreview = true;
            this.Name = "BillImportDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn nhập";
            this.Load += new System.EventHandler(this.BillImportDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillImportDetail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbillfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgroupfood;
        private System.Windows.Forms.DataGridView dgvbillfood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtowe;
        private System.Windows.Forms.TextBox txtthanhtoan;
        private System.Windows.Forms.Button btnsupplier;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describle;
    }
}
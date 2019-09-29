namespace RestaurentManagement
{
    partial class BillDish
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
            this.dgvDish = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbgroupdish = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvbilldish = new System.Windows.Forms.DataGridView();
            this.IDbilldish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricedish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtDishID = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilldish)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDish
            // 
            this.dgvDish.AllowDrop = true;
            this.dgvDish.AllowUserToResizeColumns = false;
            this.dgvDish.AllowUserToResizeRows = false;
            this.dgvDish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDish.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DishName,
            this.Price,
            this.Pack1,
            this.DishGroupName});
            this.dgvDish.Location = new System.Drawing.Point(12, 42);
            this.dgvDish.Name = "dgvDish";
            this.dgvDish.ReadOnly = true;
            this.dgvDish.RowHeadersVisible = false;
            this.dgvDish.Size = new System.Drawing.Size(520, 199);
            this.dgvDish.TabIndex = 0;
            this.dgvDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDish_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 126.9036F;
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DishName.DataPropertyName = "DishName";
            this.DishName.FillWeight = 93.27411F;
            this.DishName.HeaderText = "Tên món ăn";
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            this.DishName.Width = 200;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 93.27411F;
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 70;
            // 
            // Pack1
            // 
            this.Pack1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pack1.DataPropertyName = "Pack1";
            this.Pack1.FillWeight = 93.27411F;
            this.Pack1.HeaderText = "Đơn vị";
            this.Pack1.Name = "Pack1";
            this.Pack1.ReadOnly = true;
            this.Pack1.Width = 85;
            // 
            // DishGroupName
            // 
            this.DishGroupName.DataPropertyName = "DishGroupName";
            this.DishGroupName.FillWeight = 93.27411F;
            this.DishGroupName.HeaderText = "Nhóm món";
            this.DishGroupName.Name = "DishGroupName";
            this.DishGroupName.ReadOnly = true;
            // 
            // cbgroupdish
            // 
            this.cbgroupdish.FormattingEnabled = true;
            this.cbgroupdish.Location = new System.Drawing.Point(80, 14);
            this.cbgroupdish.Name = "cbgroupdish";
            this.cbgroupdish.Size = new System.Drawing.Size(121, 21);
            this.cbgroupdish.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(275, 15);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(137, 20);
            this.txtname.TabIndex = 2;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhóm Món:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(428, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Món:";
            // 
            // dgvbilldish
            // 
            this.dgvbilldish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbilldish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbilldish.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvbilldish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvbilldish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbilldish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbilldish,
            this.NameDish,
            this.Quantity,
            this.GroupDish,
            this.Pricedish});
            this.dgvbilldish.Location = new System.Drawing.Point(12, 303);
            this.dgvbilldish.Name = "dgvbilldish";
            this.dgvbilldish.RowHeadersVisible = false;
            this.dgvbilldish.Size = new System.Drawing.Size(522, 213);
            this.dgvbilldish.TabIndex = 0;
            this.dgvbilldish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbilldish_CellClick);
            this.dgvbilldish.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvbilldish_EditingControlShowing);
            this.dgvbilldish.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvbilldish_KeyUp);
            // 
            // IDbilldish
            // 
            this.IDbilldish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDbilldish.DataPropertyName = "IDbilldish";
            this.IDbilldish.HeaderText = "Mã";
            this.IDbilldish.Name = "IDbilldish";
            this.IDbilldish.ReadOnly = true;
            this.IDbilldish.Width = 30;
            // 
            // NameDish
            // 
            this.NameDish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameDish.DataPropertyName = "NameDish";
            this.NameDish.HeaderText = "Tên món ăn";
            this.NameDish.Name = "NameDish";
            this.NameDish.ReadOnly = true;
            this.NameDish.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // GroupDish
            // 
            this.GroupDish.DataPropertyName = "GroupDish";
            this.GroupDish.HeaderText = "Nhóm món ăn";
            this.GroupDish.Name = "GroupDish";
            this.GroupDish.ReadOnly = true;
            // 
            // Pricedish
            // 
            this.Pricedish.DataPropertyName = "Pricedish";
            this.Pricedish.HeaderText = "Giá";
            this.Pricedish.Name = "Pricedish";
            this.Pricedish.ReadOnly = true;
            // 
            // txtDishName
            // 
            this.txtDishName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDishName.Enabled = false;
            this.txtDishName.Location = new System.Drawing.Point(110, 277);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(312, 20);
            this.txtDishName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá:";
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(133, 251);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(96, 20);
            this.txtprice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng:";
            // 
            // txtquantity
            // 
            this.txtquantity.Enabled = false;
            this.txtquantity.Location = new System.Drawing.Point(302, 251);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(120, 20);
            this.txtquantity.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(434, 252);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 43);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtDishID
            // 
            this.txtDishID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDishID.Enabled = false;
            this.txtDishID.Location = new System.Drawing.Point(15, 277);
            this.txtDishID.Name = "txtDishID";
            this.txtDishID.Size = new System.Drawing.Size(82, 20);
            this.txtDishID.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(434, 522);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng:";
            // 
            // lblTable
            // 
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTable.ForeColor = System.Drawing.Color.Red;
            this.lblTable.Location = new System.Drawing.Point(15, 244);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(74, 30);
            this.lblTable.TabIndex = 15;
            this.lblTable.Text = "label6";
            // 
            // BillDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 546);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDishID);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cbgroupdish);
            this.Controls.Add(this.dgvbilldish);
            this.Controls.Add(this.dgvDish);
            this.Name = "BillDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BillDish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilldish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDish;
        private System.Windows.Forms.ComboBox cbgroupdish;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvbilldish;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtDishID;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbilldish;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupDish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricedish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishGroupName;
        private System.Windows.Forms.Label lblTable;
    }
}
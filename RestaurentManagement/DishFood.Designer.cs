namespace RestaurentManagement
{
    partial class DishFood
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
            this.btnedit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgroupfood = new System.Windows.Forms.ComboBox();
            this.dgvdishfood = new System.Windows.Forms.DataGridView();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDishName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdishfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnedit
            // 
            this.btnedit.ForeColor = System.Drawing.Color.Red;
            this.btnedit.Location = new System.Drawing.Point(428, 283);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(50, 52);
            this.btnedit.TabIndex = 20;
            this.btnedit.Text = "Lưu";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(484, 283);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(50, 52);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(322, 286);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 20);
            this.txtquantity.TabIndex = 18;
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số lượng:";
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(322, 315);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giá:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(458, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Thực Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nhóm Thực Phẩm:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(320, 11);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 20);
            this.txtname.TabIndex = 19;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // cbgroupfood
            // 
            this.cbgroupfood.FormattingEnabled = true;
            this.cbgroupfood.Location = new System.Drawing.Point(109, 11);
            this.cbgroupfood.Name = "cbgroupfood";
            this.cbgroupfood.Size = new System.Drawing.Size(112, 21);
            this.cbgroupfood.TabIndex = 17;
            // 
            // dgvdishfood
            // 
            this.dgvdishfood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdishfood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvdishfood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdishfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdishfood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.FoodName1,
            this.Quantity,
            this.Pack,
            this.Price1});
            this.dgvdishfood.Location = new System.Drawing.Point(12, 351);
            this.dgvdishfood.Name = "dgvdishfood";
            this.dgvdishfood.RowHeadersVisible = false;
            this.dgvdishfood.Size = new System.Drawing.Size(522, 208);
            this.dgvdishfood.TabIndex = 16;
            this.dgvdishfood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbilldish_CellClick);
            this.dgvdishfood.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvdishfood_EditingControlShowing);
            this.dgvdishfood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvdishfood_KeyPress);
            this.dgvdishfood.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvdishfood_KeyUp);
            // 
            // txtFoodID
            // 
            this.txtFoodID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtFoodID.Enabled = false;
            this.txtFoodID.Location = new System.Drawing.Point(109, 315);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(128, 20);
            this.txtFoodID.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mã Thực phẩm:";
            // 
            // lblDishName
            // 
            this.lblDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishName.ForeColor = System.Drawing.Color.Red;
            this.lblDishName.Location = new System.Drawing.Point(12, 252);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(521, 26);
            this.lblDishName.TabIndex = 34;
            this.lblDishName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tên Thực phẩm:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtFoodName.Enabled = false;
            this.txtFoodName.Location = new System.Drawing.Point(109, 286);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(128, 20);
            this.txtFoodName.TabIndex = 36;
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
            this.Price,
            this.FoodGroupName,
            this.PackName});
            this.dgvFood.Location = new System.Drawing.Point(11, 38);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(522, 211);
            this.dgvFood.TabIndex = 37;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // ID1
            // 
            this.ID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID1.DataPropertyName = "ID1";
            this.ID1.FillWeight = 76.14214F;
            this.ID1.HeaderText = "Mã";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Width = 30;
            // 
            // FoodName1
            // 
            this.FoodName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoodName1.DataPropertyName = "FoodName1";
            this.FoodName1.FillWeight = 105.9645F;
            this.FoodName1.HeaderText = "Tên thực phẩm";
            this.FoodName1.Name = "FoodName1";
            this.FoodName1.ReadOnly = true;
            this.FoodName1.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 105.9645F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Pack
            // 
            this.Pack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pack.DataPropertyName = "Pack";
            this.Pack.FillWeight = 105.9645F;
            this.Pack.HeaderText = "Đơn vị";
            this.Pack.Name = "Pack";
            this.Pack.ReadOnly = true;
            this.Pack.Width = 80;
            // 
            // Price1
            // 
            this.Price1.DataPropertyName = "Price1";
            this.Price1.FillWeight = 105.9645F;
            this.Price1.HeaderText = "Giá";
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
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
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 70;
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
            // PackName
            // 
            this.PackName.DataPropertyName = "PackName";
            this.PackName.HeaderText = "Đơn vị";
            this.PackName.Name = "PackName";
            this.PackName.ReadOnly = true;
            // 
            // DishFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 571);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDishName);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cbgroupfood);
            this.Controls.Add(this.dgvdishfood);
            this.Name = "DishFood";
            this.Text = "Thực phẩm dùng cho món ăn";
            this.Load += new System.EventHandler(this.DishFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdishfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgroupfood;
        private System.Windows.Forms.DataGridView dgvdishfood;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDishName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackName;

    }
}
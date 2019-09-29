namespace RestaurentManagement
{
    partial class Dish
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
            this.PackNameDish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtDishDescrible = new System.Windows.Forms.TextBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.txtDishID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdishprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbdishgroup = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPackDish = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDish)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDish
            // 
            this.dgvDish.AllowUserToResizeColumns = false;
            this.dgvDish.AllowUserToResizeRows = false;
            this.dgvDish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDish.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDish.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DishName,
            this.PackNameDish,
            this.Price,
            this.DishGroupName,
            this.Describle,
            this.Search});
            this.dgvDish.Location = new System.Drawing.Point(12, 167);
            this.dgvDish.Name = "dgvDish";
            this.dgvDish.RowHeadersVisible = false;
            this.dgvDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDish.Size = new System.Drawing.Size(589, 219);
            this.dgvDish.TabIndex = 31;
            this.dgvDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDish_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DishName.DataPropertyName = "DishName";
            this.DishName.FillWeight = 510.1796F;
            this.DishName.HeaderText = "Tên Món Ăn";
            this.DishName.Name = "DishName";
            // 
            // PackNameDish
            // 
            this.PackNameDish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PackNameDish.DataPropertyName = "PackNameDish";
            this.PackNameDish.FillWeight = 17.96408F;
            this.PackNameDish.HeaderText = "Đơn vị tính";
            this.PackNameDish.Name = "PackNameDish";
            this.PackNameDish.Width = 70;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 17.96408F;
            this.Price.HeaderText = "Giá món ăn";
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // DishGroupName
            // 
            this.DishGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DishGroupName.DataPropertyName = "DishGroupName";
            this.DishGroupName.FillWeight = 17.96408F;
            this.DishGroupName.HeaderText = "Nhóm món ăn";
            this.DishGroupName.Name = "DishGroupName";
            this.DishGroupName.Width = 90;
            // 
            // Describle
            // 
            this.Describle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Describle.DataPropertyName = "Describle";
            this.Describle.FillWeight = 17.96408F;
            this.Describle.HeaderText = "Mô tả";
            this.Describle.Name = "Describle";
            this.Describle.Width = 75;
            // 
            // Search
            // 
            this.Search.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Search.DataPropertyName = "Search";
            this.Search.FillWeight = 17.96408F;
            this.Search.HeaderText = "Mã TK";
            this.Search.Name = "Search";
            this.Search.Width = 50;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(448, 114);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(113, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnedit.Location = new System.Drawing.Point(448, 89);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(113, 23);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Lưu";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btndelete.Location = new System.Drawing.Point(326, 114);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(119, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnadd.Location = new System.Drawing.Point(326, 89);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(119, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtDishDescrible
            // 
            this.txtDishDescrible.Location = new System.Drawing.Point(105, 66);
            this.txtDishDescrible.Multiline = true;
            this.txtDishDescrible.Name = "txtDishDescrible";
            this.txtDishDescrible.Size = new System.Drawing.Size(177, 94);
            this.txtDishDescrible.TabIndex = 3;
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(105, 40);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(177, 20);
            this.txtDishName.TabIndex = 2;
            // 
            // txtDishID
            // 
            this.txtDishID.Location = new System.Drawing.Point(105, 13);
            this.txtDishID.Name = "txtDishID";
            this.txtDishID.Size = new System.Drawing.Size(177, 20);
            this.txtDishID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên món ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã TK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Giá món ăn:";
            // 
            // txtdishprice
            // 
            this.txtdishprice.Location = new System.Drawing.Point(416, 14);
            this.txtdishprice.Name = "txtdishprice";
            this.txtdishprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdishprice.Size = new System.Drawing.Size(145, 20);
            this.txtdishprice.TabIndex = 3;
            this.txtdishprice.TextChanged += new System.EventHandler(this.txtdishprice_TextChanged);
            this.txtdishprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdishprice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nhóm món ăn:";
            // 
            // cbdishgroup
            // 
            this.cbdishgroup.FormattingEnabled = true;
            this.cbdishgroup.Location = new System.Drawing.Point(416, 40);
            this.cbdishgroup.Name = "cbdishgroup";
            this.cbdishgroup.Size = new System.Drawing.Size(145, 21);
            this.cbdishgroup.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(11, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(592, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thêm thực phẩm dùng cho món ăn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSearch.Location = new System.Drawing.Point(326, 139);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 23);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "Tìm kiếm";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Đơn vị tính:";
            // 
            // cbPackDish
            // 
            this.cbPackDish.FormattingEnabled = true;
            this.cbPackDish.Location = new System.Drawing.Point(416, 65);
            this.cbPackDish.Name = "cbPackDish";
            this.cbPackDish.Size = new System.Drawing.Size(144, 21);
            this.cbPackDish.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(33, 227);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 16);
            this.lblID.TabIndex = 21;
            // 
            // Dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 423);
            this.Controls.Add(this.cbPackDish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbdishgroup);
            this.Controls.Add(this.dgvDish);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtDishDescrible);
            this.Controls.Add(this.txtdishprice);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.txtDishID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Món ăn";
            this.Load += new System.EventHandler(this.Dish_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dish_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDish;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtDishDescrible;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.TextBox txtDishID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdishprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbdishgroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPackDish;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackNameDish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search;
    }
}
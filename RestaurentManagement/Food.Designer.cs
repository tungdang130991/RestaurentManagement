namespace RestaurentManagement
{
    partial class Food
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbpack = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.cbgroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(298, 97);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 25);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnedit.Location = new System.Drawing.Point(298, 41);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 25);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btndelete.Location = new System.Drawing.Point(298, 70);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 25);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnadd.Location = new System.Drawing.Point(298, 13);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 25);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToResizeColumns = false;
            this.dgvFood.AllowUserToResizeRows = false;
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(12, 153);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(612, 237);
            this.dgvFood.TabIndex = 13;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên thực phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã thực phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Giá:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(128, 44);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(164, 20);
            this.txtFoodName.TabIndex = 1;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Enabled = false;
            this.txtFoodID.Location = new System.Drawing.Point(128, 14);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(164, 20);
            this.txtFoodID.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(456, 16);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // cbpack
            // 
            this.cbpack.FormattingEnabled = true;
            this.cbpack.Location = new System.Drawing.Point(128, 73);
            this.cbpack.Name = "cbpack";
            this.cbpack.Size = new System.Drawing.Size(164, 21);
            this.cbpack.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mô tả:";
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(456, 48);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(164, 47);
            this.txtdes.TabIndex = 5;
            // 
            // cbgroup
            // 
            this.cbgroup.FormattingEnabled = true;
            this.cbgroup.Location = new System.Drawing.Point(128, 101);
            this.cbgroup.Name = "cbgroup";
            this.cbgroup.Size = new System.Drawing.Size(164, 21);
            this.cbgroup.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhóm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Số lượng:";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(456, 101);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(163, 20);
            this.txtquantity.TabIndex = 20;
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tìm kiếm theo tên thực phẩm:";
            // 
            // txtSerach
            // 
            this.txtSerach.Location = new System.Drawing.Point(227, 127);
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.Size = new System.Drawing.Size(146, 20);
            this.txtSerach.TabIndex = 21;
            this.txtSerach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerach_KeyPress);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 402);
            this.Controls.Add(this.txtSerach);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbgroup);
            this.Controls.Add(this.cbpack);
            this.Name = "Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực phẩm";
            this.Load += new System.EventHandler(this.Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbpack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.ComboBox cbgroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSerach;
    }
}
namespace RestaurentManagement
{
    partial class Failfood
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
            this.cbfoodgroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbfoodname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfailID = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvFailfood = new System.Windows.Forms.DataGridView();
            this.lblFoodID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailfood)).BeginInit();
            this.SuspendLayout();
            // 
            // cbfoodgroup
            // 
            this.cbfoodgroup.FormattingEnabled = true;
            this.cbfoodgroup.Location = new System.Drawing.Point(109, 6);
            this.cbfoodgroup.Name = "cbfoodgroup";
            this.cbfoodgroup.Size = new System.Drawing.Size(121, 21);
            this.cbfoodgroup.TabIndex = 0;
            this.cbfoodgroup.SelectionChangeCommitted += new System.EventHandler(this.cbfoodgroup_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhóm thực phẩm:";
            // 
            // cbfoodname
            // 
            this.cbfoodname.FormattingEnabled = true;
            this.cbfoodname.Location = new System.Drawing.Point(109, 33);
            this.cbfoodname.Name = "cbfoodname";
            this.cbfoodname.Size = new System.Drawing.Size(121, 21);
            this.cbfoodname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thực phẩm:";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(79, 68);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(180, 20);
            this.dtFrom.TabIndex = 2;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(79, 94);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(180, 20);
            this.dtTo.TabIndex = 2;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(322, 34);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(71, 20);
            this.txtquantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng hỏng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Từ ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đến ngày:";
            // 
            // txtfailID
            // 
            this.txtfailID.Enabled = false;
            this.txtfailID.Location = new System.Drawing.Point(322, 6);
            this.txtfailID.Name = "txtfailID";
            this.txtfailID.Size = new System.Drawing.Size(71, 20);
            this.txtfailID.TabIndex = 3;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(408, 65);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnedit.Location = new System.Drawing.Point(408, 31);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btndelete.Location = new System.Drawing.Point(322, 65);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnadd.Location = new System.Drawing.Point(408, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearch.Location = new System.Drawing.Point(322, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvFailfood
            // 
            this.dgvFailfood.AllowUserToResizeColumns = false;
            this.dgvFailfood.AllowUserToResizeRows = false;
            this.dgvFailfood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFailfood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFailfood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFailfood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFailfood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFailfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFailfood.Location = new System.Drawing.Point(15, 122);
            this.dgvFailfood.Name = "dgvFailfood";
            this.dgvFailfood.ReadOnly = true;
            this.dgvFailfood.RowHeadersVisible = false;
            this.dgvFailfood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFailfood.Size = new System.Drawing.Size(466, 211);
            this.dgvFailfood.TabIndex = 21;
            this.dgvFailfood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFailfood_CellClick);
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Location = new System.Drawing.Point(34, 200);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(39, 13);
            this.lblFoodID.TabIndex = 1;
            this.lblFoodID.Text = "Mã ID:";
            // 
            // Failfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 345);
            this.Controls.Add(this.dgvFailfood);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtfailID);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFoodID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbfoodname);
            this.Controls.Add(this.cbfoodgroup);
            this.Name = "Failfood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực phẩm hỏng";
            this.Load += new System.EventHandler(this.Failfood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailfood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbfoodgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbfoodname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfailID;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvFailfood;
        private System.Windows.Forms.Label lblFoodID;
    }
}
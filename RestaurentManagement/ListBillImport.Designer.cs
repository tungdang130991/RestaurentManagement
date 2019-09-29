namespace RestaurentManagement
{
    partial class ListBillImport
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
            this.lblBillID = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Enabled = false;
            this.lblBillID.Location = new System.Drawing.Point(32, 76);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(0, 13);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Click += new System.EventHandler(this.lblBillID_Click);
            // 
            // btnadd
            // 
            this.btnadd.ForeColor = System.Drawing.Color.Red;
            this.btnadd.Location = new System.Drawing.Point(110, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 31);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Thêm mới";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            this.dgvbill.Location = new System.Drawing.Point(12, 65);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.ReadOnly = true;
            this.dgvbill.RowHeadersVisible = false;
            this.dgvbill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbill.Size = new System.Drawing.Size(553, 278);
            this.dgvbill.TabIndex = 20;
            this.dgvbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            this.dgvbill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellContentClick);
            // 
            // btnedit
            // 
            this.btnedit.ForeColor = System.Drawing.Color.Red;
            this.btnedit.Location = new System.Drawing.Point(246, 12);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(116, 31);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(379, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(101, 31);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh sách những hóa đơn nhập trong ngày:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListBillImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvbill);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblBillID);
            this.Name = "ListBillImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn nhập";
            this.Load += new System.EventHandler(this.ListBillImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
    }
}
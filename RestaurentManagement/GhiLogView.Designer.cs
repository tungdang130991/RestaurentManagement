namespace RestaurentManagement
{
    partial class GhiLogView
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
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(356, 12);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(253, 20);
            this.dtTo.TabIndex = 36;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(55, 12);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(233, 20);
            this.dtFrom.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Đến ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Từ ngày:";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(452, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Người dùng:";
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(74, 49);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(132, 21);
            this.cbUser.TabIndex = 39;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Datetime,
            this.Action});
            this.dgvBill.Location = new System.Drawing.Point(3, 76);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(606, 326);
            this.dgvBill.TabIndex = 41;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "Người dùng";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Datetime
            // 
            this.Datetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Datetime.DataPropertyName = "Datetime";
            this.Datetime.HeaderText = "Ngày giờ";
            this.Datetime.Name = "Datetime";
            this.Datetime.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Thao tác";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 402;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Thao tác:";
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(283, 49);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(147, 20);
            this.txtAction.TabIndex = 43;
            // 
            // GhiLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(618, 414);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Name = "GhiLogView";
            this.Text = "Hoạt Động Người Dùng";
            this.Load += new System.EventHandler(this.GhiLogView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAction;
    }
}
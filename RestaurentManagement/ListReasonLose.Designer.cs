namespace RestaurentManagement
{
    partial class ListReasonLose
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtdatetime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblreason = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số bàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày giờ:";
            // 
            // txtnumber
            // 
            this.txtnumber.Enabled = false;
            this.txtnumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtnumber.Location = new System.Drawing.Point(62, 38);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 20);
            this.txtnumber.TabIndex = 2;
            // 
            // txtdatetime
            // 
            this.txtdatetime.Enabled = false;
            this.txtdatetime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdatetime.Location = new System.Drawing.Point(62, 65);
            this.txtdatetime.Name = "txtdatetime";
            this.txtdatetime.Size = new System.Drawing.Size(100, 20);
            this.txtdatetime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lý do:";
            // 
            // lblreason
            // 
            this.lblreason.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblreason.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblreason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreason.Location = new System.Drawing.Point(210, 41);
            this.lblreason.Name = "lblreason";
            this.lblreason.Size = new System.Drawing.Size(428, 44);
            this.lblreason.TabIndex = 4;
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
            this.TableNumber,
            this.DateTime,
            this.Reason});
            this.dgvBill.Location = new System.Drawing.Point(7, 97);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(631, 266);
            this.dgvBill.TabIndex = 28;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // TableNumber
            // 
            this.TableNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TableNumber.DataPropertyName = "TableNumber";
            this.TableNumber.HeaderText = "Số bàn";
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.ReadOnly = true;
            this.TableNumber.Width = 70;
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "Ngày giờ";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Width = 120;
            // 
            // Reason
            // 
            this.Reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Lý do hủy";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Width = 435;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(510, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(311, 12);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(180, 20);
            this.dtTo.TabIndex = 31;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(62, 12);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(180, 20);
            this.dtFrom.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Đến ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Từ ngày:";
            // 
            // ListReasonLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 369);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblreason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdatetime);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListReasonLose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Lý Do Hủy Bàn";
            this.Load += new System.EventHandler(this.ListReasonLose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtdatetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblreason;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
    }
}
namespace RestaurentManagement
{
    partial class BillManagement
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dgvdish = new System.Windows.Forms.DataGridView();
            this.lblBillID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdish)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(517, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(313, 9);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(180, 20);
            this.dtTo.TabIndex = 5;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(64, 11);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(180, 20);
            this.dtFrom.TabIndex = 6;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đến ngày:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Từ ngày:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.ID,
            this.TableNumber,
            this.DateEnd,
            this.UserName,
            this.Total,
            this.Sale,
            this.TotalEnd});
            this.dgvBill.Location = new System.Drawing.Point(12, 39);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(633, 281);
            this.dgvBill.TabIndex = 22;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // dgvdish
            // 
            this.dgvdish.AllowUserToResizeColumns = false;
            this.dgvdish.AllowUserToResizeRows = false;
            this.dgvdish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdish.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvdish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdish.Location = new System.Drawing.Point(12, 360);
            this.dgvdish.Name = "dgvdish";
            this.dgvdish.RowHeadersVisible = false;
            this.dgvdish.Size = new System.Drawing.Size(633, 214);
            this.dgvdish.TabIndex = 22;
            // 
            // lblBillID
            // 
            this.lblBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillID.ForeColor = System.Drawing.Color.Red;
            this.lblBillID.Location = new System.Drawing.Point(116, 326);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(92, 23);
            this.lblBillID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hóa đơn số:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Xem hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(208, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ngày thanh toán:";
            // 
            // lbldate
            // 
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Red;
            this.lbldate.Location = new System.Drawing.Point(331, 331);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(140, 22);
            this.lbldate.TabIndex = 26;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // TableNumber
            // 
            this.TableNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TableNumber.DataPropertyName = "TableNumber";
            this.TableNumber.HeaderText = "Số Bàn";
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.ReadOnly = true;
            this.TableNumber.Width = 90;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "Ngày giờ";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Người tạo";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Tổng hóa đơn";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Sale
            // 
            this.Sale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sale.DataPropertyName = "Sale";
            this.Sale.HeaderText = "Triết khấu";
            this.Sale.Name = "Sale";
            this.Sale.ReadOnly = true;
            this.Sale.Width = 90;
            // 
            // TotalEnd
            // 
            this.TotalEnd.DataPropertyName = "TotalEnd";
            this.TotalEnd.HeaderText = "Tổng thanh toán";
            this.TotalEnd.Name = "TotalEnd";
            this.TotalEnd.ReadOnly = true;
            // 
            // BillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBillID);
            this.Controls.Add(this.dgvdish);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Name = "BillManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn xuất";
            this.Load += new System.EventHandler(this.BillManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridView dgvdish;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEnd;
    }
}
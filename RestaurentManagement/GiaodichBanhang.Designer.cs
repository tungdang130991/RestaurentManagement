namespace RestaurentManagement
{
    partial class GiaodichBanhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaodichBanhang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbancokhach = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnocustomer = new System.Windows.Forms.Label();
            this.btnaddbill = new System.Windows.Forms.Button();
            this.lbltable = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBillDish = new System.Windows.Forms.DataGridView();
            this.dgvBillAllDay = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillAllDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sơ đồ bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // lblbancokhach
            // 
            this.lblbancokhach.AutoSize = true;
            this.lblbancokhach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbancokhach.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblbancokhach.Location = new System.Drawing.Point(169, 17);
            this.lblbancokhach.Name = "lblbancokhach";
            this.lblbancokhach.Size = new System.Drawing.Size(14, 15);
            this.lblbancokhach.TabIndex = 0;
            this.lblbancokhach.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(189, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bàn chưa có khách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(88, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bàn có khách:";
            // 
            // lblnocustomer
            // 
            this.lblnocustomer.AutoSize = true;
            this.lblnocustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnocustomer.ForeColor = System.Drawing.Color.Red;
            this.lblnocustomer.Location = new System.Drawing.Point(302, 17);
            this.lblnocustomer.Name = "lblnocustomer";
            this.lblnocustomer.Size = new System.Drawing.Size(14, 15);
            this.lblnocustomer.TabIndex = 2;
            this.lblnocustomer.Text = "0";
            // 
            // btnaddbill
            // 
            this.btnaddbill.BackColor = System.Drawing.Color.Salmon;
            this.btnaddbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbill.Location = new System.Drawing.Point(350, 6);
            this.btnaddbill.Name = "btnaddbill";
            this.btnaddbill.Size = new System.Drawing.Size(109, 30);
            this.btnaddbill.TabIndex = 3;
            this.btnaddbill.Text = "Tạo Hóa Đơn";
            this.btnaddbill.UseVisualStyleBackColor = false;
            this.btnaddbill.Click += new System.EventHandler(this.btnaddbill_Click);
            // 
            // lbltable
            // 
            this.lbltable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltable.ForeColor = System.Drawing.Color.Blue;
            this.lbltable.Location = new System.Drawing.Point(646, 13);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(127, 35);
            this.lbltable.TabIndex = 0;
            this.lbltable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableName
            // 
            this.lblTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.ForeColor = System.Drawing.Color.Red;
            this.lblTableName.Location = new System.Drawing.Point(779, 32);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(383, 17);
            this.lblTableName.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(779, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(383, 17);
            this.lblStatus.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(953, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hủy Bàn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(851, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Chuyển Bàn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thêm Món";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBillDish
            // 
            this.dgvBillDish.AllowUserToResizeColumns = false;
            this.dgvBillDish.AllowUserToResizeRows = false;
            this.dgvBillDish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillDish.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBillDish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBillDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDish.Location = new System.Drawing.Point(641, 85);
            this.dgvBillDish.Name = "dgvBillDish";
            this.dgvBillDish.ReadOnly = true;
            this.dgvBillDish.RowHeadersVisible = false;
            this.dgvBillDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillDish.Size = new System.Drawing.Size(527, 253);
            this.dgvBillDish.TabIndex = 5;
            // 
            // dgvBillAllDay
            // 
            this.dgvBillAllDay.AllowUserToResizeColumns = false;
            this.dgvBillAllDay.AllowUserToResizeRows = false;
            this.dgvBillAllDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillAllDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillAllDay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBillAllDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBillAllDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillAllDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TableNumber,
            this.DateEnd,
            this.UserName,
            this.Total,
            this.Sale,
            this.TotalEnd});
            this.dgvBillAllDay.Location = new System.Drawing.Point(641, 357);
            this.dgvBillAllDay.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvBillAllDay.Name = "dgvBillAllDay";
            this.dgvBillAllDay.ReadOnly = true;
            this.dgvBillAllDay.RowHeadersVisible = false;
            this.dgvBillAllDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillAllDay.Size = new System.Drawing.Size(527, 261);
            this.dgvBillAllDay.TabIndex = 5;
            this.dgvBillAllDay.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBillAllDay_CellMouseDown);
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
            // TableNumber
            // 
            this.TableNumber.DataPropertyName = "TableNumber";
            this.TableNumber.HeaderText = "Số bàn";
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.ReadOnly = true;
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
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Người tạo";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Tổng";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Sale
            // 
            this.Sale.DataPropertyName = "Sale";
            this.Sale.HeaderText = "Triết khấu";
            this.Sale.Name = "Sale";
            this.Sale.ReadOnly = true;
            // 
            // TotalEnd
            // 
            this.TotalEnd.DataPropertyName = "TotalEnd";
            this.TotalEnd.HeaderText = "Thanh toán";
            this.TotalEnd.Name = "TotalEnd";
            this.TotalEnd.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(638, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Danh sách phiếu thanh toán trong ngày";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Salmon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(549, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Salmon;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(463, 6);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(81, 30);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Đặt bàn";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1065, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Ghép bàn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GiaodichBanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 636);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvBillAllDay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvBillDish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltable);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnaddbill);
            this.Controls.Add(this.lblnocustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblbancokhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GiaodichBanhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao dịch bán hàng";
            this.Load += new System.EventHandler(this.GiaodichBanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillAllDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblbancokhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnocustomer;
        private System.Windows.Forms.Button btnaddbill;
        private System.Windows.Forms.Label lbltable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBillDish;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvBillAllDay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEnd;
        private System.Windows.Forms.Button button5;

    }
}
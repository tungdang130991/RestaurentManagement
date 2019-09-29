namespace RestaurentManagement
{
    partial class DayReport
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
            this.dgvFloor = new System.Windows.Forms.DataGridView();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFloor
            // 
            this.dgvFloor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFloor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFloor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFloor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TT,
            this.DishID,
            this.DishName,
            this.Pack,
            this.Price,
            this.Quantity,
            this.Total});
            this.dgvFloor.Location = new System.Drawing.Point(12, 43);
            this.dgvFloor.Name = "dgvFloor";
            this.dgvFloor.ReadOnly = true;
            this.dgvFloor.RowHeadersVisible = false;
            this.dgvFloor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFloor.Size = new System.Drawing.Size(641, 304);
            this.dgvFloor.TabIndex = 12;
            // 
            // TT
            // 
            this.TT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TT.DataPropertyName = "TT";
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            this.TT.Width = 30;
            // 
            // DishID
            // 
            this.DishID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DishID.DataPropertyName = "DishID";
            this.DishID.HeaderText = "Mã";
            this.DishID.Name = "DishID";
            this.DishID.ReadOnly = true;
            this.DishID.Width = 30;
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DishName.DataPropertyName = "DishName";
            this.DishName.HeaderText = "Tên món ăn";
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            this.DishName.Width = 200;
            // 
            // Pack
            // 
            this.Pack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pack.DataPropertyName = "Pack";
            this.Pack.HeaderText = "Đơn vị";
            this.Pack.Name = "Pack";
            this.Pack.ReadOnly = true;
            this.Pack.Width = 70;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 86;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 120;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Tổng giá";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(317, 7);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(180, 20);
            this.dtTo.TabIndex = 24;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(68, 9);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(180, 20);
            this.dtFrom.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Đến ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Từ ngày:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(521, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 390);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFloor);
            this.Name = "DayReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu các món ";
            this.Load += new System.EventHandler(this.DayReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;

    }
}
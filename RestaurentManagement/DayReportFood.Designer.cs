namespace RestaurentManagement
{
    partial class DayReportFood
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvFloor = new System.Windows.Forms.DataGridView();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(548, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvFloor
            // 
            this.dgvFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFloor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFloor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFloor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFloor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TT,
            this.FoodID,
            this.FoodName,
            this.Pack,
            this.QuantityFirst,
            this.QuantityEnd,
            this.export,
            this.import});
            this.dgvFloor.Location = new System.Drawing.Point(12, 44);
            this.dgvFloor.Name = "dgvFloor";
            this.dgvFloor.ReadOnly = true;
            this.dgvFloor.RowHeadersVisible = false;
            this.dgvFloor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFloor.Size = new System.Drawing.Size(641, 324);
            this.dgvFloor.TabIndex = 14;
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
            // FoodID
            // 
            this.FoodID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoodID.DataPropertyName = "FoodID";
            this.FoodID.HeaderText = "Mã";
            this.FoodID.Name = "FoodID";
            this.FoodID.ReadOnly = true;
            this.FoodID.Width = 30;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Tên thực phẩm";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            this.FoodName.Width = 150;
            // 
            // Pack
            // 
            this.Pack.DataPropertyName = "Pack";
            this.Pack.HeaderText = "Đơn vị";
            this.Pack.Name = "Pack";
            this.Pack.ReadOnly = true;
            // 
            // QuantityFirst
            // 
            this.QuantityFirst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QuantityFirst.DataPropertyName = "QuantityFirst";
            this.QuantityFirst.HeaderText = "Lượng tồn đầu";
            this.QuantityFirst.Name = "QuantityFirst";
            this.QuantityFirst.ReadOnly = true;
            this.QuantityFirst.Width = 110;
            // 
            // QuantityEnd
            // 
            this.QuantityEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QuantityEnd.DataPropertyName = "QuantityEnd";
            this.QuantityEnd.HeaderText = "Lượng tồn cuối";
            this.QuantityEnd.Name = "QuantityEnd";
            this.QuantityEnd.ReadOnly = true;
            this.QuantityEnd.Width = 110;
            // 
            // export
            // 
            this.export.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.export.DataPropertyName = "export";
            this.export.HeaderText = "Xuất ra";
            this.export.Name = "export";
            this.export.ReadOnly = true;
            this.export.Width = 80;
            // 
            // import
            // 
            this.import.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.import.DataPropertyName = "import";
            this.import.HeaderText = "Nhập vào";
            this.import.Name = "import";
            this.import.ReadOnly = true;
            this.import.Width = 80;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(316, 7);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(180, 20);
            this.dtTo.TabIndex = 19;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(67, 9);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(180, 20);
            this.dtFrom.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đến ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Từ ngày:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(520, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DayReportFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 418);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFloor);
            this.Name = "DayReportFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thực phẩm được sử dụng";
            this.Load += new System.EventHandler(this.DayReportFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvFloor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn export;
        private System.Windows.Forms.DataGridViewTextBoxColumn import;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
    }
}
namespace RestaurentManagement
{
    partial class Floor
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
            this.dgvFloor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtfloor = new System.Windows.Forms.TextBox();
            this.lblfloor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfloorid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(284, 107);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnedit.Location = new System.Drawing.Point(284, 79);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btndelete.Location = new System.Drawing.Point(284, 50);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnadd.Location = new System.Drawing.Point(284, 20);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvFloor
            // 
            this.dgvFloor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFloor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFloor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFloor.Location = new System.Drawing.Point(12, 136);
            this.dgvFloor.Name = "dgvFloor";
            this.dgvFloor.ReadOnly = true;
            this.dgvFloor.RowHeadersVisible = false;
            this.dgvFloor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFloor.Size = new System.Drawing.Size(347, 179);
            this.dgvFloor.TabIndex = 11;
            this.dgvFloor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFloor_CellClick);
            this.dgvFloor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFloor_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mô tả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên tầng:";
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(90, 77);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(164, 53);
            this.txtdes.TabIndex = 2;
            // 
            // txtfloor
            // 
            this.txtfloor.Location = new System.Drawing.Point(91, 51);
            this.txtfloor.Name = "txtfloor";
            this.txtfloor.Size = new System.Drawing.Size(164, 20);
            this.txtfloor.TabIndex = 1;
            // 
            // lblfloor
            // 
            this.lblfloor.AutoSize = true;
            this.lblfloor.Location = new System.Drawing.Point(16, 117);
            this.lblfloor.Name = "lblfloor";
            this.lblfloor.Size = new System.Drawing.Size(0, 13);
            this.lblfloor.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã tầng:";
            // 
            // txtfloorid
            // 
            this.txtfloorid.Enabled = false;
            this.txtfloorid.Location = new System.Drawing.Point(92, 25);
            this.txtfloorid.Name = "txtfloorid";
            this.txtfloorid.Size = new System.Drawing.Size(162, 20);
            this.txtfloorid.TabIndex = 17;
            // 
            // Floor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 318);
            this.Controls.Add(this.txtfloorid);
            this.Controls.Add(this.lblfloor);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtfloor);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Floor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tầng";
            this.Load += new System.EventHandler(this.Floor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txtfloor;
        private System.Windows.Forms.Label lblfloor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfloorid;
    }
}
namespace RestaurentManagement
{
    partial class PackUnit
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
            this.dgvPacks = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtFoodDescrible = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacks
            // 
            this.dgvPacks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPacks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacks.Location = new System.Drawing.Point(15, 128);
            this.dgvPacks.Name = "dgvPacks";
            this.dgvPacks.ReadOnly = true;
            this.dgvPacks.RowHeadersVisible = false;
            this.dgvPacks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacks.Size = new System.Drawing.Size(394, 150);
            this.dgvPacks.TabIndex = 42;
            this.dgvPacks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupFood_CellClick);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(334, 38);
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
            this.btnedit.Location = new System.Drawing.Point(334, 10);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btndelete.Location = new System.Drawing.Point(253, 39);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnadd.Location = new System.Drawing.Point(253, 9);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtFoodDescrible
            // 
            this.txtFoodDescrible.Location = new System.Drawing.Point(108, 65);
            this.txtFoodDescrible.Multiline = true;
            this.txtFoodDescrible.Name = "txtFoodDescrible";
            this.txtFoodDescrible.Size = new System.Drawing.Size(139, 57);
            this.txtFoodDescrible.TabIndex = 2;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(108, 39);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(139, 20);
            this.txtFoodName.TabIndex = 1;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Enabled = false;
            this.txtFoodID.Location = new System.Drawing.Point(108, 12);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(139, 20);
            this.txtFoodID.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã :";
            // 
            // PackUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 287);
            this.Controls.Add(this.dgvPacks);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtFoodDescrible);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PackUnit";
            this.Text = "Đơn vị tính";
            this.Load += new System.EventHandler(this.PackUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacks;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtFoodDescrible;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
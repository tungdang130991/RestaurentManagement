namespace RestaurentManagement
{
    partial class GroupDish
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDishID = new System.Windows.Forms.TextBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.txtDishDescrible = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvGroupDish = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupDish)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả:";
            // 
            // txtDishID
            // 
            this.txtDishID.Enabled = false;
            this.txtDishID.Location = new System.Drawing.Point(118, 17);
            this.txtDishID.Name = "txtDishID";
            this.txtDishID.Size = new System.Drawing.Size(139, 20);
            this.txtDishID.TabIndex = 15;
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(118, 44);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(139, 20);
            this.txtDishName.TabIndex = 1;
            // 
            // txtDishDescrible
            // 
            this.txtDishDescrible.Location = new System.Drawing.Point(118, 70);
            this.txtDishDescrible.Multiline = true;
            this.txtDishDescrible.Name = "txtDishDescrible";
            this.txtDishDescrible.Size = new System.Drawing.Size(139, 57);
            this.txtDishDescrible.TabIndex = 2;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(344, 43);
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
            this.btnedit.Location = new System.Drawing.Point(344, 15);
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
            this.btndelete.Location = new System.Drawing.Point(263, 44);
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
            this.btnadd.Location = new System.Drawing.Point(263, 14);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvGroupDish
            // 
            this.dgvGroupDish.AllowUserToResizeColumns = false;
            this.dgvGroupDish.AllowUserToResizeRows = false;
            this.dgvGroupDish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroupDish.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGroupDish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGroupDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupDish.Location = new System.Drawing.Point(19, 133);
            this.dgvGroupDish.Name = "dgvGroupDish";
            this.dgvGroupDish.ReadOnly = true;
            this.dgvGroupDish.RowHeadersVisible = false;
            this.dgvGroupDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupDish.Size = new System.Drawing.Size(400, 150);
            this.dgvGroupDish.TabIndex = 20;
            this.dgvGroupDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupDish_CellClick);
            // 
            // GroupDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 295);
            this.Controls.Add(this.dgvGroupDish);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtDishDescrible);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.txtDishID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GroupDish";
            this.Text = "Nhóm món ăn";
            this.Load += new System.EventHandler(this.GroupDish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDishID;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.TextBox txtDishDescrible;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvGroupDish;
    }
}
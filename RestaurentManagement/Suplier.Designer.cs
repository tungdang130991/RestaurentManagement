namespace RestaurentManagement
{
    partial class Suplier
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuplierName = new System.Windows.Forms.TextBox();
            this.txtSuplierID = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mô tả:";
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(453, 50);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(164, 73);
            this.txtdes.TabIndex = 24;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(313, 99);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 25);
            this.btnexit.TabIndex = 29;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnedit.Location = new System.Drawing.Point(313, 43);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 25);
            this.btnedit.TabIndex = 26;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btndelete.Location = new System.Drawing.Point(313, 72);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 25);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnadd.Location = new System.Drawing.Point(313, 15);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 25);
            this.btnadd.TabIndex = 25;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToResizeColumns = false;
            this.dgvSupplier.AllowUserToResizeRows = false;
            this.dgvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(18, 142);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.Size = new System.Drawing.Size(601, 176);
            this.dgvSupplier.TabIndex = 34;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Mã nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Email:";
            // 
            // txtSuplierName
            // 
            this.txtSuplierName.Location = new System.Drawing.Point(143, 46);
            this.txtSuplierName.Name = "txtSuplierName";
            this.txtSuplierName.Size = new System.Drawing.Size(164, 20);
            this.txtSuplierName.TabIndex = 20;
            // 
            // txtSuplierID
            // 
            this.txtSuplierID.Enabled = false;
            this.txtSuplierID.Location = new System.Drawing.Point(143, 16);
            this.txtSuplierID.Name = "txtSuplierID";
            this.txtSuplierID.Size = new System.Drawing.Size(164, 20);
            this.txtSuplierID.TabIndex = 35;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(453, 18);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(164, 20);
            this.txtemail.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(143, 72);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(164, 20);
            this.txtAddress.TabIndex = 20;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(143, 99);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(164, 20);
            this.txtphone.TabIndex = 20;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // Suplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSuplierName);
            this.Controls.Add(this.txtSuplierID);
            this.Controls.Add(this.txtemail);
            this.Name = "Suplier";
            this.Text = "Đối tác";
            this.Load += new System.EventHandler(this.Suplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuplierName;
        private System.Windows.Forms.TextBox txtSuplierID;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtphone;
    }
}
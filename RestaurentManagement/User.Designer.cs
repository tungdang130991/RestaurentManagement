namespace RestaurentManagement
{
    partial class User
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
            this.txtaccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassagain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lbliduser = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtaccount
            // 
            this.txtaccount.Location = new System.Drawing.Point(109, 10);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(100, 20);
            this.txtaccount.TabIndex = 0;
  
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản:";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(109, 36);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtpassagain
            // 
            this.txtpassagain.Location = new System.Drawing.Point(109, 62);
            this.txtpassagain.Name = "txtpassagain";
            this.txtpassagain.Size = new System.Drawing.Size(100, 20);
            this.txtpassagain.TabIndex = 2;
            this.txtpassagain.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(306, 7);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(100, 20);
            this.txtfullname.TabIndex = 3;
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(306, 32);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(100, 20);
            this.txtposition.TabIndex = 4;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(306, 84);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 6;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên người dùng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vị trí:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Điện thoại:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(306, 58);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ:";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(412, 65);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btndelete.Location = new System.Drawing.Point(412, 36);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnadd.Location = new System.Drawing.Point(412, 6);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(6, 110);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(481, 179);
            this.dgvUser.TabIndex = 12;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // lbliduser
            // 
            this.lbliduser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbliduser.Location = new System.Drawing.Point(215, 36);
            this.lbliduser.Name = "lbliduser";
            this.lbliduser.Size = new System.Drawing.Size(25, 16);
            this.lbliduser.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Là quản lý";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 299);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbliduser);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtpassagain);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtaccount);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassagain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lbliduser;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
namespace RestaurentManagement
{
    partial class ChangePassWord
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
            this.txtpassolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassnew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassagain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // txtpassolder
            // 
            this.txtpassolder.Location = new System.Drawing.Point(110, 10);
            this.txtpassolder.Name = "txtpassolder";
            this.txtpassolder.Size = new System.Drawing.Size(100, 20);
            this.txtpassolder.TabIndex = 1;
            this.txtpassolder.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txtpassnew
            // 
            this.txtpassnew.Location = new System.Drawing.Point(110, 36);
            this.txtpassnew.Name = "txtpassnew";
            this.txtpassnew.Size = new System.Drawing.Size(100, 20);
            this.txtpassnew.TabIndex = 2;
            this.txtpassnew.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // txtpassagain
            // 
            this.txtpassagain.Location = new System.Drawing.Point(110, 62);
            this.txtpassagain.Name = "txtpassagain";
            this.txtpassagain.Size = new System.Drawing.Size(100, 20);
            this.txtpassagain.TabIndex = 3;
            this.txtpassagain.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thay Đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(229, 136);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpassagain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassnew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpassolder);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassnew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassagain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
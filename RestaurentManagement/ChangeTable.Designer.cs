namespace RestaurentManagement
{
    partial class ChangeTable
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
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.cbtablenumber = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Bàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chuyển tới bàn:";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumber.ForeColor = System.Drawing.Color.Aqua;
            this.lblTableNumber.Location = new System.Drawing.Point(92, 9);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(121, 19);
            this.lblTableNumber.TabIndex = 0;
            // 
            // cbtablenumber
            // 
            this.cbtablenumber.FormattingEnabled = true;
            this.cbtablenumber.Location = new System.Drawing.Point(96, 40);
            this.cbtablenumber.Name = "cbtablenumber";
            this.cbtablenumber.Size = new System.Drawing.Size(121, 21);
            this.cbtablenumber.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chuyển bàn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 107);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbtablenumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.label1);
            this.Name = "ChangeTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển bàn";
            this.Load += new System.EventHandler(this.ChangeTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ComboBox cbtablenumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
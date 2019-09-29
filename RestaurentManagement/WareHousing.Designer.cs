namespace RestaurentManagement
{
    partial class WareHousing
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
            this.cbfoodgroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvfood = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhóm thực phẩm:";
            // 
            // cbfoodgroup
            // 
            this.cbfoodgroup.FormattingEnabled = true;
            this.cbfoodgroup.Location = new System.Drawing.Point(107, 12);
            this.cbfoodgroup.Name = "cbfoodgroup";
            this.cbfoodgroup.Size = new System.Drawing.Size(121, 21);
            this.cbfoodgroup.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thực phẩm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(437, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(516, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvfood
            // 
            this.dgvfood.AllowUserToResizeColumns = false;
            this.dgvfood.AllowUserToResizeRows = false;
            this.dgvfood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvfood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvfood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfood.Location = new System.Drawing.Point(12, 39);
            this.dgvfood.Name = "dgvfood";
            this.dgvfood.ReadOnly = true;
            this.dgvfood.RowHeadersVisible = false;
            this.dgvfood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfood.Size = new System.Drawing.Size(556, 292);
            this.dgvfood.TabIndex = 22;
            // 
            // WareHousing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 343);
            this.Controls.Add(this.dgvfood);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbfoodgroup);
            this.Name = "WareHousing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho thực phẩm";
            this.Load += new System.EventHandler(this.WareHousing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbfoodgroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvfood;
    }
}
namespace RestaurentManagement
{
    partial class DishFoodView
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
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDishGroup = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtDishName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbill
            // 
            this.dgvbill.AllowUserToResizeColumns = false;
            this.dgvbill.AllowUserToResizeRows = false;
            this.dgvbill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvbill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Location = new System.Drawing.Point(12, 51);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.RowHeadersVisible = false;
            this.dgvbill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbill.Size = new System.Drawing.Size(598, 338);
            this.dgvbill.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhóm món ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Món ăn:";
            // 
            // cbDishGroup
            // 
            this.cbDishGroup.FormattingEnabled = true;
            this.cbDishGroup.Location = new System.Drawing.Point(116, 12);
            this.cbDishGroup.Name = "cbDishGroup";
            this.cbDishGroup.Size = new System.Drawing.Size(121, 21);
            this.cbDishGroup.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Red;
            this.btnsearch.Location = new System.Drawing.Point(431, 10);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(179, 24);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Tìm kiếm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(313, 13);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(105, 20);
            this.txtDishName.TabIndex = 2;
            this.txtDishName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDishName_KeyPress);
            // 
            // DishFoodView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 401);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDishGroup);
            this.Controls.Add(this.dgvbill);
            this.Name = "DishFoodView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thực phẩm dùng cho món ăn";
            this.Load += new System.EventHandler(this.DishFoodView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDishGroup;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtDishName;
    }
}
namespace RestaurentManagement
{
    partial class PrintPreview
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.AutoScroll = true;
            this.reportViewer2.AutoSize = true;
            this.reportViewer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = null;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "RestaurentManagement.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(570, 548);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.PrintPreview_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "In Nhanh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrintPreview
            // 
            this.ClientSize = new System.Drawing.Size(570, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer2);
            this.Name = "PrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button button1;

    }
}
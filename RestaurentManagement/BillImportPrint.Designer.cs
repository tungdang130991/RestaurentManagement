namespace RestaurentManagement
{
    partial class BillImportPrint
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RES_Select_BillImportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new RestaurentManagement.DataSet1();
            this.RES_Select_BillImportFoods1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RES_Select_BillImportFoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RES_Select_BillImportTableAdapter = new RestaurentManagement.DataSet1TableAdapters.RES_Select_BillImportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RES_Select_BillImportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RES_Select_BillImportFoods1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RES_Select_BillImportFoodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RES_Select_BillImportBindingSource
            // 
            this.RES_Select_BillImportBindingSource.DataMember = "RES_Select_BillImport";
            this.RES_Select_BillImportBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RES_Select_BillImportFoods1BindingSource
            // 
            this.RES_Select_BillImportFoods1BindingSource.DataMember = "RES_Select_BillImportFoods1";
            this.RES_Select_BillImportFoods1BindingSource.DataSource = this.DataSet1;
            // 
            // RES_Select_BillImportFoodsBindingSource
            // 
            this.RES_Select_BillImportFoodsBindingSource.DataMember = "RES_Select_BillImportFoods";
            this.RES_Select_BillImportFoodsBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.RES_Select_BillImportBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.RES_Select_BillImportFoods1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RestaurentManagement.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(525, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // RES_Select_BillImportTableAdapter
            // 
            this.RES_Select_BillImportTableAdapter.ClearBeforeFill = true;
            // 
            // BillImportPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 399);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BillImportPrint";
            this.Text = "In hóa đơn nhập";
            this.Load += new System.EventHandler(this.BillImportPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RES_Select_BillImportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RES_Select_BillImportFoodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RES_Select_BillImportFoodsBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.RES_Select_BillImportTableAdapter RES_Select_BillImportTableAdapter;
        private System.Windows.Forms.BindingSource RES_Select_BillImportFoods1BindingSource;
        private System.Windows.Forms.BindingSource RES_Select_BillImportBindingSource;
    }
}
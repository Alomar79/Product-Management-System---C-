namespace Products_Management.RPT
{
    partial class FRM_rpt_allCategories
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_allCategories = new Products_Management.RPT.DS_allCategories();
            this.sp_get_all_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_get_all_categoriesTableAdapter = new Products_Management.RPT.DS_allCategoriesTableAdapters.sp_get_all_categoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_allCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_get_all_categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_get_all_categoriesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Products_Management.RPT.rpt_allCategories.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_allCategories
            // 
            this.DS_allCategories.DataSetName = "DS_allCategories";
            this.DS_allCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_get_all_categoriesBindingSource
            // 
            this.sp_get_all_categoriesBindingSource.DataMember = "sp_get_all_categories";
            this.sp_get_all_categoriesBindingSource.DataSource = this.DS_allCategories;
            // 
            // sp_get_all_categoriesTableAdapter
            // 
            this.sp_get_all_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_rpt_allCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_rpt_allCategories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير بالأصناف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_rpt_allCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_allCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_get_all_categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sp_get_all_categoriesBindingSource;
        public DS_allCategories DS_allCategories;
        public DS_allCategoriesTableAdapters.sp_get_all_categoriesTableAdapter sp_get_all_categoriesTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
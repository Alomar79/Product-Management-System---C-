namespace Products_Management.RPT
{
    partial class FRM_Curr_Category
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
            this.DS_currCategory = new Products_Management.RPT.DS_currCategory();
            this.sp_rpt_single_categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_rpt_single_categoryTableAdapter = new Products_Management.RPT.DS_currCategoryTableAdapters.sp_rpt_single_categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_currCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_single_categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_rpt_single_categoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Products_Management.RPT.rpt_currCategory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_currCategory
            // 
            this.DS_currCategory.DataSetName = "DS_currCategory";
            this.DS_currCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_rpt_single_categoryBindingSource
            // 
            this.sp_rpt_single_categoryBindingSource.DataMember = "sp_rpt_single_category";
            this.sp_rpt_single_categoryBindingSource.DataSource = this.DS_currCategory;
            // 
            // sp_rpt_single_categoryTableAdapter
            // 
            this.sp_rpt_single_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Curr_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_Curr_Category";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير بالصنف الحالي";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Curr_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_currCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_single_categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_rpt_single_categoryBindingSource;
        public DS_currCategory DS_currCategory;
        public DS_currCategoryTableAdapters.sp_rpt_single_categoryTableAdapter sp_rpt_single_categoryTableAdapter;
    }
}
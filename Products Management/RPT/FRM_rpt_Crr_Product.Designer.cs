namespace Products_Management.RPT
{
    partial class FRM_rpt_Crr_Product
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_rpt_Curr_ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Curr_prod_DS = new Products_Management.RPT.Curr_prod_DS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_rpt_Curr_ProductTableAdapter = new Products_Management.RPT.Curr_prod_DSTableAdapters.sp_rpt_Curr_ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_Curr_ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Curr_prod_DS)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_rpt_Curr_ProductBindingSource
            // 
            this.sp_rpt_Curr_ProductBindingSource.DataMember = "sp_rpt_Curr_Product";
            this.sp_rpt_Curr_ProductBindingSource.DataSource = this.Curr_prod_DS;
            // 
            // Curr_prod_DS
            // 
            this.Curr_prod_DS.DataSetName = "Curr_prod_DS";
            this.Curr_prod_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sp_rpt_Curr_ProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Products_Management.RPT.rpt_CurrentProduct.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(769, 799);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_rpt_Curr_ProductTableAdapter
            // 
            this.sp_rpt_Curr_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_rpt_Crr_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 799);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_rpt_Crr_Product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير المنتج";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_rpt_Crr_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_Curr_ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Curr_prod_DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sp_rpt_Curr_ProductBindingSource;
        public Curr_prod_DSTableAdapters.sp_rpt_Curr_ProductTableAdapter sp_rpt_Curr_ProductTableAdapter;
        public Curr_prod_DS Curr_prod_DS;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
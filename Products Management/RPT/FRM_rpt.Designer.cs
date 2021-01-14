namespace Products_Management.RPT
{
    partial class FRM_rpt
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
            this.sp_rpt_Curr_ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Curr_prod_DS = new Products_Management.RPT.Curr_prod_DS();
            this.sp_rpt_Curr_ProductTableAdapter = new Products_Management.RPT.Curr_prod_DSTableAdapters.sp_rpt_Curr_ProductTableAdapter();
            this.AllProduct_DS = new Products_Management.RPT.AllProduct_DS();
            this.sp_rpt_All_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_rpt_All_ProductsTableAdapter = new Products_Management.RPT.AllProduct_DSTableAdapters.sp_rpt_All_ProductsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_Curr_ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Curr_prod_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllProduct_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_All_ProductsBindingSource)).BeginInit();
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
            // sp_rpt_Curr_ProductTableAdapter
            // 
            this.sp_rpt_Curr_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // AllProduct_DS
            // 
            this.AllProduct_DS.DataSetName = "AllProduct_DS";
            this.AllProduct_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_rpt_All_ProductsBindingSource
            // 
            this.sp_rpt_All_ProductsBindingSource.DataMember = "sp_rpt_All_Products";
            this.sp_rpt_All_ProductsBindingSource.DataSource = this.AllProduct_DS;
            // 
            // sp_rpt_All_ProductsTableAdapter
            // 
            this.sp_rpt_All_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_rpt_All_ProductsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Products_Management.RPT.rpt_AllProducts.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(904, 485);
            this.reportViewer1.TabIndex = 0;
            // 
            // FRM_rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 485);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_rpt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FRM_rpt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_rpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_Curr_ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Curr_prod_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllProduct_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_All_ProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Curr_prod_DS Curr_prod_DS;
        public Curr_prod_DSTableAdapters.sp_rpt_Curr_ProductTableAdapter sp_rpt_Curr_ProductTableAdapter;
        public System.Windows.Forms.BindingSource sp_rpt_Curr_ProductBindingSource;
        public System.Windows.Forms.BindingSource sp_rpt_All_ProductsBindingSource;
        public AllProduct_DS AllProduct_DS;
        public AllProduct_DSTableAdapters.sp_rpt_All_ProductsTableAdapter sp_rpt_All_ProductsTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
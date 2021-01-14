namespace Products_Management.RPT
{
    partial class FRM_rpt_orderDetails
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
            this.DS_orderDetails = new Products_Management.RPT.DS_orderDetails();
            this.sp_get_order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_get_order_detailsTableAdapter = new Products_Management.RPT.DS_orderDetailsTableAdapters.sp_get_order_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_orderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_get_order_detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_get_order_detailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Products_Management.RPT.rpt_orderDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_orderDetails
            // 
            this.DS_orderDetails.DataSetName = "DS_orderDetails";
            this.DS_orderDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_get_order_detailsBindingSource
            // 
            this.sp_get_order_detailsBindingSource.DataMember = "sp_get_order_details";
            this.sp_get_order_detailsBindingSource.DataSource = this.DS_orderDetails;
            // 
            // sp_get_order_detailsTableAdapter
            // 
            this.sp_get_order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_rpt_orderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_rpt_orderDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FRM_rpt_orderDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_rpt_orderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_orderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_get_order_detailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_get_order_detailsBindingSource;
        public DS_orderDetails DS_orderDetails;
        public DS_orderDetailsTableAdapters.sp_get_order_detailsTableAdapter sp_get_order_detailsTableAdapter;
    }
}
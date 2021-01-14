using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.IO;



namespace Products_Management.PL
{

    public partial class FRM_Categories : Form
    {
        private SqlConnection cn =new SqlConnection( @"Server=.\SQLEXPRESS; Database=Product_DB; Integrated Security=true ");
        private SqlDataAdapter DA;
        private DataTable dt = new DataTable();
        private BindingManagerBase bmb;
        private SqlCommandBuilder cmdB;
        public FRM_Categories()
        {
            InitializeComponent();

            DA = new SqlDataAdapter("select id_cat as 'معرف الصنف' , description_cat as 'الصنف' from categories", cn);
            DA.Fill(dt);
            Dgrid1.DataSource = dt;

            txtRef.DataBindings.Add("Text", dt, "معرف الصنف");
            txtDesc.DataBindings.Add("Text", dt, "الصنف");
            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position +1) +  " / " + bmb.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // اضافة حقول فارغة وتجهيز قيمة جديدة للمعرف تكون أكبر بواحد من آخر قيمة له 
            bmb.AddNew();
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtRef.Text = id.ToString();
            txtDesc.Focus();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdB = new SqlCommandBuilder(DA);
            DA.Update(dt);
            MessageBox.Show("Added Successfully !", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdB = new SqlCommandBuilder(DA);
            DA.Update(dt);
            MessageBox.Show("Deleted Successfully !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //btnAdd.Enabled = false;
            //btnNew.Enabled = true;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdB = new SqlCommandBuilder(DA);
            DA.Update(dt);
            MessageBox.Show("changed Successfully !", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btn_Report_Cats_Click(object sender, EventArgs e)
        {
            RPT.FRM_rpt_allCategories frmR = new RPT.FRM_rpt_allCategories();
            frmR.sp_get_all_categoriesTableAdapter.Fill(frmR.DS_allCategories.sp_get_all_categories);
            frmR.reportViewer1.RefreshReport();            
            frmR.ShowDialog();
        }

        private void btn_Rep_CurrntCat_Click(object sender, EventArgs e)
        {
            RPT.FRM_Curr_Category frmR = new RPT.FRM_Curr_Category();
            frmR.sp_rpt_single_categoryTableAdapter.Fill(frmR.DS_currCategory.sp_rpt_single_category, Convert.ToInt32(this.Dgrid1.CurrentRow.Cells[0].Value));
            frmR.reportViewer1.RefreshReport();
            frmR.Text = "تقرير بالصنف : " + this.Dgrid1.CurrentRow.Cells[1].Value.ToString();
            frmR.ShowDialog();
        }

        private void btnExportAll_pdf_Click(object sender, EventArgs e)
        {
            ////RPT.rpt_all_categories Myrpt = new RPT.rpt_all_categories();
            ////ExportOptions export = new ExportOptions();
            ////DiskFileDestinationOptions diskOption = new DiskFileDestinationOptions();
            ////PdfFormatOptions PdfFormat = new PdfFormatOptions();

            ////diskOption.DiskFileName = @"E:\Categories Report.pdf";
            ////export = Myrpt.ExportOptions;
            ////export.ExportDestinationType = ExportDestinationType.DiskFile;
            ////export.ExportDestinationOptions = diskOption;
            ////export.ExportFormatOptions = PdfFormat;
            ////export.ExportFormatType = ExportFormatType.PortableDocFormat;
            //////Myrpt.Refresh();
            ////Myrpt.Export();
            ////MessageBox.Show("Exporting Succeded", "Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_one_pdf_Click(object sender, EventArgs e)
        {
            ////RPT.rpt_single_categ Myrpt = new RPT.rpt_single_categ();
            ////Myrpt.SetParameterValue("@id_cat", Convert.ToInt32(txtRef.Text));
            ////ExportOptions export = new ExportOptions();
            ////DiskFileDestinationOptions diskOption = new DiskFileDestinationOptions();
            ////PdfFormatOptions PdfFormat = new PdfFormatOptions();

            ////diskOption.DiskFileName = @"E:\Current_Category Report.pdf";
            ////export = Myrpt.ExportOptions;
            ////export.ExportDestinationType = ExportDestinationType.DiskFile;
            ////export.ExportDestinationOptions = diskOption;
            ////export.ExportFormatOptions = PdfFormat;
            ////export.ExportFormatType = ExportFormatType.PortableDocFormat;
            //////Myrpt.Refresh();
            ////Myrpt.Export();
            ////MessageBox.Show("Exporting Succeded", "Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.PL
{
    public partial class FRM_Products : Form
    {
        public string id;
        private BL.CLS_Products prd = new BL.CLS_Products();

        private static FRM_Products frmM;

        private static void frmM_Formclosed(object sender, FormClosedEventArgs e)
        {
            frmM = null;
        }
        public static FRM_Products getMainForm
        {
            get
            {
                if (frmM == null)
                {
                    frmM = new FRM_Products();
                    frmM.FormClosed += new FormClosedEventHandler(frmM_Formclosed);
                }
                return frmM;
            }
        }

        
        public FRM_Products()
        {
            InitializeComponent();
            if (frmM == null)
                frmM = this;
            dataGridView1.DataSource = prd.get_all_products();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prd.SearchProduct(txtSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_Product frm = new FRM_Add_Product();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("did you sure to delete ?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                prd.Delete_Product(id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("تم إلغاء عملية الحذف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = prd.get_all_products();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FRM_Add_Product frm = new FRM_Add_Product();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDesc.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تحديث بيانات المنتج :  " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnAdd.Text = "تحديث";
            frm.state = "Update";
            frm.txtRef.ReadOnly = true;

            //pring product_image

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            byte[] pic = (byte[])prd.get_imgProduct(id).Rows[0][0];
            MemoryStream ms = new MemoryStream(pic);
            frm.pbox.Image = Image.FromStream(ms);

            frm.ShowDialog();
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            FRM_Preview frmV = new FRM_Preview();
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            byte[] pic = (byte[])prd.get_imgProduct(id).Rows[0][0];
            MemoryStream ms = new MemoryStream(pic);
            frmV.pbox1.Image = Image.FromStream(ms);

            frmV.ShowDialog();
        }

        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            RPT.FRM_rpt_Crr_Product frmR = new RPT.FRM_rpt_Crr_Product();
            frmR.sp_rpt_Curr_ProductTableAdapter.Fill(frmR.Curr_prod_DS.sp_rpt_Curr_Product, this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmR.reportViewer1.RefreshReport();
            frmR.Text = "تقرير المنتج : " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmR.ShowDialog();           
        }

        
        private void btn_rpt_AllPrpdcts_Click(object sender, EventArgs e)
        {
            RPT.FRM_rpt_AllProducts frmR = new RPT.FRM_rpt_AllProducts();
            frmR.sp_rpt_All_ProductsTableAdapter.Fill(frmR.AllProduct_DS.sp_rpt_All_Products);
            frmR.reportViewer1.RefreshReport();
            frmR.Text = "تقرير بالمنتجات " ;
            frmR.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ////RPT.rpt_all_products rpt = new RPT.rpt_all_products();
            ////ExportOptions export = new ExportOptions();
            ////DiskFileDestinationOptions diskOption = new DiskFileDestinationOptions();
            ////PdfFormatOptions PdfFormat = new PdfFormatOptions();

            ////diskOption.DiskFileName = @"E:\Products Report.pdf";
            ////export = rpt.ExportOptions;
            ////export.ExportDestinationType = ExportDestinationType.DiskFile;
            ////export.ExportDestinationOptions = diskOption;
            ////export.ExportFormatOptions = PdfFormat;
            ////export.ExportFormatType = ExportFormatType.PortableDocFormat;
            ////rpt.Refresh();
            ////rpt.Export();
            ////MessageBox.Show("Exporting Succeded", "Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        
    }
}

using System;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_Orders_list : Form
    {
        private BL.CLS_Orders clsOrder = new BL.CLS_Orders();

        public FRM_Orders_list()
        {
            InitializeComponent();
            DG_Orders.DataSource = clsOrder.Search_Orders("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DG_Orders.DataSource = clsOrder.Search_Orders(txtSearch.Text);
        }

       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            RPT.FRM_rpt_orderDetails frmR = new RPT.FRM_rpt_orderDetails();
            frmR.sp_get_order_detailsTableAdapter.Fill(frmR.DS_orderDetails.sp_get_order_details, Convert.ToInt32(this.DG_Orders.CurrentRow.Cells[0].Value));
            frmR.reportViewer1.RefreshReport();
            frmR.Text = "تقرير بالفاتورة الحالية : " + this.DG_Orders.CurrentRow.Cells[2].Value.ToString();
            frmR.ShowDialog();

            Cursor = Cursors.Default;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}

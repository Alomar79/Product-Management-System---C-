using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.RPT
{
    public partial class FRM_rpt_orderDetails : Form
    {
        public FRM_rpt_orderDetails()
        {
            InitializeComponent();
        }

        private void FRM_rpt_orderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_orderDetails.sp_get_order_details' table. You can move, or remove it, as needed.
            //this.sp_get_order_detailsTableAdapter.Fill(this.DS_orderDetails.sp_get_order_details);
            // TODO: This line of code loads data into the 'DS_orderDetails.sp_get_order_details' table. You can move, or remove it, as needed.
            //this.sp_get_order_detailsTableAdapter.Fill(this.DS_orderDetails.sp_get_order_details);
            // TODO: This line of code loads data into the 'DS_orderDetails.sp_get_order_details' table. You can move, or remove it, as needed.
            //this.sp_get_order_detailsTableAdapter.Fill(this.DS_orderDetails.sp_get_order_details);

            this.reportViewer1.RefreshReport();
        }
    }
}

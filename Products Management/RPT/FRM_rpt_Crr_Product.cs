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
    public partial class FRM_rpt_Crr_Product : Form
    {
        public FRM_rpt_Crr_Product()
        {
            InitializeComponent();
        }

        private void FRM_rpt_Crr_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Curr_prod_DS.sp_rpt_Curr_Product' table. You can move, or remove it, as needed.
            //this.sp_rpt_Curr_ProductTableAdapter.Fill(this.Curr_prod_DS.sp_rpt_Curr_Product);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class FRM_rpt : Form
    {
        PL.FRM_Products frmP = new PL.FRM_Products();
        public FRM_rpt()
        {
            InitializeComponent();
        }

        private void FRM_rpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AllProduct_DS.sp_rpt_All_Products' table. You can move, or remove it, as needed.
            //this.sp_rpt_All_ProductsTableAdapter.Fill(this.AllProduct_DS.sp_rpt_All_Products);
            //this.reportViewer1.RefreshReport();

        }
    }
}

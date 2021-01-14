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
    public partial class FRM_Curr_Category : Form
    {
        public FRM_Curr_Category()
        {
            InitializeComponent();
        }

        private void FRM_Curr_Category_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'DS_currCategory.sp_rpt_single_category' table. You can move, or remove it, as needed.
            //this.sp_rpt_single_categoryTableAdapter.Fill(this.DS_currCategory.sp_rpt_single_category);

            //this.reportViewer1.RefreshReport();
        }
    }
}

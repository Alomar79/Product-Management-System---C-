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
    public partial class FRM_rpt_allCategories : Form
    {
        public FRM_rpt_allCategories()
        {
            InitializeComponent();
        }

        private void FRM_rpt_allCategories_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'DS_allCategories.sp_get_all_categories' table. You can move, or remove it, as needed.
            //this.sp_get_all_categoriesTableAdapter.Fill(this.DS_allCategories.sp_get_all_categories);

            //this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_Customers_List : Form
    {
        private BL.CLS_Customers custo = new BL.CLS_Customers();
        public FRM_Customers_List()
        {
            InitializeComponent();
            this.dGrid2.DataSource = custo.get_all_customers();
            this.dGrid2.Columns[0].Visible = false;
            this.dGrid2.Columns[5].Visible = false;
        }

        private void dGrid2_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

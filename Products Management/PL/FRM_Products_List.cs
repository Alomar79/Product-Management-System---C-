using System;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_Products_List : Form
    {
        private BL.CLS_Products cls1 = new BL.CLS_Products();

        public FRM_Products_List()
        {
            InitializeComponent();
            dataGridView1.DataSource = cls1.get_all_products();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

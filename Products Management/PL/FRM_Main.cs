using System;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_Main : Form
    {
        private static FRM_Main frmM;

        private static void frmM_Formclosed(object sender, FormClosedEventArgs e)
        {
            frmM = null;
        }
        public static FRM_Main getMainForm
        {
            get
            {
                if (frmM == null)
                {
                    frmM = new FRM_Main();
                    frmM.FormClosed += new FormClosedEventHandler(frmM_Formclosed);
                }
                return frmM;
            }
        }
        public FRM_Main()
        {
            InitializeComponent();
            if (frmM == null)
            {
                frmM = this;
            }
            this.ToolStripMenuItem_Products.Enabled = false;
            this.ToolStripMenuItem_Customers.Enabled = false;
            this.ToolStripMenuItem_Users.Enabled = false;
            //this.ToolStripMenuItem_RestoreBackup.Enabled = false;
            //this.ToolStripMenuItem_CreateBackup.Enabled = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem_Login_Click(object sender, EventArgs e)
        {
            Frm_Login frm1 = new Frm_Login();
            frm1.ShowDialog();
        }

        private void ToolStripMenuItem_RestoreBackup_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_AddProduct_Click(object sender, EventArgs e)
        {
            FRM_Add_Product frm3 = new FRM_Add_Product();
            frm3.ShowDialog();
        }

        private void ToolStripMenuItem_ManagProducts_Click(object sender, EventArgs e)
        {
            FRM_Products frm = new FRM_Products();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_ManagCateg_Click(object sender, EventArgs e)
        {
            FRM_Categories frm = new FRM_Categories();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_Customers_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_AddOrder_Click(object sender, EventArgs e)
        {
            PL.FRM_Orders frmOrder = new FRM_Orders();
            frmOrder.ShowDialog();
        }

        private void ToolStripMenuItem_Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItem_ManagOrders_Click(object sender, EventArgs e)
        {
            PL.FRM_Orders_list frmOL = new FRM_Orders_list();
            frmOL.ShowDialog();
        }

        private void ToolStripMenuItem_AddUser_Click(object sender, EventArgs e)
        {
            PL.FRM_Add_User frmU = new FRM_Add_User();
            frmU.ShowDialog();
        }

        private void ToolStripMenuItem_ManagUsers_Click(object sender, EventArgs e)
        {
            FRM_Users_List frmLi = new FRM_Users_List();
            frmLi.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_CreateBackup_Click(object sender, EventArgs e)
        {
            FRM_Backup frmB = new FRM_Backup();
            frmB.ShowDialog();
        }

        private void Restore_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Backup frm = new FRM_Backup();
            frm.ShowDialog();
        }

        private void serverconfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Config frm = new FRM_Config();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_ManagCustomers_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_AddCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class Frm_Login : Form
    {
        private BL.CLS_Login log = new BL.CLS_Login();
        public Frm_Login()
        {
            InitializeComponent();
            txtID.Focus();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = log.login(txtID.Text, txtPwd.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "ADMIN")
                {
                    FRM_Main.getMainForm.ToolStripMenuItem_CreateBackup.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_RestoreBackup.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_Products.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_Customers.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_Users.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_Users.Visible = true;
                    
                    this.Close();
                    //MessageBox.Show("login succeed", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dt.Rows[0][2].ToString() == "USER")
                {
                    FRM_Main.getMainForm.ToolStripMenuItem_CreateBackup.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_RestoreBackup.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_Products.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_Customers.Enabled = true;
                    FRM_Main.getMainForm.ToolStripMenuItem_Users.Visible = false;
                    

                    this.Close();
                }

                Program.Salesman = dt.Rows[0]["fullname"].ToString();
                FRM_Main.getMainForm.lblWelcome.Text = "مرحباً سيد : " + Program.Salesman;
                FRM_Main.getMainForm.label1.Visible = false;
                FRM_Main.getMainForm.ToolStripMenuItem_Login.Enabled = false;
            }


            else
            {
                MessageBox.Show("login Failed", "login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
              txtPwd.Focus();
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.Focus();
        }
    }
}

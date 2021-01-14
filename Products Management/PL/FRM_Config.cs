using System;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_Config : Form
    {
        public FRM_Config()
        {
            InitializeComponent();
            txtServer.Text=Properties.Settings.Default.Server;
            txtDB.Text=Properties.Settings.Default.Database ;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rb_Sql.Checked = true;
                txtUserID.Text = Properties.Settings.Default.ID;
                txtPwd.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rb_win.Checked = true;
                txtUserID.Clear();
                txtPwd.Clear();
                txtUserID.ReadOnly = true;
                txtPwd.ReadOnly = true;
                   
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDB.Text;
            Properties.Settings.Default.Mode = rb_Sql.Checked==true? "SQL" : "Windows";
            Properties.Settings.Default.ID = txtUserID.Text;
            Properties.Settings.Default.Password = txtPwd.Text;
            Properties.Settings.Default.Save();
            
            
            MessageBox.Show("تم حفظ الاعدادات بنجاح", "حفظ اعدادات السيرفر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.Close();
        }

        private void rb_Sql_CheckedChanged(object sender, EventArgs e)
        {
            txtUserID.ReadOnly = false;
            txtPwd.ReadOnly = false;
        }

        private void rb_win_CheckedChanged(object sender, EventArgs e)
        {
            txtUserID.ReadOnly = true;
            txtPwd.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = @".\SQLEXPRESS";
            Properties.Settings.Default.Database = "Product_DB";
            rb_win.Checked = true;
            //rb_Sql.Checked = false;
            txtUserID.Clear();
            txtPwd.Clear();
            txtUserID.ReadOnly = true;
            txtPwd.ReadOnly = true;
            Properties.Settings.Default.Save();
        }
    }
}

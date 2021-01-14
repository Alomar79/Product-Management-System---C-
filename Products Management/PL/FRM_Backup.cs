using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Products_Management.PL
{
    public partial class FRM_Backup : Form
    {
        public FRM_Backup()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnMakeBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName.Text != string.Empty)
                {
                    DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

                    dal.Open();
                    dal.MakeBackup(txtFileName.Text);
                    dal.Close();
                    MessageBox.Show("تم انشاء نسخة احتياطية بنجاح", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFileName.Clear();
                }
                else
                    MessageBox.Show("اختر المسار الذي تريد حفظ النسخة فيه", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("حصل خطأ في العملية، حاول تغيير مكان الحفظ \n " + ":تفاصيل الخطأ \n " + ex.Message, "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }



        private void btnBrowse_R_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Backup Files | *.bak;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName_R.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName_R.Text != string.Empty)
                {
                    DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

                    //dal.Open(); لأن اتصالها مختلف لذلك عملنا الفتح والاغلاق في الكلاس
                    dal.RestoreBackup(txtFileName_R.Text);
                   
                    MessageBox.Show("تم استعادة نسخة احتياطية بنجاح", "استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFileName_R.Clear();
                }
                else
                    MessageBox.Show("اختر النسخة المحفوظة", "استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ":حصل الخطأ التالي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}

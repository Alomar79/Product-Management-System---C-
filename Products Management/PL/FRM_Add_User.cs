using System;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_Add_User : Form
    {
        
        
        public FRM_Add_User()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text==string.Empty || txtPWD.Text == string.Empty ||txtPWD_Confirm.Text == string.Empty ||txtFullName.Text == string.Empty)
            {
                MessageBox.Show("جميع الحقول مطلوبة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if(txtPWD.Text != txtPWD_Confirm.Text)
            {
                MessageBox.Show("حقلي كلمة السر غير متطابقين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            FRM_Users_List frmList = new FRM_Users_List();
            BL.CLS_Login clsLG = new BL.CLS_Login();

            if (btnAddUser.Text == "حفظ المستخدم")
            {
                clsLG.Add_User(txtUserID.Text, txtFullName.Text, txtPWD.Text, CmbUsers.Text);
                MessageBox.Show("تمت اضافة المستخدم", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(btnAddUser.Text == "تعديل المستخدم")
            {
                clsLG.Edit_User(txtUserID.Text, txtFullName.Text, txtPWD.Text, CmbUsers.Text);
                MessageBox.Show("تم نعديل المستخدم", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //clear texts
            txtUserID.Clear();
            txtFullName.Clear();
            txtPWD.Clear();
            txtPWD_Confirm.Clear();
            CmbUsers.Text = null;
            txtUserID.Focus();
        }
    }
}

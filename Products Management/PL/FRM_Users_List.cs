using System;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_Users_List : Form
    {        
        public FRM_Users_List()
        {
            BL.CLS_Login clsL = new BL.CLS_Login();
            InitializeComponent();
            DG_Users.DataSource = clsL.Search_User("");
            //DG_Users.Columns["pwd"].Visible = false; // the index of pwd =1
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FRM_Add_User frmS = new FRM_Add_User();
            BL.CLS_Login clsL = new BL.CLS_Login();
            frmS.btnAddUser.Text = "حفظ المستخدم";
            frmS.Text = "إضافة مستخدم جديد";            
            frmS.ShowDialog();
            DG_Users.DataSource = clsL.Search_User("");
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FRM_Add_User frmS = new FRM_Add_User();
            frmS.btnAddUser.Text = "تعديل المستخدم";
            frmS.Text = "تعديل مستخدم ";
            frmS.txtUserID.Text = DG_Users.CurrentRow.Cells[0].Value.ToString();
            frmS.txtPWD.Text = DG_Users.CurrentRow.Cells[1].Value.ToString();
            frmS.txtPWD_Confirm.Text = DG_Users.CurrentRow.Cells[1].Value.ToString();
            frmS.txtFullName.Text = DG_Users.CurrentRow.Cells[2].Value.ToString();
            frmS.CmbUsers.Text = DG_Users.CurrentRow.Cells[3].Value.ToString();

            BL.CLS_Login clsL = new BL.CLS_Login();
            frmS.ShowDialog();
            DG_Users.DataSource = clsL.Search_User("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            BL.CLS_Login clsL = new BL.CLS_Login();
            DG_Users.DataSource = clsL.Search_User(txtSearchUser.Text);

        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            BL.CLS_Login clsL = new BL.CLS_Login();
            if (MessageBox.Show("هل تريد حذف المستخدم المحدد؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsL.Delete_User(DG_Users.CurrentRow.Cells[0].Value.ToString());
                DG_Users.DataSource = clsL.Search_User("");
            }
        }
    }
}

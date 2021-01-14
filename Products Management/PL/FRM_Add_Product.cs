using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Products_Management.PL
{
    public partial class FRM_Add_Product : Form
    {
        public string state = "Add";
        private BL.CLS_Products prd = new BL.CLS_Products();      
         
        public FRM_Add_Product()
        {
            InitializeComponent();
           
            cmbCategories.DataSource = prd.get_all_categories();
            cmbCategories.DisplayMember = "description_cat";
            cmbCategories.ValueMember = "id_cat";

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.jpg; *.png; *.bmp; *.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] pic = ms.ToArray();

                prd.Add_Product(txtRef.Text, txtDesc.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, pic, Convert.ToInt32(cmbCategories.SelectedValue));
                MessageBox.Show("تمت عملية الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] pic = ms.ToArray();

                prd.Update_Product(txtRef.Text, txtDesc.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, pic, Convert.ToInt32(cmbCategories.SelectedValue));
                MessageBox.Show("تمت عملية التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            FRM_Products.getMainForm.dataGridView1.DataSource = prd.get_all_products();
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                DataTable dt = prd.VerifyProductID(txtRef.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("already Exist!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;

                }
            }                
        }

        private void pbox_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

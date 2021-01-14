using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Products_Management.PL
{
    public partial class FRM_Orders : Form
    {
        private BL.CLS_Orders cls1 = new BL.CLS_Orders();
        private DataTable dt = new DataTable();

        private void Calc_Amount()
        {
            if (txtPrice.Text != string.Empty && txtQty.Text != string.Empty)
            {
                double Amount = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQty.Text);
                txtAmount.Text = Amount.ToString();
            }
        }

        private void Calc_TotalAmount()
        {
            if (txtAmount.Text != string.Empty && txtDiscount.Text != string.Empty)
            {
                double TotalAmount = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtAmount.Text) * Convert.ToDouble(txtDiscount.Text) / 100;
                txtTotalAmount.Text = TotalAmount.ToString();                
            }
        }

        private void Clear_TextBoxes()
        {
            txtPrductID.Clear();
            txtProdName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtAmount.Clear();
            txtDiscount.Clear();
            txtTotalAmount.Clear();

            btnChoose.Focus();
        }

        private void CreateDatatable()
        {
            dt.Columns.Add("معرف المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("خصم %");
            dt.Columns.Add("الاجمالي");
            DGridProducts.DataSource = dt;
        }

        private void ResizeDGView()
        {
            this.DGridProducts.RowHeadersWidth = 77;
            this.DGridProducts.Columns[0].Width = 76;
            this.DGridProducts.Columns[1].Width = 178;
            this.DGridProducts.Columns[2].Width = 53;
            this.DGridProducts.Columns[3].Width = 53;
            this.DGridProducts.Columns[4].Width = 69;
            this.DGridProducts.Columns[5].Width = 53;
            this.DGridProducts.Columns[6].Width = 83;
        }

        private void Calc_Sum_Totals()
        {
            if (txtTotalAmount.Text != "")
            {
                double sum = 0;
                for (int i = 0; i < DGridProducts.Rows.Count - 1; i++)
                {
                    sum += Convert.ToDouble(DGridProducts.Rows[i].Cells[6].Value.ToString());
                }
                txtSum_Totals.Text = sum.ToString();
                

                // .==>>  By LinQ Technology::
                //txtSum_Totals.Text = (from DataGridViewRow row in DGridProducts.Rows 
                //                      where row.Cells[6].FormattedValue.ToString() != String.Empty 
                //                      select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }
        public FRM_Orders()                             // initialize the Form 
        {
            InitializeComponent();
            CreateDatatable();
            ResizeDGView();
            txtSalesman.Text = Program.Salesman;
        } 

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = cls1.last_orderID().Rows[0][0].ToString();
            //تفريغ الصناديق
            Clear_TextBoxes();
            txtCstomerID.Clear(); txtFname.Clear();txtLname.Clear(); txtEmail.Clear(); txtMob.Clear(); txtDesc.Clear();
            dt.Clear();
            DGridProducts.Refresh();
            txtSum_Totals.Clear();

            btnNewOrder.Enabled = false;
            btnSaveOrder.Enabled = true;
            button1.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            FRM_Customers_List frmC = new FRM_Customers_List();
            frmC.ShowDialog();
            txtCstomerID.Text = frmC.dGrid2.CurrentRow.Cells[0].Value.ToString();
            txtFname.Text = frmC.dGrid2.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = frmC.dGrid2.CurrentRow.Cells[2].Value.ToString();
            txtMob.Text = frmC.dGrid2.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = frmC.dGrid2.CurrentRow.Cells[4].Value.ToString();

            if(frmC.dGrid2.CurrentRow.Cells[5].Value is DBNull)
            {
                return;
            }
            else
            {
                byte[] pic = (byte[])frmC.dGrid2.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pic);
                this.pictureBox1.Image = Image.FromStream(ms);
            }           

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Clear_TextBoxes();
            PL.FRM_Products_List frmP = new PL.FRM_Products_List();
            frmP.ShowDialog();
            txtPrductID.Text = frmP.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProdName.Text= frmP.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = frmP.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtQty.Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
        //char.IsDigit(e.KeyChar) :  يسمح بالارقام فقط
        //e.KeyChar != 8   :  يسمح بالحذف
        //e.KeyChar!=Convert.ToChar( System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator) :  يسمح بالفاصلة العشرية

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalCeperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!= DecimalCeperator)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtPrice.Text != string.Empty)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            //if(Convert.ToInt32(txtQty.Text)<)
           

            if (e.KeyCode == Keys.Enter && txtQty.Text != string.Empty)
            {
                txtDiscount.Focus();
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            Calc_Amount();
            Calc_TotalAmount();
        }       
        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            Calc_Amount();
            Calc_TotalAmount();
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            //Calc_Amount();
            Calc_TotalAmount();
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (cls1.VerifyQty(txtPrductID.Text, Convert.ToInt32(txtQty.Text)).Rows.Count<1)
            {
                MessageBox.Show("الكمية المدخلة غير متوفرة", "! تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtQty.Select();
                return;
            }
            for (int i =0; i < DGridProducts.Rows.Count - 1; i++)
            {
                if (DGridProducts.Rows[i].Cells[0].Value.ToString() == txtPrductID.Text)
                {
                    MessageBox.Show("! هذا المنتج تمت إضافته مسبقاً  ", "! تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
            }
            if (txtDiscount.Text == "" || txtPrductID.Text=="" || txtPrice.Text=="" || txtAmount.Text==""
                ||txtTotalAmount.Text=="")
                return;
            if (e.KeyCode == Keys.Enter)
            {
                DataRow r = dt.NewRow();               

                r[0] = txtPrductID.Text;
                r[1] = txtProdName.Text;
                r[2] = txtPrice.Text;
                r[3] = txtQty.Text;
                r[4] = txtAmount.Text;
                r[5] = txtDiscount.Text;
                r[6] = txtTotalAmount.Text;

                dt.Rows.Add(r);
                DGridProducts.DataSource = dt;

                if (txtSum_Totals.Text == "")
                    txtSum_Totals.Text = "0";

                Calc_Sum_Totals();
                Clear_TextBoxes();
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (txtCstomerID.Text == string.Empty)
            {
                MessageBox.Show("!اختر عميل ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDesc.Text == string.Empty)
            {
                MessageBox.Show("!ضع وصفاً للفاتورة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtOrderID.Text == string.Empty)
            {
                MessageBox.Show("!لم تقم بإضافة فاتورة جديدة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DGridProducts.Rows.Count <= 1)
            {
                MessageBox.Show("!لم تقم بإضافة منتجات للفاتورة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cls1.Add_Order(Convert.ToInt32( txtOrderID.Text), dateTimePicker1.Value, Convert.ToInt32(txtCstomerID.Text),txtDesc.Text,txtSalesman.Text );
            // اضافة منتجات الفاتورة

            for(int i = 0; i < DGridProducts.Rows.Count-1; i++)
            {
                string x_idProduct = DGridProducts.Rows[i].Cells[0].Value.ToString();
                int x_idOrder = Convert.ToInt32(txtOrderID.Text);
                int x_qte = Convert.ToInt32(DGridProducts.Rows[i].Cells[3].Value);
                string x_price = DGridProducts.Rows[i].Cells[2].Value.ToString();
                double x_discount = Convert.ToDouble(DGridProducts.Rows[i].Cells[5].Value);
                string x_amount = DGridProducts.Rows[i].Cells[4].Value.ToString();
                string x_Total_Amount = DGridProducts.Rows[i].Cells[6].Value.ToString();

                cls1.Add_Orders_Details(x_idProduct, x_idOrder, x_qte,x_price,x_discount,x_amount,x_Total_Amount);
            }
            Clear_TextBoxes();
            txtOrderID.Clear(); txtCstomerID.Clear(); txtFname.Clear(); txtLname.Clear(); txtEmail.Clear(); txtMob.Clear(); txtDesc.Clear();
            txtSum_Totals.Clear();
            dt.Clear();
            DGridProducts.Refresh();

            MessageBox.Show("Added Successfully !", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNewOrder.Enabled = true;
            button1.Enabled = true;
            btnSaveOrder.Enabled = false;
            btnOrderPrint.Enabled = true;
        }

        private void editToolStrip_Click(object sender, EventArgs e)
        {
            //  هذا لأجل ألا يظهر خطأ عند محاولة تعديل السطر الفاضي
            if (DGridProducts.CurrentRow.Cells[0].Value.ToString() == string.Empty || txtTotalAmount.Text != string.Empty)
                return;           
            else
            {
                txtPrductID.Text = DGridProducts.CurrentRow.Cells[0].Value.ToString();
                txtProdName.Text = DGridProducts.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = DGridProducts.CurrentRow.Cells[2].Value.ToString();
                txtQty.Text = DGridProducts.CurrentRow.Cells[3].Value.ToString();
                txtAmount.Text = DGridProducts.CurrentRow.Cells[4].Value.ToString();
                txtDiscount.Text = DGridProducts.CurrentRow.Cells[5].Value.ToString();
                txtTotalAmount.Text = DGridProducts.CurrentRow.Cells[6].Value.ToString();

                DGridProducts.Rows.RemoveAt(DGridProducts.CurrentRow.Index);
                DGridProducts.Refresh();
                Calc_Sum_Totals();
                txtQty.Focus();
            }

        }

        private void deleteRowToolStrip_Click(object sender, EventArgs e)
        {
                        // الشرط حتى لاتتم محاولة حذف السطر الفاضي الموجود دائماً في الداتاجريد
            if (DGridProducts.CurrentRow.Cells[0].Value.ToString() == string.Empty)
                return;
            else
            {
                double x =Convert.ToDouble( DGridProducts.CurrentRow.Cells[6].Value.ToString());
               /* من أجل تنقيصها من المجموع النهائي
                     .لأنه جحّش مايفعل يقبل مثل التعديل اللي بحدّث السعر النهائي لحالو */
                DGridProducts.Rows.RemoveAt(DGridProducts.CurrentRow.Index);
                DGridProducts.Refresh();

                txtSum_Totals.Text =(Convert.ToDouble(txtSum_Totals.Text)- x).ToString();
                btnChoose.Focus();
                //Calc_Sum_Totals();
            }
        }

        private void deleteAllToolStrip_Click(object sender, EventArgs e)
        {
            dt.Clear();
            DGridProducts.Refresh();
            btnChoose.Focus();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            btnNewOrder_Click( sender,  e);
            button1.Enabled = false;
            btnSaveOrder.Enabled = true;
        }

        private void btnOrderPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            //get last order
            int id_order = Convert.ToInt32(cls1.Get_last_order().Rows[0][0]);

            RPT.FRM_rpt_orderDetails frmR = new RPT.FRM_rpt_orderDetails();
            frmR.sp_get_order_detailsTableAdapter.Fill(frmR.DS_orderDetails.sp_get_order_details, id_order);
            frmR.reportViewer1.RefreshReport();
            frmR.Text = "تقرير بالفاتورة الحالية : " + this.txtDesc.Text;
            frmR.ShowDialog();

            Cursor = Cursors.Default;
        }
    }
}

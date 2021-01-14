namespace Products_Management.PL
{
    partial class FRM_Customers_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGrid2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrid2
            // 
            this.dGrid2.AllowUserToAddRows = false;
            this.dGrid2.AllowUserToDeleteRows = false;
            this.dGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGrid2.Location = new System.Drawing.Point(0, 0);
            this.dGrid2.Name = "dGrid2";
            this.dGrid2.ReadOnly = true;
            this.dGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid2.Size = new System.Drawing.Size(496, 340);
            this.dGrid2.TabIndex = 0;
            this.dGrid2.DoubleClick += new System.EventHandler(this.dGrid2_DoubleClick);
            // 
            // FRM_Customers_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 340);
            this.Controls.Add(this.dGrid2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Customers_List";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحة جميع العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dGrid2;
    }
}
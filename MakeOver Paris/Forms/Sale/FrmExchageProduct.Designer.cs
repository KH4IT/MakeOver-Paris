namespace MakeOver_Paris.Forms.Sale
{
    partial class FrmExchageProduct
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
            this.txtInvoiceCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOldProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNewProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInvoiceCode
            // 
            this.txtInvoiceCode.Location = new System.Drawing.Point(138, 59);
            this.txtInvoiceCode.Name = "txtInvoiceCode";
            this.txtInvoiceCode.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceCode.TabIndex = 0;
            this.txtInvoiceCode.Leave += new System.EventHandler(this.txtInvoiceCode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Code:";
            // 
            // cboOldProduct
            // 
            this.cboOldProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOldProduct.FormattingEnabled = true;
            this.cboOldProduct.Location = new System.Drawing.Point(138, 85);
            this.cboOldProduct.Name = "cboOldProduct";
            this.cboOldProduct.Size = new System.Drawing.Size(121, 21);
            this.cboOldProduct.TabIndex = 2;
            this.cboOldProduct.SelectedIndexChanged += new System.EventHandler(this.cboOldProduct_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Old Product: ";
            // 
            // cboNewProduct
            // 
            this.cboNewProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewProduct.FormattingEnabled = true;
            this.cboNewProduct.Location = new System.Drawing.Point(370, 85);
            this.cboNewProduct.Name = "cboNewProduct";
            this.cboNewProduct.Size = new System.Drawing.Size(121, 21);
            this.cboNewProduct.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Product: ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(138, 114);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmExchageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNewProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboOldProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvoiceCode);
            this.Name = "FrmExchageProduct";
            this.Text = "FrmExchageProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoiceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOldProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNewProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
    }
}
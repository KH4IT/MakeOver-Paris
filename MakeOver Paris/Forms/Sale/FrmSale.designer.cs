namespace MakeOver_Paris.Forms.Sale
{
    partial class FrmSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.c_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_priceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.cboMember = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Image = global::MakeOver_Paris.Properties.Resources.arrow3;
            this.btnBack.Location = new System.Drawing.Point(6, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdItems
            // 
            this.grdItems.AllowUserToAddRows = false;
            this.grdItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdItems.BackgroundColor = System.Drawing.Color.White;
            this.grdItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_number,
            this.c_productname,
            this.c_quantity,
            this.c_price,
            this.c_subtotal,
            this.c_remove,
            this.c_id,
            this.c_priceIn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdItems.Location = new System.Drawing.Point(5, 305);
            this.grdItems.Name = "grdItems";
            this.grdItems.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.grdItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdItems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grdItems.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.grdItems.RowTemplate.Height = 30;
            this.grdItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItems.Size = new System.Drawing.Size(1000, 351);
            this.grdItems.TabIndex = 0;
            this.grdItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellClick);
            // 
            // c_number
            // 
            this.c_number.HeaderText = "ល.រ.";
            this.c_number.Name = "c_number";
            // 
            // c_productname
            // 
            this.c_productname.HeaderText = "ឈ្មោះ​ផលិតផល";
            this.c_productname.Name = "c_productname";
            // 
            // c_quantity
            // 
            this.c_quantity.HeaderText = "បរិមាណ";
            this.c_quantity.Name = "c_quantity";
            // 
            // c_price
            // 
            this.c_price.HeaderText = "តម្លៃ";
            this.c_price.Name = "c_price";
            // 
            // c_subtotal
            // 
            this.c_subtotal.HeaderText = "តម្លៃ​សរុប";
            this.c_subtotal.Name = "c_subtotal";
            // 
            // c_remove
            // 
            this.c_remove.HeaderText = "លុប​ចោល";
            this.c_remove.Name = "c_remove";
            this.c_remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // c_id
            // 
            this.c_id.HeaderText = "productid";
            this.c_id.Name = "c_id";
            this.c_id.Visible = false;
            // 
            // c_priceIn
            // 
            this.c_priceIn.HeaderText = "pricein";
            this.c_priceIn.Name = "c_priceIn";
            this.c_priceIn.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(498, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Member:";
            // 
            // cboMember
            // 
            this.cboMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMember.FormattingEnabled = true;
            this.cboMember.Location = new System.Drawing.Point(583, 5);
            this.cboMember.Name = "cboMember";
            this.cboMember.Size = new System.Drawing.Size(227, 26);
            this.cboMember.TabIndex = 32;
            this.cboMember.SelectedIndexChanged += new System.EventHandler(this.cboMember_SelectedIndexChanged);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.Panel5);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1024, 749);
            this.Panel1.TabIndex = 6;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Controls.Add(this.btnBack);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Panel3);
            this.Panel2.Location = new System.Drawing.Point(0, 11);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1024, 60);
            this.Panel2.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(62, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(235, 30);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Sale Management";
            // 
            // Panel3
            // 
            this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Panel3.Location = new System.Drawing.Point(0, 55);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1024, 5);
            this.Panel3.TabIndex = 1;
            // 
            // Panel5
            // 
            this.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Panel5.Controls.Add(this.btnMemberList);
            this.Panel5.Location = new System.Drawing.Point(8, 306);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(1007, 30);
            this.Panel5.TabIndex = 3;
            // 
            // btnMemberList
            // 
            this.btnMemberList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMemberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnMemberList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMemberList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemberList.FlatAppearance.BorderSize = 0;
            this.btnMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberList.ForeColor = System.Drawing.Color.White;
            this.btnMemberList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberList.Location = new System.Drawing.Point(0, 0);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(216, 30);
            this.btnMemberList.TabIndex = 1;
            this.btnMemberList.Text = "Sale Information &List";
            this.btnMemberList.UseVisualStyleBackColor = false;
            // 
            // Panel4
            // 
            this.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel4.Controls.Add(this.panel6);
            this.Panel4.Controls.Add(this.grdItems);
            this.Panel4.ForeColor = System.Drawing.Color.White;
            this.Panel4.Location = new System.Drawing.Point(8, 77);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1008, 659);
            this.Panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtDiscount);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.cboMember);
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtCode);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1001, 218);
            this.panel6.TabIndex = 5;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDiscount.Location = new System.Drawing.Point(900, 4);
            this.txtDiscount.Mask = "##%";
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 27);
            this.txtDiscount.TabIndex = 38;
            this.txtDiscount.Text = "00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(816, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Discount:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(789, 47);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(895, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(73, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barcode:";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(158, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(300, 27);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSale";
            this.Text = "FrmSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox btnBack;
        internal System.Windows.Forms.DataGridView grdItems;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboMember;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button btnMemberList;
        internal System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn c_remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_priceIn;
    }
}
namespace MakeOver_Paris.Forms.Product
{
    partial class FrmProduct
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReturnQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPriceOut = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPriceIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
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
            this.Panel1.TabIndex = 5;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
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
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Khmer OS Content", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(62, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(174, 38);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ការគ្រប់គ្រង់ទំនិញ";
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
            this.Panel5.Location = new System.Drawing.Point(8, 333);
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
            this.btnMemberList.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberList.ForeColor = System.Drawing.Color.White;
            this.btnMemberList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberList.Location = new System.Drawing.Point(3, -2);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(129, 30);
            this.btnMemberList.TabIndex = 1;
            this.btnMemberList.Text = "ពត៍មានទំនិញ";
            this.btnMemberList.UseVisualStyleBackColor = false;
            // 
            // Panel4
            // 
            this.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel4.Controls.Add(this.panel6);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.txtSearch);
            this.Panel4.Controls.Add(this.dgvProduct);
            this.Panel4.ForeColor = System.Drawing.Color.White;
            this.Panel4.Location = new System.Drawing.Point(8, 77);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1008, 659);
            this.Panel4.TabIndex = 4;
            this.Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.txtReturnQuantity);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtRemark);
            this.panel6.Controls.Add(this.cboCategory);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtPriceOut);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txtQuantity);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtPriceIn);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtProductCode);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtDescription);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtBarcode);
            this.panel6.Location = new System.Drawing.Point(4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1001, 245);
            this.panel6.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(541, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "បរិមាណប្តុវិញ:";
            // 
            // txtReturnQuantity
            // 
            this.txtReturnQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReturnQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnQuantity.Location = new System.Drawing.Point(645, 159);
            this.txtReturnQuantity.Name = "txtReturnQuantity";
            this.txtReturnQuantity.Size = new System.Drawing.Size(300, 27);
            this.txtReturnQuantity.TabIndex = 36;
            this.txtReturnQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturnQuantity_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(88, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "ប្រភេទ:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(581, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "សំគាល់:";
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRemark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(645, 87);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(300, 66);
            this.txtRemark.TabIndex = 33;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(157, 101);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(300, 26);
            this.cboCategory.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(48, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "តម្លៃលក់ចេញ:";
            // 
            // txtPriceOut
            // 
            this.txtPriceOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceOut.Location = new System.Drawing.Point(157, 199);
            this.txtPriceOut.Name = "txtPriceOut";
            this.txtPriceOut.Size = new System.Drawing.Size(300, 27);
            this.txtPriceOut.TabIndex = 30;
            this.txtPriceOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceOut_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(82, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "បរិមាណ:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(157, 133);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(300, 27);
            this.txtQuantity.TabIndex = 28;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(99, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "ឈ្មោះ:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(157, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 27);
            this.txtName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(55, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "តម្លៃទិញចូល:";
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceIn.Location = new System.Drawing.Point(157, 166);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.Size = new System.Drawing.Size(300, 27);
            this.txtPriceIn.TabIndex = 24;
            this.txtPriceIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceIn_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(51, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "លេខកូដទំនិញ:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(157, 36);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(300, 27);
            this.txtProductCode.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(572, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "បរិយាយ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(645, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 77);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(798, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(904, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(99, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "បាកូដ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(157, 3);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(300, 27);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Label2.Location = new System.Drawing.Point(55, 299);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "ស្វែងរក:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(128, 295);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.Location = new System.Drawing.Point(5, 330);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dgvProduct.RowTemplate.Height = 30;
            this.dgvProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1000, 326);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.PictureBox btnBack;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button btnMemberList;
        internal System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.DataGridView dgvProduct;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtReturnQuantity;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cboCategory;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtPriceOut;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtPriceIn;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtProductCode;
    }
}
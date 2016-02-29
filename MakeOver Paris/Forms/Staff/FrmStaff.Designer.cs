namespace MakeOver_Paris.Forms.Staff
{
    partial class FrmStaff
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
            this.Panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.Panel5.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel4
            // 
            this.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel4.Controls.Add(this.panel6);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.txtSearch);
            this.Panel4.Controls.Add(this.dgvStaff);
            this.Panel4.ForeColor = System.Drawing.Color.White;
            this.Panel4.Location = new System.Drawing.Point(0, 67);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1008, 659);
            this.Panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chkShowPassword);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtType);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtCommission);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtPassword);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Location = new System.Drawing.Point(4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1001, 197);
            this.panel6.TabIndex = 5;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.Black;
            this.chkShowPassword.Location = new System.Drawing.Point(189, 78);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(136, 31);
            this.chkShowPassword.TabIndex = 2;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(659, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "%";
            // 
            // txtType
            // 
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.txtType.Location = new System.Drawing.Point(186, 112);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(500, 28);
            this.txtType.TabIndex = 3;
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
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(797, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(903, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(77, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "អត្រាភាគរយ:";
            // 
            // txtCommission
            // 
            this.txtCommission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCommission.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.Location = new System.Drawing.Point(186, 146);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(500, 27);
            this.txtCommission.TabIndex = 4;
            this.txtCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommission_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(118, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "ប្រភេទ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(88, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "លេខសំងាត់​:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(186, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(500, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(122, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "ឈ្មោះ:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(186, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(500, 27);
            this.txtName.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Label2.Location = new System.Drawing.Point(57, 243);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 27);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "ស្វែងរក:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(128, 243);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 27);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.Location = new System.Drawing.Point(5, 280);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.dgvStaff.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvStaff.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvStaff.RowTemplate.Height = 30;
            this.dgvStaff.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1000, 376);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellDoubleClick);
            // 
            // Panel5
            // 
            this.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.Controls.Add(this.btnMemberList);
            this.Panel5.Location = new System.Drawing.Point(0, 269);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(1007, 38);
            this.Panel5.TabIndex = 3;
            // 
            // btnMemberList
            // 
            this.btnMemberList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMemberList.BackColor = System.Drawing.Color.Black;
            this.btnMemberList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMemberList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemberList.FlatAppearance.BorderSize = 0;
            this.btnMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberList.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberList.ForeColor = System.Drawing.Color.White;
            this.btnMemberList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberList.Location = new System.Drawing.Point(-1, 0);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(176, 36);
            this.btnMemberList.TabIndex = 1;
            this.btnMemberList.Text = "ពត៍មានបុគ្គលិក";
            this.btnMemberList.UseVisualStyleBackColor = false;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Controls.Add(this.btnBack);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Panel3);
            this.Panel2.Location = new System.Drawing.Point(-8, 1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1024, 60);
            this.Panel2.TabIndex = 2;
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
            this.Label1.Font = new System.Drawing.Font("Khmer OS Content", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(62, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(180, 43);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "គ្រប់គ្រងបុគ្គលិក";
            // 
            // Panel3
            // 
            this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel3.BackColor = System.Drawing.Color.Black;
            this.Panel3.Location = new System.Drawing.Point(0, 55);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1024, 5);
            this.Panel3.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.Panel5);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1008, 729);
            this.Panel1.TabIndex = 3;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStaff";
            this.Text = "FrmStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStaff_KeyDown);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.PictureBox btnBack;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button btnMemberList;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtCommission;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox txtType;
        internal System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label label7;
    }
}
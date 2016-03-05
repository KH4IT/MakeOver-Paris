namespace MakeOver_Paris.Forms.Member
{
    partial class FrmMemberType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.dgvMemberType = new System.Windows.Forms.DataGridView();
            this.panel6.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberType)).BeginInit();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(870, 53);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(118, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "ប្រភេទ:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(183, 17);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(500, 27);
            this.txtTitle.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtTitle);
            this.panel6.Location = new System.Drawing.Point(4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1001, 106);
            this.panel6.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(749, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
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
            this.Label1.Size = new System.Drawing.Size(290, 43);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ការគ្រប់គ្រងប្រភេទសមាជិក";
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
            // Panel5
            // 
            this.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.Controls.Add(this.btnMemberList);
            this.Panel5.Location = new System.Drawing.Point(8, 194);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(1007, 48);
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
            this.btnMemberList.Location = new System.Drawing.Point(4, 7);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(186, 37);
            this.btnMemberList.TabIndex = 1;
            this.btnMemberList.Text = "បញ្ជីប្រភេទសមាជិក";
            this.btnMemberList.UseVisualStyleBackColor = false;
            // 
            // Panel4
            // 
            this.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel4.Controls.Add(this.panel6);
            this.Panel4.Controls.Add(this.dgvMemberType);
            this.Panel4.ForeColor = System.Drawing.Color.White;
            this.Panel4.Location = new System.Drawing.Point(8, 77);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1008, 659);
            this.Panel4.TabIndex = 4;
            // 
            // dgvMemberType
            // 
            this.dgvMemberType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMemberType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberType.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMemberType.Location = new System.Drawing.Point(5, 171);
            this.dgvMemberType.Name = "dgvMemberType";
            this.dgvMemberType.ReadOnly = true;
            this.dgvMemberType.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            this.dgvMemberType.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMemberType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMemberType.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvMemberType.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvMemberType.RowTemplate.Height = 30;
            this.dgvMemberType.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberType.Size = new System.Drawing.Size(1000, 485);
            this.dgvMemberType.TabIndex = 0;
            this.dgvMemberType.DoubleClick += new System.EventHandler(this.dgvMemberType_DoubleClick);
            // 
            // FrmMemberType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMemberType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMemberType";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMemberType_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMemberType_KeyDown);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.PictureBox btnBack;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button btnMemberList;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.DataGridView dgvMemberType;
    }
}
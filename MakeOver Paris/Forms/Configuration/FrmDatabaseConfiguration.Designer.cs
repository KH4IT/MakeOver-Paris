namespace MakeOver_Paris.Forms.Configuration
{
    partial class FrmDatabaseConfiguration
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_configure = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_uid = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_test_connection = new System.Windows.Forms.Button();
            this.panel_login = new System.Windows.Forms.Panel();
            this.cbo_database = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(287, 268);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(133, 41);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_configure
            // 
            this.btn_configure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configure.Location = new System.Drawing.Point(150, 268);
            this.btn_configure.Name = "btn_configure";
            this.btn_configure.Size = new System.Drawing.Size(131, 41);
            this.btn_configure.TabIndex = 6;
            this.btn_configure.Text = "Configure";
            this.btn_configure.UseVisualStyleBackColor = true;
            this.btn_configure.Click += new System.EventHandler(this.btn_configure_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(132, 39);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(270, 26);
            this.txt_pwd.TabIndex = 1;
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uid.Location = new System.Drawing.Point(45, 7);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(60, 20);
            this.lbl_uid.TabIndex = 0;
            this.lbl_uid.Text = "Log in :";
            // 
            // txt_uid
            // 
            this.txt_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uid.Location = new System.Drawing.Point(132, 7);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(270, 26);
            this.txt_uid.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password :";
            // 
            // txt_test_connection
            // 
            this.txt_test_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_test_connection.Location = new System.Drawing.Point(289, 187);
            this.txt_test_connection.Name = "txt_test_connection";
            this.txt_test_connection.Size = new System.Drawing.Size(131, 41);
            this.txt_test_connection.TabIndex = 2;
            this.txt_test_connection.Text = "Test Connection";
            this.txt_test_connection.UseVisualStyleBackColor = true;
            this.txt_test_connection.Click += new System.EventHandler(this.txt_test_connection_Click);
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.txt_pwd);
            this.panel_login.Controls.Add(this.lbl_uid);
            this.panel_login.Controls.Add(this.txt_uid);
            this.panel_login.Controls.Add(this.label4);
            this.panel_login.Location = new System.Drawing.Point(18, 112);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(406, 69);
            this.panel_login.TabIndex = 1;
            // 
            // cbo_database
            // 
            this.cbo_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_database.FormattingEnabled = true;
            this.cbo_database.Location = new System.Drawing.Point(150, 234);
            this.cbo_database.Name = "cbo_database";
            this.cbo_database.Size = new System.Drawing.Size(270, 28);
            this.cbo_database.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Database :";
            // 
            // txt_server
            // 
            this.txt_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server.Location = new System.Drawing.Point(150, 80);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(270, 26);
            this.txt_server.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server :";
            // 
            // FrmDatabaseConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 388);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_configure);
            this.Controls.Add(this.txt_test_connection);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.cbo_database);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmDatabaseConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatabaseConfiguration";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_configure;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lbl_uid;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txt_test_connection;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.ComboBox cbo_database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Label label1;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MakeOver_Paris.DAO;
using MakeOver_Paris.DTO;

namespace MakeOver_Paris.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Panel1.Left = (this.Width - Panel1.Width) / 2;
            Panel1.Top = (this.Height - Panel1.Height) / 2;
            txtPassword.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Username and password are required!!");
            }
            else
            {
                DTO.Staff staff = new StaffDAO().Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (staff != null)
                {
                    UserSession.Session.Staff = staff;
                    if (UserSession.Session.Staff.Stafftype == "admin")
                    {
                        Forms.FrmMain frmMain = new Forms.FrmMain();
                        frmMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("I am Saler");
                    }
                }
                else
                {
                    MessageBox.Show("Username and password are invalid!!");
                }
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
            
        }

    }
}

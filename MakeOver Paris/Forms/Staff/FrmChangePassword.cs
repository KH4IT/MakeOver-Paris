using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Staff
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                UserSession.Session.Staff.Staffname = txtName.Text;
                UserSession.Session.Staff.Staffpassword = txtPassword.Text;
                if (new DAO.StaffDAO().ChangePassword(UserSession.Session.Staff))
                {
                    MessageBox.Show("លោកអ្នកបានកែប្រែបានជោគជ័យហើយ");
                    this.Dispose();
                    UserSession.Session.Staff = null;
                    new Forms.FrmLogin().Show();
                }
                else
                {
                    MessageBox.Show("លោកអ្នកបានកែប្រែមិនបានជោគជ័យហើយទេ");
                }
            }
            else
            {
                MessageBox.Show("លេខសំងាត់របស់លោកអ្នកមិនត្រូវគ្នាទេ");
            }
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtName.Text = UserSession.Session.Staff.Staffname;
            txtPassword.Text = UserSession.Session.Staff.Staffpassword;
            txtConfirmPassword.Text = UserSession.Session.Staff.Staffpassword;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}

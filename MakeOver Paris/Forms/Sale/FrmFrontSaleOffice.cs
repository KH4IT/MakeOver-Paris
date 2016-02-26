using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Sale
{
    public partial class FrmFrontSaleOffice : Form
    {
        public FrmFrontSaleOffice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.Session.Staff.Staffname == "admin")
            {
                Forms.FrmMain frmMain = new Forms.FrmMain();
                frmMain.Show();
                this.Close();
            }
            else
            {
                UserSession.Session.Staff = null;
                Forms.FrmLogin form = new Forms.FrmLogin();
                form.Show();
                this.Close();
            }
        }



    }
}

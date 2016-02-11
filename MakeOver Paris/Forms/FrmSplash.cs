using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MakeOver_Paris.Forms
{
    public partial class FrmSplash : Form
    {

        public FrmSplash()
        {
           
            InitializeComponent();
           
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            this.pnlSplashScreen.Left = (this.Width - this.pnlSplashScreen.Width) / 2 ;
            this.pnlSplashScreen.Top = (this.Height - this.pnlSplashScreen.Height) / 2 ;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Forms.FrmLogin frmLogin = new Forms.FrmLogin();
            frmLogin.Visible = true;
            this.Visible = false;
            timer1.Stop();
            
        }

    }
}

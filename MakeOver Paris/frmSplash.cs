﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
               this.pnlSplashScreen.Left = (this.Width - this.pnlSplashScreen.Width) / 2 ;
               this.pnlSplashScreen.Top = (this.Height - this.pnlSplashScreen.Height) / 2 ;
        }

    }
}
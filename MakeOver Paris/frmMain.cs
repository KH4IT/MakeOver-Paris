﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MakeOver_Paris
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            
            InitializeComponent();
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.pnMain.Left = (this.Width - this.pnMain.Width) / 2;
            this.pnMain.Top = (this.Height - this.pnMain.Height) / 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
           
            frmParent parent = new frmParent();
            parent.Show();
           
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            frmParent parent = new frmParent();
            parent.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmParent parent = new frmParent();
                parent.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmParent parent = new frmParent();
                parent.Show();
            }
        }
    }
}

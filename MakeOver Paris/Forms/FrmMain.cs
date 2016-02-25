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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            
            InitializeComponent();
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.pnMain.Left = (this.Width - this.pnMain.Width) / 2;
            this.pnMain.Top = (this.Height - this.pnMain.Height) / 2;
            lblDateAndTime.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss tt");
            lblUsername.Text = "Welcome to, " + UserSession.Session.Staff.Staffname;
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            UserSession.Session.Staff = null;
            Forms.FrmLogin form = new Forms.FrmLogin();
            form.Show();
            this.Close();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Forms.Member.FrmMembers frmMember = new Forms.Member.FrmMembers();
            frmMember.Show();
            this.Close();
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            Forms.Staff.FrmStaff frmMember = new Forms.Staff.FrmStaff();
            frmMember.Show();
            this.Close();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Forms.Category.FrmCategory frmCategory = new Forms.Category.FrmCategory();
            frmCategory.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Forms.Setting.FrmSetting frmSetting = new Forms.Setting.FrmSetting();
            frmSetting.Show();
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Forms.Product.FrmProduct frmProduct = new Forms.Product.FrmProduct();
            frmProduct.Show();
            this.Close();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Forms.Transaction.frmTransaction frmTransaction = new Forms.Transaction.frmTransaction();
            frmTransaction.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Forms.Transaction.frmTransaction frmTransaction = new Forms.Transaction.frmTransaction();
                frmTransaction.Show();
                this.Close();
            }
        }
    }
}

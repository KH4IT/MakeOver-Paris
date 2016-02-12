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
            lblDateAndTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
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

        private void Label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnSale_Click(object sender, EventArgs e)
        {
            Forms.Sale.FrmSale frmSale = new Forms.Sale.FrmSale();
            frmSale.Show();
            this.Close();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Forms.Transaction.frmTransaction frmTransaction = new Forms.Transaction.frmTransaction();
            frmTransaction.Show();
            this.Close();
        }
    }
}

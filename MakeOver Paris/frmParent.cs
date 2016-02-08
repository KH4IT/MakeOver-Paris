using System;
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
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeOver_Paris.DAO.InvoiceDAO dao = new MakeOver_Paris.DAO.InvoiceDAO();
            MakeOver_Paris.DTO.Invoice inv = new MakeOver_Paris.DTO.Invoice();
            System.Collections.ArrayList arr = new System.Collections.ArrayList();

            for (int i = 0; i < 3; i++)
            {
                MakeOver_Paris.DTO.InvoiceDetail detail = new MakeOver_Paris.DTO.InvoiceDetail();
                MakeOver_Paris.DTO.Product p = new MakeOver_Paris.DTO.Product();
                p.Productid = 20+i;
                detail.Product = p;
                detail.Pricein = 100;
                detail.Priceout = 1000;
                detail.Quantity = 11;
                arr.Add(detail);
            }

            MakeOver_Paris.DTO.Member m = new DTO.Member();
            m.Memberid = 1;

            DTO.Staff s = new DTO.Staff();
            s.Staffid = 2;

            inv.Member = m;
            inv.Staff = s;
            inv.InvoiceDetail = arr;

            dao.addInvoice(inv);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmParent parent = new frmParent();
            parent.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            changePanelForm(frm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            changePanelForm(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMember frm = new frmMember();
            foreach (Form child in this.MdiChildren)
                if (child.Name == frm.Name)
                {
                    child.BringToFront();
                    return;
                }
            frm.MdiParent = this;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            frmStaff frmStaffs = new frmStaff();
            changePanelForm(frmStaffs);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSetting frm = new frmSetting();
            foreach (Form child in this.MdiChildren)
                if (child.Name == frm.Name)
                {
                    child.BringToFront();
                    return;
                }
            frm.MdiParent = this;
            frm.Show();
        }

        public void changePanelForm(Form frm)
        {
            panel4.Dispose();
            foreach (Form child in this.MdiChildren)
                if (child.Name == frm.Name)
                {
                    child.BringToFront();
                    return;
                }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmParent parent = new frmParent();
            parent.Show();
            this.Dispose();
        }

        private void btnManageCourse_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            changePanelForm(frm);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmMember frm = new frmMember();
            changePanelForm(frm);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmStaff frmStaffs = new frmStaff();
            changePanelForm(frmStaffs);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            changePanelForm(frm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmSetting frm = new frmSetting();
            changePanelForm(frm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale();
            changePanelForm(frm);
        }
       
    }
}

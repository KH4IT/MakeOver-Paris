using System;
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
using System.Collections;

namespace MakeOver_Paris
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ArrayList categories = new CategoryDAO().GetAllCategories();
            //addToGrid(categories);
            
            
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
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMember frm = new frmMember();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSetting frm = new frmSetting();
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        /*
         * Enter key event when adding product 
         */

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        /*
         * Add data to gridview
         */

        private void addToGrid(ArrayList categories)
        {

            for (int i = 0; i < categories.Count; i++)
            {
                Category category = (Category)categories[i];
                categoryGV.Rows.Add(category.Categoryid, category.Categoryname);
            }
            
         
        }

       
       
    }
}

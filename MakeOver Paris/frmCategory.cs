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
            if (txtName.Text == "")
            {
                MessageBox.Show("Can not empty");
            }
            else
            {
                Category category = new Category(txtName.Text);
                if (new CategoryDAO().AddCategory(category))
                {
                    txtName.Clear();
                }
                else
                {
                    MessageBox.Show("Transaction fail!!!");
                }
            }
        }

        /*
         * Enter key event when adding product 
         */

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnSave_Click(sender, e);
            }
        }

        /*
         * Add data to gridview
         */

        private void addToGrid()
        {
          /*  int row = checkInGrid(category.Categoryid);
            if (row == -1)
            {
                categoryGV.Rows.Add(categoryGV.RowCount + 1, category.Categoryid, category.Categoryname);
            }
            else
            {
                categoryGV.Rows[row].Cells[2].Value = int.Parse(categoryGV.Rows[row].Cells[2].Value.ToString()) + 1;
            }
           * */
        }

        private int checkInGrid(int productid)
        {
            int row = -1;
            for (int i = 0; i < categoryGV.RowCount; i++)
            {
                if (categoryGV.Rows[i].Cells[6].Value.ToString() == (productid + ""))
                {
                    row = i;
                    break;
                }
            }
            return row;
        }
       
    }
}

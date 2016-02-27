using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MakeOver_Paris.DAO;
using MakeOver_Paris.DTO;


namespace MakeOver_Paris.Forms.Category
{
    public partial class FrmCategory : Form
    {
        int id;
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.Category category = new DTO.Category(txtName.Text);
                    if (new CategoryDAO().AddCategory(category))
                    {
                        txtName.Clear();
                        dgvCategory.DataSource = new DAO.CategoryDAO().GetAllCategories().Tables[0];
                        id = 0;
                    }
                    else
                    {
                        MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                    }
                }
            }
            else
            {
                DTO.Category cat = new DTO.Category(id, txtName.Text);
                if (new CategoryDAO().UdateCategory(cat))
                {
                    txtName.Clear();
                    dgvCategory.DataSource = new DAO.CategoryDAO().GetAllCategories().Tables[0];
                    id = 0;
                    btnDelete.Enabled = false;
                }
                else
                {

                }
            }
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            DataSet dataSet = new CategoryDAO().GetAllCategories();
            dgvCategory.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|ឈ្មោះ",dgvCategory);
            Utility.setGridHeaderWidth("100",dgvCategory);
        }

 

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = System.Convert.ToInt32(dgvCategory.CurrentRow.Cells[0].Value);
                txtName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void deleteAction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("តើអ្នកពិតជាចង់លុបទិន្នន័យនេះមែនទេ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new CategoryDAO().DeleteCategory(id))
                {
                    txtName.Clear();
                    btnDelete.Enabled = false;
                    dgvCategory.DataSource = new DAO.CategoryDAO().GetAllCategories().Tables[0];
                    id = 0;
                }
                else
                {
                    MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                }
            }
            else
            {
                // user clicked no
            }
            
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCategory.DataSource;
            bs.Filter = "categoryname LIKE '%" + txtSearch.Text + "%'";
            dgvCategory.DataSource = bs;
        }

        private void FrmCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }
                
        }

      

    }
}

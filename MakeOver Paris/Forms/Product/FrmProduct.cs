using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Product
{
    public partial class FrmProduct : Form
    {
        int id;

        public FrmProduct()
        {
            InitializeComponent();
            dgvProduct.DataSource = new DAO.ProductDAO().getAllProductDS().Tables[0];

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
                if (    txtBarcode.Text.Trim() == ""    || txtProductCode.Text.Trim() == ""
                    ||  txtName.Text.Trim()  == ""     // || cboCategory.SelectedValue == "" 
                    ||  txtPriceIn.Text.Trim() == ""    || txtPriceOut.Text.Trim() == ""
                )
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DAO.ProductDAO productDAO = new DAO.ProductDAO();
                    if (productDAO.checkProduct(txtProductCode.Text))
                    {
                        MessageBox.Show("លេខកូដទំនិញរបស់លោកអ្នកមានរួចហើយ សូមបញ្ចូលលេខកូដទំនិញផ្សេង");
                        return;
                    }
                    DTO.Staff staff = new DTO.Staff();
                    staff.Staffid = UserSession.Session.Staff.Staffid;// Data.user.Staffid;
                    DTO.Category cate = new DTO.Category();
                    cate.Categoryid = (int)cboCategory.SelectedValue;
                    DTO.Product product = new DTO.Product(0,txtProductCode.Text.Trim(), txtBarcode.Text.Trim(), txtName.Text.Trim(), txtDescription.Text.Trim(),
                    Decimal.Parse(txtPriceIn.Text.Trim()), Decimal.Parse(txtPriceOut.Text.Trim()), txtRemark.Text.Trim(), staff, staff, cate);
                    if (new DAO.ProductDAO().addProduct(product))
                    {
                        ClearForm();
                        dgvProduct.DataSource = new DAO.ProductDAO().getAllProductDS().Tables[0];
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

                if (txtBarcode.Text.Trim() == "" || txtProductCode.Text.Trim() == ""
                   || txtName.Text.Trim() == ""     // || cboCategory.SelectedValue == ""
                   || txtPriceIn.Text.Trim() == "" || txtPriceOut.Text.Trim() == ""
               )
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.Staff staff = new DTO.Staff();
                    staff.Staffid = UserSession.Session.Staff.Staffid;// Data.user.Staffid;
                    DTO.Category cate = new DTO.Category();
                    cate.Categoryid = (int)cboCategory.SelectedValue;
                    DTO.Product product = new DTO.Product(id, txtProductCode.Text.Trim(), txtBarcode.Text.Trim(), txtName.Text.Trim(), txtDescription.Text.Trim(),
                       Decimal.Parse(txtPriceIn.Text.Trim()), Decimal.Parse(txtPriceOut.Text.Trim()), txtRemark.Text.Trim(), staff, staff, cate);
                    if (new DAO.ProductDAO().updateProduct(product))
                    {
                        ClearForm();
                        dgvProduct.DataSource = new DAO.ProductDAO().getAllProductDS().Tables[0];
                        id = 0;
                        delete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtProductCode.Clear();
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtPriceIn.Clear();
            txtPriceOut.Clear();
            txtRemark.Clear();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                delete.Visible = true;
                id = System.Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value);
                txtProductCode.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                txtBarcode.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
                txtName.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
                txtDescription.Text = dgvProduct.CurrentRow.Cells[14].Value.ToString();
                txtPriceIn.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();
                txtPriceOut.Text = dgvProduct.CurrentRow.Cells[7].Value.ToString();
                txtRemark.Text = dgvProduct.CurrentRow.Cells[15].Value.ToString();
                cboCategory.SelectedValue = dgvProduct.CurrentRow.Cells[13].Value.ToString();
                
            }
            catch (Exception ex)
            {
         
                Console.Write(ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvProduct.DataSource;
            bs.Filter = "productname LIKE '%" + txtSearch.Text + "%' ";
            dgvProduct.DataSource = bs;
        }

        private void txtPriceIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtPriceOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtReturnQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            txtBarcode.Focus();
            // GET CATEGORIES
            DataSet da = new DAO.CategoryDAO().GetAllCategories();
            cboCategory.DataSource = da.Tables[0];
            cboCategory.DisplayMember = "categoryname";
            cboCategory.ValueMember = "categoryid";
            // GET STORE
            //DataSet d = new DAO.StoreDAO().GetAllStores();
            //cbBranch.DataSource = d.Tables[0];
            //cbBranch.DisplayMember = "storename";
            //cbBranch.ValueMember = "storeid";
            //CUSTOM GRID
            Utility.setGridHeaderText("ល.រ|លេខទំនិញ|បារកូដ|ឈ្មោះ|បរិមាណ|សាខា|តម្លៃទិញចូល|តម្លៃលក់ចេញ|បរិមាណប្តូរវិញ|បង្កើតដោយ|កែប្រែដោយ|បង្កើតថ្ងៃ|កែប្រែថ្ងៃ|ប្រភេទ|បរិយាយ|កំណត់សំគាល់", dgvProduct);
            Utility.setGridHeaderWidth("30", dgvProduct);
            //dgvProduct.Columns[10].Visible = false;
            //dgvProduct.Columns[11].Visible = false;
            //dgvProduct.Columns[12].Visible = false;
            delete.Visible = false;

        }

        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("តើអ្នកពិតជាចង់លុបទិន្នន័យនេះមែនទេ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new DAO.ProductDAO().deleteProduct(id))
                {
                    ClearForm();
                    id = 0;
                    delete.Visible = false;
                    dgvProduct.DataSource = new DAO.ProductDAO().getAllProductDS().Tables[0];
                    
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
    }
}

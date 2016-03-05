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

namespace MakeOver_Paris.Forms.Product
{
    public partial class ProductInStock : Form
    {
        private int id;
        public ProductInStock()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void ProductInStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (txtQuantity.Text == "" || txtQuantityReturn.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.StoreProduct storeProduct = new DTO.StoreProduct((int)cbStock.SelectedValue, (int)cbProduct.SelectedValue, System.Convert.ToDecimal(txtQuantity.Text+0), System.Convert.ToDecimal(txtQuantityReturn.Text));
                    if (new StoreProductDAO().AddStoreProduct(storeProduct))
                    {
                        txtQuantity.Clear();
                        txtQuantityReturn.Clear();
                        dgvStoreProduct.DataSource = new DAO.StoreProductDAO().GetAllStoreProducts().Tables[0];
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
                DTO.StoreProduct storeProduct = new DTO.StoreProduct((int)cbStock.SelectedValue, (int)cbProduct.SelectedValue, System.Convert.ToDecimal(txtQuantity.Text), System.Convert.ToDecimal(txtQuantityReturn.Text));
                if (new StoreProductDAO().UdateStoreProduct(storeProduct))
                {
                    txtQuantity.Clear();
                    txtQuantityReturn.Clear();
                    dgvStoreProduct.DataSource = new DAO.StoreProductDAO().GetAllStoreProducts().Tables[0];
                    id = 0;
                    delete.Visible = false;
                }
                else
                {

                }
            }
        }

        private void ProductInStock_Load(object sender, EventArgs e)
        {
            DataSet d = new DAO.StoreDAO().GetAllStores();
            cbStock.DataSource = d.Tables[0];
            cbStock.DisplayMember = "storename";
            cbStock.ValueMember = "storeid";
            DataSet da = new DAO.ProductDAO().getAllProductDS();
            cbProduct.DataSource = da.Tables[0];
            cbProduct.DisplayMember = "productname";
            cbProduct.ValueMember = "productid";

            DataSet dataSet = new StoreProductDAO().GetAllStoreProducts();
            dgvStoreProduct.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ឈ្មោះស្តុក|ឈ្មោះទំនិញ|បរិមាណ|បរិមាណប្តូវិញ", dgvStoreProduct);
            Utility.setGridHeaderWidth("200|300", dgvStoreProduct);

        }

        private void dgvStoreProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //id = System.Convert.ToInt32(dgvStoreProduct.CurrentRow.Cells[0].Value);
                cbStock.Text = dgvStoreProduct.CurrentRow.Cells[0].Value.ToString();
                cbProduct.Text = dgvStoreProduct.CurrentRow.Cells[1].Value.ToString();
                txtQuantity.Text = dgvStoreProduct.CurrentRow.Cells[2].Value.ToString();
                txtQuantityReturn.Text = dgvStoreProduct.CurrentRow.Cells[3].Value.ToString();
                if (txtQuantity.Text != "")
                    delete.Visible = true;
                else
                    delete.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("តើអ្នកពិតជាចង់លុបទិន្នន័យនេះមែនទេ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new StoreProductDAO().DeleteStoreProduct((int)cbStock.SelectedValue, (int)cbProduct.SelectedValue))
                {
                    txtQuantity.Clear();
                    txtQuantityReturn.Clear();
                    delete.Visible = false;
                    dgvStoreProduct.DataSource = new DAO.StoreProductDAO().GetAllStoreProducts().Tables[0];
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtQuantityReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvStoreProduct.DataSource;
            bs.Filter = "productname LIKE '%" + txtSearch.Text + "%'";
            dgvStoreProduct.DataSource = bs;
        }
    }
}

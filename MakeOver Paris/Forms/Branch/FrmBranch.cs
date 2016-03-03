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

namespace MakeOver_Paris.Forms.Branch
{
    public partial class FrmBranch : Form
    {
        private int id;
        public FrmBranch()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void FrmBranch_KeyDown(object sender, KeyEventArgs e)
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
                if (txtStockName.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.Store store = new DTO.Store(txtStockName.Text, txtAddress.Text);
                    //MessageBox.Show(store.StoreAddress);
                    if (new StoreDAO().AddStore(store))
                    {
                        txtStockName.Clear();
                        txtAddress.Clear();
                        dgvBranch.DataSource = new DAO.StoreDAO().GetAllStores().Tables[0];
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
                DTO.Store s = new DTO.Store(id, txtStockName.Text, txtAddress.Text);
                if (new StoreDAO().UpdateStore(s))
                {
                    txtStockName.Clear();
                    txtAddress.Clear();
                    dgvBranch.DataSource = new DAO.StoreDAO().GetAllStores().Tables[0];
                    id = 0;
                    delete.Visible = false;
                }
                else
                {
                    MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                }
            }
        }

        private void FrmBranch_Load(object sender, EventArgs e)
        {
            txtStockName.Focus();
            DataSet dataSet = new StoreDAO().GetAllStores();
            dgvBranch.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|ឈ្មោះស្តុក|អាសយដ្ឋាន", dgvBranch);
            Utility.setGridHeaderWidth("100", dgvBranch);
        }

        private void dgvBranch_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = System.Convert.ToInt32(dgvBranch.CurrentRow.Cells[0].Value);
                txtStockName.Text = dgvBranch.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = dgvBranch.CurrentRow.Cells[2].Value.ToString();
                delete.Visible = true;
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
                if (new StoreDAO().DeleteStore(id))
                {
                    txtStockName.Clear();
                    txtAddress.Clear();
                    delete.Visible = false;
                    dgvBranch.DataSource = new DAO.StoreDAO().GetAllStores().Tables[0];
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
            bs.DataSource = dgvBranch.DataSource;
            bs.Filter = "storename LIKE '%" + txtSearch.Text + "%'";
            dgvBranch.DataSource = bs;
        }
    }
}

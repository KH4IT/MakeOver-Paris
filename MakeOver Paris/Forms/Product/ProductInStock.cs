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
    public partial class ProductInStock : Form
    {
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

        }


    }
}

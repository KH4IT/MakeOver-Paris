using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Sale
{
    public partial class FrmExchangeProductNew : Form
    {
        public FrmExchangeProductNew()
        {
            InitializeComponent();
        }

        private void txtInvoiceCode_Leave(object sender, EventArgs e)
        {
            try
            {
                cboOldProduct.Items.Clear();
                //List Product from Invoice to Old Combo
                int invoiceid = int.Parse(txtInvoiceCode.Text.Substring(2));

                DTO.Invoice invoice = new DAO.InvoiceDAO().getInvoice(invoiceid);
                for (int i = 0; i < invoice.InvoiceDetail.Count; i++)
                {
                    DTO.Product product = ((DTO.InvoiceDetail)invoice.InvoiceDetail[i]).Product;
                    Item item = new Item(product.Productname, product.Productid);
                    cboOldProduct.Items.Add(item);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("សូមបំពេញពត័មានឲ្យបានត្រឺមត្រូវ");
            }

        }

        private void cboOldProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List Product with same priceout to New Combo
            int productid = ((Item)cboOldProduct.SelectedItem).Value;
            DataSet ds = new DAO.ProductDAO().getSamePriceProduct(productid);
            cboNewProduct.DataSource = ds.Tables[0];
            cboNewProduct.DisplayMember = "productname";
            cboNewProduct.ValueMember = "productid";

        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            // Check New Product Quantity
        }

        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text!=""){
                new DAO.InvoiceDAO().exchangeProduct(int.Parse(txtInvoiceCode.Text.Substring(9)), ((Item)cboOldProduct.SelectedItem).Value, (int)cboNewProduct.SelectedValue, decimal.Parse(txtQuantity.Text));
                this.Dispose();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtInvoiceCode_Leave_1(object sender, EventArgs e)
        {
            txtInvoiceCode_Leave(sender, e);
        }

        private void cboOldProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboOldProduct_SelectedIndexChanged(sender, e);
        }
    }
}

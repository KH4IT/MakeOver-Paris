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
    public partial class FrmExchageProduct : Form
    {
        public FrmExchageProduct()
        {
            InitializeComponent();
        }

        private void txtInvoiceCode_Leave(object sender, EventArgs e)
        {
            cboOldProduct.Items.Clear();
            //List Product from Invoice to Old Combo
            int invoiceid = int.Parse(txtInvoiceCode.Text.Substring(9));
            
            DTO.Invoice invoice = new DAO.InvoiceDAO().getInvoice(invoiceid);
            for (int i = 0; i < invoice.InvoiceDetail.Count; i++)
            {
                DTO.Product product = ((DTO.InvoiceDetail)invoice.InvoiceDetail[i]).Product;
                Item item = new Item(product.Productname, product.Productid);
                cboOldProduct.Items.Add(item);
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
            new DAO.InvoiceDAO().exchangeProduct(int.Parse(txtInvoiceCode.Text.Substring(9)), ((Item)cboOldProduct.SelectedItem).Value, (int)cboNewProduct.SelectedValue, decimal.Parse(txtQuantity.Text));

        }
    }
}

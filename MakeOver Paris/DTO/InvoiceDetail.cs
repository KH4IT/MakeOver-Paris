using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DTO
{
    class InvoiceDetail
    {
        //private int invoiceid;
        //private int productid;
        private Invoice invoice;

        internal Invoice Invoice
        {
            get { return invoice; }
            set { invoice = value; }
        }
        private Product product;

        internal Product Product
        {
            get { return product; }
            set { product = value; }
        }
        private decimal quantity;

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private decimal pricein;

        public decimal Pricein
        {
            get { return pricein; }
            set { pricein = value; }
        }
        private decimal priceout;

        public decimal Priceout
        {
            get { return priceout; }
            set { priceout = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DTO
{
    class Product
    {
        private int productid;

        public int Productid
        {
            get { return productid; }
            set { productid = value; }
        }
        private String productcode;

        public String Productcode
        {
            get { return productcode; }
            set { productcode = value; }
        }
        private String barcode;

        public String Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        private String productname;

        public String Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        private decimal quantity;

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
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
        private decimal returnquantity;

        public decimal Returnquantity
        {
            get { return returnquantity; }
            set { returnquantity = value; }
        }
        private String remark;

        public String Remark1
        {
            get { return remark; }
            set { remark = value; }
        }

        public String Remark
        {
            get { return Remark1; }
            set { Remark1 = value; }
        }
        private DateTime createddate;

        public DateTime Createddate
        {
            get { return createddate; }
            set { createddate = value; }
        }
        private Staff createdby;

        internal Staff Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private DateTime updateddate;

        public DateTime Updateddate
        {
            get { return updateddate; }
            set { updateddate = value; }
        }
        private Staff updatedby;

        internal Staff Updatedby
        {
            get { return updatedby; }
            set { updatedby = value; }
        }
        private Category category;

        internal Category Category
        {
            get { return category; }
            set { category = value; }
        }

    }
}

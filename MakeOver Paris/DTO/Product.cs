using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{

    class Product
    {
        private int productid;
        private String productcode;
        private String barcode;
        private String productname;
        private decimal quantity;
        private String description;
        private decimal pricein;
        private decimal priceout;
        private decimal returnquantity;
        private String remark;
        private DateTime createddate;
        private Staff createdby;
        private DateTime updateddate;
        private Staff updatedby;
        private Category category;

        public int Productid
        {
            get { return productid; }
            set { productid = value; }
        }

        public String Productcode
        {
            get { return productcode; }
            set { productcode = value; }
        }

        public String Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public String Productname
        {
            get { return productname; }
            set { productname = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Pricein
        {
            get { return pricein; }
            set { pricein = value; }
        }

        public decimal Priceout
        {
            get { return priceout; }
            set { priceout = value; }
        }

        public decimal Returnquantity
        {
            get { return returnquantity; }
            set { returnquantity = value; }
        }

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

        public DateTime Createddate
        {
            get { return createddate; }
            set { createddate = value; }
        }
        internal Staff Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }

        public DateTime Updateddate
        {
            get { return updateddate; }
            set { updateddate = value; }
        }

        internal Staff Updatedby
        {
            get { return updatedby; }
            set { updatedby = value; }
        }

        internal Category Category
        {
            get { return category; }
            set { category = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{
    class StoreProduct
    {
        private int storeId;

        public int StoreId
        {
            get { return storeId; }
            set { storeId = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        private decimal quantity;

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private decimal returnQuantity;

        public decimal ReturnQuantity
        {
            get { return returnQuantity; }
            set { returnQuantity = value; }
        }
        public StoreProduct(int storeId, int productId, decimal quantity, decimal returnQuantity)
        {
            this.storeId = storeId;
            this.productId = productId;
            this.quantity = quantity;
            this.returnQuantity = returnQuantity;
        }
    }
}

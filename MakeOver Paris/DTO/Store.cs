using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{
    class Store
    {

        private int stroreId;

        public int StroreId
        {
            get { return stroreId; }
            set { stroreId = value; }
        }
        private string stroreName;

        public string StroreName
        {
            get { return stroreName; }
            set { stroreName = value; }
        }
        private string storeAddress;

        public string StoreAddress
        {
            get { return storeAddress; }
            set { storeAddress = value; }
        }

        public Store(string storeName, string storeAddress)
        {
            this.stroreName = storeName;
            this.storeAddress = storeAddress;
        }

        public Store(int storeId, string storeName, string storeAddress)
        {
            this.stroreId = storeId;
            this.stroreName = storeName;
            this.storeAddress = storeAddress;
        }
    }
}

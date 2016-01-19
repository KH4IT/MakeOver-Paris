using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DTO
{
    class Category
    {

        private int categoryid;

        public int Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }

        private String categoryname;

        public String Categoryname
        {
            get { return categoryname; }
            set { categoryname = value; }
        }

        

    }
}

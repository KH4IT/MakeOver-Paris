using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{
    class Category
    {
        private int categoryid;
        private String categoryname;

        public Category()
        {

        }

        public Category(String categoryName)
        {
            this.categoryname = categoryName;
        }
        public int Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }

        public String Categoryname
        {
            get { return categoryname; }
            set { categoryname = value; }
        }

    }
}

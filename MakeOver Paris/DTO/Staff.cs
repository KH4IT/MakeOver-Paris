using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{
    class Staff
    {
        private int staffid;

        public int Staffid
        {
            get { return staffid; }
            set { staffid = value; }
        }

        private String staffname;

        public String Staffname
        {
            get { return staffname; }
            set { staffname = value; }
        }

        private String staffpassword;

        public String Staffpassword
        {
            get { return staffpassword; }
            set { staffpassword = value; }
        }

        private String stafftype;

        public String Stafftype
        {
            get { return stafftype; }
            set { stafftype = value; }
        }

        private DateTime lastlogin;

        public DateTime Lastlogin
        {
            get { return lastlogin; }
            set { lastlogin = value; }
        }

        private decimal commisionrate;

        public decimal Commisionrate
        {
            get { return commisionrate; }
            set { commisionrate = value; }
        }
        public Staff() { }

        public Staff(int staffid, string staffname, string staffpassword, string stafftype, DateTime lastlogin, decimal comisionrate)
        {
            this.staffid = staffid;
            this.staffname = staffname;
            this.staffpassword = staffpassword;
            this.stafftype = stafftype;
            this.lastlogin = lastlogin;
            this.commisionrate = comisionrate;
        }


    }
}

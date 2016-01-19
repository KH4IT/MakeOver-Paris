using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DTO
{
    class Member
    {

        private int memberid;

        public int Memberid
        {
            get { return memberid; }
            set { memberid = value; }
        }
        private String membername;

        public String Membername
        {
            get { return membername; }
            set { membername = value; }
        }
        private String phonenumber;

        public String Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
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
        private decimal discountrate;

        public decimal Discountrate
        {
            get { return discountrate; }
            set { discountrate = value; }
        }

    }
}

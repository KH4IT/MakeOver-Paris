using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{
    class Invoice
    {
        private int invoiceid;

        public int Invoiceid
        {
            get { return invoiceid; }
            set { invoiceid = value; }
        }
        private DateTime invoicedate;

        public DateTime Invoicedate
        {
            get { return invoicedate; }
            set { invoicedate = value; }
        }
        private Staff staff;

        internal Staff Staff
        {
            get { return staff; }
            set { staff = value; }
        }
        private Member member;

        internal Member Member
        {
            get { return member; }
            set { member = value; }
        }
        private String remark;

        public String Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        private decimal discount;

        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private System.Collections.ArrayList invoiceDetail;

        public System.Collections.ArrayList InvoiceDetail
        {
            get { return invoiceDetail; }
            set { invoiceDetail = value; }
        }


    }
}

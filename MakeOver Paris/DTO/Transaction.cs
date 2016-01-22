using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{
    class Transaction
    {
        private int transactionid;

        public int Transactionid
        {
            get { return transactionid; }
            set { transactionid = value; }
        }
        private DateTime transactiondate;

        public DateTime Transactiondate
        {
            get { return transactiondate; }
            set { transactiondate = value; }
        }
        private decimal incomeamount;

        public decimal Incomeamount
        {
            get { return incomeamount; }
            set { incomeamount = value; }
        }
        private decimal expenseamount;

        public decimal Expenseamount
        {
            get { return expenseamount; }
            set { expenseamount = value; }
        }
        private Staff createdby;

        internal Staff Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private String remark;

        public String Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        public Transaction() { }
        public Transaction(int transactionid, DateTime transactiondate, decimal incomeamount, decimal expenseamount, Staff createdby, string remark)
        {
            this.transactionid = transactionid;
            this.transactiondate = transactiondate;
            this.incomeamount = incomeamount;
            this.expenseamount = expenseamount;
            this.createdby = createdby;
            this.remark = remark;
        }

    }
}

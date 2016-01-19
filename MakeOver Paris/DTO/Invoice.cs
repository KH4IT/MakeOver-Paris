using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DTO
{
    class Invoice
    {
        private int invoiceid;
        private DateTime invoicedate;
        private Staff staff;
        private Member member;
        private String remark;
        private decimal discount;
    }
}

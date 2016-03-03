using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{
    class MemberType
    {
        private int memberTypeId;

        public int MemberTypeId
        {
            get { return memberTypeId; }
            set { memberTypeId = value; }
        }
        private string memberTypeName;

        public string MemberTypeName
        {
            get { return memberTypeName; }
            set { memberTypeName = value; }
        }


        public MemberType(string memberTypeName)
        {
            this.memberTypeName = memberTypeName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;

namespace MakeOver_Paris
{
    class UserSession
    {
        private static UserSession session = null;
        private Staff staff;

        private UserSession(){}

        public static UserSession Session
        {
            get
            {
                if (session == null)
                {
                    session = new UserSession();
                }
                return session;
            }
        }

        public Staff Staff
        {
            get { return staff; }
            set { staff = value; }
        }

    }
}

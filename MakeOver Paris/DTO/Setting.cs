using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris.DTO
{
    class Setting
    {
        private int settingid;

        public int Settingid
        {
            get { return settingid; }
            set { settingid = value; }
        }
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        private String value;

        public String Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

    }
}

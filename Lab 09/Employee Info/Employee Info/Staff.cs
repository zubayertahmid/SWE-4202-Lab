using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info
{
    internal class Staff
    {
        public string code;
        public string name;

        public Staff(string cde, string nme)
        {
            code = cde;
            name = nme;
        }

        public Staff()
        {

        }

        public virtual string identifyMe()
        {
            return "I am a Staff";
        }
    }
}

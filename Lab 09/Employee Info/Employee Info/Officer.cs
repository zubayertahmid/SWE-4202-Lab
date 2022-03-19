using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info
{
    internal class Officer:Staff
    {
        public string grade;

        public Officer(string grade, string name, string code)
        {
            this.grade = grade;
        }

        public override string identifyMe()
        {
            return "I am an Officer";
        }
    }
}

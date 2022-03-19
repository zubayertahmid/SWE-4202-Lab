using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info
{
    internal class Teacher:Staff
    {
        public string subject;
        public string publication;

        public Teacher(string code, string name, string subject, string publication)
        {
            this.subject = subject;
            this.publication = publication;
        }

        public override string identifyMe()
        {
            return "I am a Teacher";
        }
    }
}

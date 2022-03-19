using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info
{
    internal class Regular:Typist
    {
        public Regular(string name, string code, string speed)
        {
            this.name = name;
            this.code = code;
            this.speed = speed;
        }


        public override string identifyMe()
        {
            return "I am a Regular Typist";
        }
    }
}

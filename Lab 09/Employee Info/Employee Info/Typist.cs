using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info
{
    internal class Typist:Staff
    {
        public string speed;

        public Typist(string speed, string name, string code)
        {
            this.speed = speed; 
            this.name = name;
            this.code = code; 
        }

        public Typist()
        {

        }

        public override string identifyMe()
        {
            return "I am a Typist"; 
        }
    }
}

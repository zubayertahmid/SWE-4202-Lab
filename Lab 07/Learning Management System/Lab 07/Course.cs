using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Course
    {
        public string name;
        
        public string semester;

        public Course(string name, string semester)
        {
            this.name = name;
            
            this.semester = semester;
        }

        public Course()
        {

        }
    }
}

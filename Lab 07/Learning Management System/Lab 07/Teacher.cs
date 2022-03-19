using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Teacher : Course
    {
        public string designation;
        public string course;
        public string credit;

        public Teacher(string name, string course, string semester, string designation, string credit)
        {
            this.name = name;
            this.course = course;
            this.semester = semester;
            this.designation = designation;
            this.credit = credit;

        }

        public Teacher()
        {

        }
    }
}

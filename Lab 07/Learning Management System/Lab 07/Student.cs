using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Student : Course
    {
        public string course;

        public Student(string name, string course, string semester)
        {
            this.name = name;
            this.course = course;
            this.semester = semester;
        }

        public Student()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final_200042136
{
    public class Student
    {
        public string id;
        public string name;
        public string attendance;
        public string quiz1marks;
        public string quiz2marks;
        public string quiz3marks;
        public string quiz4marks;
        public string mid;
        public string final;
        public string viva;
        public string percentage;
        public string Total;
        public string quizTotalMarks;
        public string grade;

        public bool ifStudent(string ID)
        {
            if(ID == id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string showID()
        {
            return id;
        }

        public string showName()
        {
            return name;
        }

        public string showPercentage()
        {
            return percentage;
        }

        public string showGrade()
        {
            return grade;
        }

    }
}

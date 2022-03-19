using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week_9
{
    public class Employee
    {
        public string employeeID;
        public string name;
        public string designation;
        public string contact;
        public string salary;
        public DateTime dateofjoin;

        public void employee(string employeeID, string name, string designation, string contact, string salary, DateTime dateofjoin)
        {
            this.employeeID = employeeID;
            this.name = name;
            this.designation = designation;
            this.contact = contact;
            this.salary = salary;
            this.dateofjoin = dateofjoin;
        }
    }
}

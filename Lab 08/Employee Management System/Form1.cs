using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Week_9
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();

        class notFoundEmpID:Exception
        {
            public notFoundEmpID(string Message) : base(Message)
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        long baseid = 7000;
        public void addEmployee(object sender, EventArgs e)
        {
            string employeeID;
            string name = nametext.Text;
            string designation = designationtext.Text;
            string contact = contacttext.Text;
            string salary = salarytext.Text;
            DateTime dateofjoin = dateTimePicker.Value.ToUniversalTime();

            if (designation == "Typewriter")
            {
                baseid = baseid + 1;
                employeeID = "100" + Convert.ToString(baseid);
                Employee employee = new Employee();
                employee.name = name;
                employee.designation = designation;
                employee.contact = contact;
                employee.salary = salary;
                employee.dateofjoin = dateofjoin;

                employee.employeeID = employeeID;
                employees.Add(employee);

                MessageBox.Show($"Employee Added!\nName: {name}\nEmployee ID: {employeeID}");


            }

            else if (designation == "Manager")
            {
                baseid = baseid + 1;
                employeeID = "200" + Convert.ToString(baseid);
                Employee employee = new Employee();
                employee.name = name;
                employee.designation = designation;
                employee.contact = contact;
                employee.salary = salary;
                employee.dateofjoin = dateofjoin;
                employee.employeeID = employeeID;
                employees.Add(employee);
                MessageBox.Show($"Employee Added!\nName: {name}\nEmployee ID: {employeeID}");
            }

            else if (designation == "Sales Person")
            {
                baseid = baseid + 1;
                employeeID = "300" + Convert.ToString(baseid);
                Employee employee = new Employee();
                employee.name = name;
                employee.designation = designation;
                employee.contact = contact;
                employee.salary = salary;
                employee.dateofjoin = dateofjoin;
                employee.employeeID = employeeID;
                employees.Add(employee);

                MessageBox.Show($"Employee Added!\nName: {name}\nEmployee ID: {employeeID}");
            }

            else
            {
                MessageBox.Show("Invalid Employee Designation");
            }




        }

        public void searchEmployee(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (Employee employee in employees)
            {
                if ((employee.employeeID == employeeIDsearch.Text))
                {
                    MessageBox.Show($"Name: {employee.name}\nEmployee ID: {employee.employeeID}\nSalary: {employee.salary}\nDate of Joining: {employee.dateofjoin}");
                    flag = 1;
                }

            }
            try
            {
                if (flag == 0)
                {
                    throw new notFoundEmpID("Employee not found");
                }
            }
            catch (notFoundEmpID ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (Employee employee in employees)
            {
                if (employeeIDupdate.Text == employee.employeeID)
                {


                    check++;
                    if (employeeNameupdate.Text != "")
                    {
                        employee.name = employeeNameupdate.Text;
                    }
                    if (employeeSalaryupdate.Text != "")
                    {
                        employee.salary = employeeSalaryupdate.Text;
                    }
                    if (employeeDesignationupdate.Text != "")
                    {
                        employee.designation = employeeDesignationupdate.Text;
                    }
                    if (employeeContactupdate.Text != "")
                    {
                        employee.contact = employeeContactupdate.Text;
                    }
                    MessageBox.Show("Employee Info Updated Successfully!");

                }
            }
            if(check == 0)
            {
                MessageBox.Show("Employee not found");
            }
        }
    }
}

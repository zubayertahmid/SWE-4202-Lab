using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07
{
    public partial class Form1 : Form
    {
        public List<Course> Courses = new List<Course>();
        public List<Teacher> Teachers = new List<Teacher>();
        public List<Student> Students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.name = teacherNameInput.Text;
            teacher.semester = teacherSemesterInput.Text;
            teacher.designation = teacherDesignationInput.Text;
            teacher.course = teacherCourseInput.Text;

            Teachers.Add(teacher);
            MessageBox.Show("Teacher Added Successfully");

        }

        private void addCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.name = courseNameInput.Text;
            course.semester = courseSemesterInput.Text;
            course.semester = courseSemesterInput.Text;
            
            Courses.Add(course);

            MessageBox.Show("Course Added Successfully");
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = studentNameInput.Text;
            student.semester= studentSemesterInput.Text;
            student.course = studentCourseInput.Text;

            Students.Add(student);

            MessageBox.Show("Student Added Successfully");
        }

        private void searchTeacher_Click(object sender, EventArgs e)
        {
            string a = teacherNameSearch.Text;
            foreach(Teacher teacher in Teachers)
            {
                if(teacher.name == a)
                {
                    listBoxTeacher.Items.Add($"{teacher.name}  {teacher.semester}  {teacher.course}  {teacher.designation}");
                    break;
                }
                else
                {
                    MessageBox.Show("Teacher not found");
                }
            }
        }

        private void searchStudent_Click(object sender, EventArgs e)
        {
            string a = studentNameSearch.Text;
            foreach(Student student in Students)
            {
                if(student.name == a)
                {
                    listBoxStudent.Items.Add($"{student.name}  {student.course}  {student.semester}");
                    break;
                }

                else
                {
                    MessageBox.Show("Student Not Found");
                }
            }
        }
    }
}

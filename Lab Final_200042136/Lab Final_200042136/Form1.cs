using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Final_200042136
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();


        public Form1()
        {
            InitializeComponent();

            using (var reader = new StreamReader(@"F:\SWE Lab Practice\Lab 09\Lab Final_200042136\Lab Final_200042136\csv.csv"))
            {
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student dummy = new Student();

                    dummy.id = values[0];
                    dummy.name = values[1];
                    dummy.attendance = values[2];
                    dummy.quiz1marks = values[3];
                    dummy.quiz2marks = values[4];
                    dummy.quiz3marks = values[5];
                    dummy.quiz4marks = values[6];
                    dummy.mid = values[7];
                    dummy.final = values[8];
                    dummy.viva = values[9];

                    double attendanceMarks;
                    double quiz1Marks;
                    double quiz2Marks;
                    double quiz3Marks;
                    double quiz4Marks;
                    double midMarks;
                    double finalMarks;
                    double vivaMarks;

                    double quizTotal;
                    double totalMarks;
                    double percentage;
                    string grade;

                    if (dummy.attendance != "")
                    {
                        attendanceMarks = Convert.ToDouble(dummy.attendance);

                    }
                    else
                    {
                        attendanceMarks = 0;
                    }
                    if(dummy.quiz1marks != "")
                    {
                        quiz1Marks = Convert.ToDouble(dummy.quiz1marks);

                    }
                    else
                    {
                        quiz1Marks = 0;
                    }
                    if (dummy.quiz2marks != "")
                    {
                        quiz2Marks = Convert.ToDouble(dummy.quiz2marks);

                    }
                    else
                    {
                        quiz2Marks = 0;
                    }

                    if (dummy.quiz3marks != "")
                    {
                        quiz3Marks = Convert.ToDouble(dummy.quiz3marks);

                    }
                    else
                    {
                        quiz3Marks = 0;
                    }

                    if (dummy.quiz4marks != "")
                    {
                        quiz4Marks = Convert.ToDouble(dummy.quiz4marks);

                    }
                    else
                    {
                        quiz4Marks = 0;
                    }

                    if (dummy.mid != "")
                    {
                        midMarks = Convert.ToDouble(dummy.mid);

                    }
                    else
                    {
                        midMarks = 0;
                    }

                    if (dummy.final != "")
                    {
                        finalMarks = Convert.ToDouble(dummy.final);

                    }
                    else
                    {
                        finalMarks = 0;
                    }

                    if (dummy.viva != "")
                    {
                        vivaMarks = Convert.ToDouble(dummy.viva);

                    }
                    else
                    {
                        vivaMarks = 0;
                    }



                    //

                    if (quiz4Marks <= quiz1Marks && quiz4Marks <= quiz2Marks && quiz4Marks <= quiz3Marks)
                    {
                        quizTotal = quiz1Marks + quiz2Marks + quiz3Marks;
                    }
                    else if (quiz3Marks <= quiz1Marks && quiz3Marks <= quiz2Marks && quiz3Marks <= quiz4Marks)
                    {
                        quizTotal = quiz1Marks + quiz2Marks + quiz4Marks;
                    }
                    else if (quiz2Marks <= quiz1Marks && quiz2Marks <= quiz3Marks && quiz2Marks <= quiz4Marks)
                    {
                        quizTotal = quiz1Marks + quiz4Marks + quiz3Marks;
                    }
                    else
                    {
                        quizTotal = quiz4Marks + quiz2Marks + quiz3Marks;
                    }


                    totalMarks = attendanceMarks + quizTotal + midMarks + finalMarks + vivaMarks;

                    percentage = (totalMarks / 300.0) * 100;

                    if (percentage >= 80 && percentage <= 100)
                    {
                        grade = "A+";
                    }
                    else if (percentage >= 75 && percentage <= 79)
                    {
                        grade = "A";
                    }
                    else if (percentage >= 70 && percentage <= 74)
                    {
                        grade = "A-";
                    }
                    else if (percentage >= 65 && percentage <= 69)
                    {
                        grade = "B+";
                    }
                    else if (percentage >= 60 && percentage <= 64)
                    {
                        grade = "B";
                    }
                    else if (percentage >= 55 && percentage <= 59)
                    {
                        grade = "B-";
                    }
                    else if (percentage >= 50 && percentage <= 54)
                    {
                        grade = "C+";
                    }
                    else if (percentage >= 45 && percentage <= 49)
                    {
                        grade = "C";
                    }
                    else if (percentage >= 40 && percentage <= 44)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }


                    dummy.Total = Convert.ToString(totalMarks);
                    dummy.grade = grade;
                    percentage = Math.Round(percentage, 2);
                    dummy.percentage = Convert.ToString(percentage);

                    dummy.quizTotalMarks = Convert.ToString(quizTotal);


                    students.Add(dummy);
                }

            }

            for (int flag = 0; flag < students.Count; flag++)
            {
                listBox1.Items.Add("Student ID : " + students[flag].showID()); ;
                listBox1.Items.Add("Student Name : " + students[flag].showName());
                listBox1.Items.Add("Percentage : " + students[flag].showPercentage() + "%");
                listBox1.Items.Add("Grade : " + students[flag].showGrade());
                listBox1.Items.Add("");
            }
        }

        private void searchID_Click(object sender, EventArgs e)
        {
            string flagID = searchIDinput.Text;
            bool flag = true;
            int p;
            for (p = 0; p < students.Count; p++)
            {
                if (students[p].id == flagID)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show("Student not found!");
            }
            else
            {
                attendance.Text = "Attendance : " + students[p].attendance.ToString();
                quiz1.Text = "Quiz 1 : " + students[p].quiz1marks.ToString();
                quiz2.Text = "Quiz 2 : " + students[p].quiz2marks.ToString();
                quiz3.Text = "Quiz 3 : " + students[p].quiz3marks.ToString();
                quiz4.Text = "Quiz 4 : " + students[p].quiz4marks.ToString();
                quizTotal.Text = "Quiz Total (Best 3) : " + students[p].quizTotalMarks.ToString();
                mid.Text = "Mid : " + students[p].mid.ToString();
                final.Text = "final : " + students[p].final.ToString();
                viva.Text = "Viva : " + students[p].viva.ToString();
                total.Text = "Total (Out of 300) : " + students[p].Total.ToString();
                percentage.Text = "Percentage : " + students[p].percentage.ToString() + " %";
                grade.Text = "Grade : " + students[p].grade;
            }
        }
    }
}

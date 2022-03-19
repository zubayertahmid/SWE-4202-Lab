namespace Lab_07
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.teacherNameInput = new System.Windows.Forms.TextBox();
            this.addTeacher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherCourseInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherDesignationInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courseSemesterInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.courseCreditInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addCourse = new System.Windows.Forms.Button();
            this.courseNameInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.studentSemesterInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studentCourseInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addStudent = new System.Windows.Forms.Button();
            this.studentNameInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxTeacher = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.teacherNameSearch = new System.Windows.Forms.TextBox();
            this.searchTeacher = new System.Windows.Forms.Button();
            this.searchStudent = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.studentNameSearch = new System.Windows.Forms.TextBox();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.teacherSemesterInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Info";
            // 
            // teacherNameInput
            // 
            this.teacherNameInput.Location = new System.Drawing.Point(79, 42);
            this.teacherNameInput.Name = "teacherNameInput";
            this.teacherNameInput.Size = new System.Drawing.Size(100, 20);
            this.teacherNameInput.TabIndex = 1;
            // 
            // addTeacher
            // 
            this.addTeacher.Location = new System.Drawing.Point(50, 155);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(75, 23);
            this.addTeacher.TabIndex = 2;
            this.addTeacher.Text = "Add";
            this.addTeacher.UseVisualStyleBackColor = true;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course:";
            // 
            // teacherCourseInput
            // 
            this.teacherCourseInput.Location = new System.Drawing.Point(79, 68);
            this.teacherCourseInput.Name = "teacherCourseInput";
            this.teacherCourseInput.Size = new System.Drawing.Size(100, 20);
            this.teacherCourseInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Designation:";
            // 
            // teacherDesignationInput
            // 
            this.teacherDesignationInput.Location = new System.Drawing.Point(79, 94);
            this.teacherDesignationInput.Name = "teacherDesignationInput";
            this.teacherDesignationInput.Size = new System.Drawing.Size(100, 20);
            this.teacherDesignationInput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Semester:";
            // 
            // courseSemesterInput
            // 
            this.courseSemesterInput.Location = new System.Drawing.Point(366, 94);
            this.courseSemesterInput.Name = "courseSemesterInput";
            this.courseSemesterInput.Size = new System.Drawing.Size(100, 20);
            this.courseSemesterInput.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Credit:";
            // 
            // courseCreditInput
            // 
            this.courseCreditInput.Location = new System.Drawing.Point(366, 68);
            this.courseCreditInput.Name = "courseCreditInput";
            this.courseCreditInput.Size = new System.Drawing.Size(100, 20);
            this.courseCreditInput.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Course Name:";
            // 
            // addCourse
            // 
            this.addCourse.Location = new System.Drawing.Point(323, 133);
            this.addCourse.Name = "addCourse";
            this.addCourse.Size = new System.Drawing.Size(75, 23);
            this.addCourse.TabIndex = 10;
            this.addCourse.Text = "Add";
            this.addCourse.UseVisualStyleBackColor = true;
            this.addCourse.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // courseNameInput
            // 
            this.courseNameInput.Location = new System.Drawing.Point(366, 42);
            this.courseNameInput.Name = "courseNameInput";
            this.courseNameInput.Size = new System.Drawing.Size(100, 20);
            this.courseNameInput.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Course Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(570, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Semester:";
            // 
            // studentSemesterInput
            // 
            this.studentSemesterInput.Location = new System.Drawing.Point(650, 97);
            this.studentSemesterInput.Name = "studentSemesterInput";
            this.studentSemesterInput.Size = new System.Drawing.Size(100, 20);
            this.studentSemesterInput.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Course:";
            // 
            // studentCourseInput
            // 
            this.studentCourseInput.Location = new System.Drawing.Point(650, 71);
            this.studentCourseInput.Name = "studentCourseInput";
            this.studentCourseInput.Size = new System.Drawing.Size(100, 20);
            this.studentCourseInput.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(570, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Name:";
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(607, 136);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(75, 23);
            this.addStudent.TabIndex = 18;
            this.addStudent.Text = "Add";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // studentNameInput
            // 
            this.studentNameInput.Location = new System.Drawing.Point(650, 45);
            this.studentNameInput.Name = "studentNameInput";
            this.studentNameInput.Size = new System.Drawing.Size(100, 20);
            this.studentNameInput.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(570, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Student Info";
            // 
            // listBoxTeacher
            // 
            this.listBoxTeacher.FormattingEnabled = true;
            this.listBoxTeacher.Location = new System.Drawing.Point(15, 231);
            this.listBoxTeacher.Name = "listBoxTeacher";
            this.listBoxTeacher.Size = new System.Drawing.Size(345, 95);
            this.listBoxTeacher.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Name:";
            // 
            // teacherNameSearch
            // 
            this.teacherNameSearch.Location = new System.Drawing.Point(79, 354);
            this.teacherNameSearch.Name = "teacherNameSearch";
            this.teacherNameSearch.Size = new System.Drawing.Size(100, 20);
            this.teacherNameSearch.TabIndex = 25;
            // 
            // searchTeacher
            // 
            this.searchTeacher.Location = new System.Drawing.Point(79, 389);
            this.searchTeacher.Name = "searchTeacher";
            this.searchTeacher.Size = new System.Drawing.Size(75, 23);
            this.searchTeacher.TabIndex = 27;
            this.searchTeacher.Text = "Search";
            this.searchTeacher.UseVisualStyleBackColor = true;
            this.searchTeacher.Click += new System.EventHandler(this.searchTeacher_Click);
            // 
            // searchStudent
            // 
            this.searchStudent.Location = new System.Drawing.Point(507, 389);
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Size = new System.Drawing.Size(75, 23);
            this.searchStudent.TabIndex = 31;
            this.searchStudent.Text = "Search";
            this.searchStudent.UseVisualStyleBackColor = true;
            this.searchStudent.Click += new System.EventHandler(this.searchStudent_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(440, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Name:";
            // 
            // studentNameSearch
            // 
            this.studentNameSearch.Location = new System.Drawing.Point(507, 354);
            this.studentNameSearch.Name = "studentNameSearch";
            this.studentNameSearch.Size = new System.Drawing.Size(100, 20);
            this.studentNameSearch.TabIndex = 29;
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(443, 231);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(345, 95);
            this.listBoxStudent.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Semester:";
            // 
            // teacherSemesterInput
            // 
            this.teacherSemesterInput.Location = new System.Drawing.Point(79, 120);
            this.teacherSemesterInput.Name = "teacherSemesterInput";
            this.teacherSemesterInput.Size = new System.Drawing.Size(100, 20);
            this.teacherSemesterInput.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.teacherSemesterInput);
            this.Controls.Add(this.searchStudent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.studentNameSearch);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.searchTeacher);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.teacherNameSearch);
            this.Controls.Add(this.listBoxTeacher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.studentSemesterInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.studentCourseInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.studentNameInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseSemesterInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.courseCreditInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addCourse);
            this.Controls.Add(this.courseNameInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teacherDesignationInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacherCourseInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addTeacher);
            this.Controls.Add(this.teacherNameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacherNameInput;
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacherCourseInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherDesignationInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox courseSemesterInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox courseCreditInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.TextBox courseNameInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox studentSemesterInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox studentCourseInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.TextBox studentNameInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxTeacher;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox teacherNameSearch;
        private System.Windows.Forms.Button searchTeacher;
        private System.Windows.Forms.Button searchStudent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox studentNameSearch;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox teacherSemesterInput;
    }
}


namespace Lab_Week_9
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.salarytext = new System.Windows.Forms.TextBox();
            this.contacttext = new System.Windows.Forms.TextBox();
            this.designationtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.namesearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeIDsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.employeeIDupdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeNameupdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeContactupdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.employeeDesignationupdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.employeeSalaryupdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.updateEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Designation:";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(99, 6);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 5;
            // 
            // salarytext
            // 
            this.salarytext.Location = new System.Drawing.Point(97, 42);
            this.salarytext.Name = "salarytext";
            this.salarytext.Size = new System.Drawing.Size(100, 20);
            this.salarytext.TabIndex = 6;
            // 
            // contacttext
            // 
            this.contacttext.Location = new System.Drawing.Point(97, 76);
            this.contacttext.Name = "contacttext";
            this.contacttext.Size = new System.Drawing.Size(100, 20);
            this.contacttext.TabIndex = 7;
            // 
            // designationtext
            // 
            this.designationtext.Location = new System.Drawing.Point(97, 108);
            this.designationtext.Name = "designationtext";
            this.designationtext.Size = new System.Drawing.Size(100, 20);
            this.designationtext.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addEmployee);
            // 
            // namesearch
            // 
            this.namesearch.Location = new System.Drawing.Point(446, 9);
            this.namesearch.Name = "namesearch";
            this.namesearch.Size = new System.Drawing.Size(100, 20);
            this.namesearch.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Joining Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(99, 146);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // employeeIDsearch
            // 
            this.employeeIDsearch.Location = new System.Drawing.Point(446, 42);
            this.employeeIDsearch.Name = "employeeIDsearch";
            this.employeeIDsearch.Size = new System.Drawing.Size(100, 20);
            this.employeeIDsearch.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Employee ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Search Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.searchEmployee);
            // 
            // employeeIDupdate
            // 
            this.employeeIDupdate.Location = new System.Drawing.Point(446, 149);
            this.employeeIDupdate.Name = "employeeIDupdate";
            this.employeeIDupdate.Size = new System.Drawing.Size(100, 20);
            this.employeeIDupdate.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Employee ID:";
            // 
            // employeeNameupdate
            // 
            this.employeeNameupdate.Location = new System.Drawing.Point(446, 182);
            this.employeeNameupdate.Name = "employeeNameupdate";
            this.employeeNameupdate.Size = new System.Drawing.Size(100, 20);
            this.employeeNameupdate.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name:";
            // 
            // employeeContactupdate
            // 
            this.employeeContactupdate.Location = new System.Drawing.Point(446, 218);
            this.employeeContactupdate.Name = "employeeContactupdate";
            this.employeeContactupdate.Size = new System.Drawing.Size(100, 20);
            this.employeeContactupdate.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Contact:";
            // 
            // employeeDesignationupdate
            // 
            this.employeeDesignationupdate.Location = new System.Drawing.Point(446, 253);
            this.employeeDesignationupdate.Name = "employeeDesignationupdate";
            this.employeeDesignationupdate.Size = new System.Drawing.Size(100, 20);
            this.employeeDesignationupdate.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Designation:";
            // 
            // employeeSalaryupdate
            // 
            this.employeeSalaryupdate.Location = new System.Drawing.Point(446, 288);
            this.employeeSalaryupdate.Name = "employeeSalaryupdate";
            this.employeeSalaryupdate.Size = new System.Drawing.Size(100, 20);
            this.employeeSalaryupdate.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Salary:";
            // 
            // updateEmployee
            // 
            this.updateEmployee.Location = new System.Drawing.Point(555, 208);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(102, 38);
            this.updateEmployee.TabIndex = 28;
            this.updateEmployee.Text = "Update Employee";
            this.updateEmployee.UseVisualStyleBackColor = true;
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 342);
            this.Controls.Add(this.updateEmployee);
            this.Controls.Add(this.employeeSalaryupdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.employeeDesignationupdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.employeeContactupdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.employeeIDupdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.employeeNameupdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.employeeIDsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.namesearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.designationtext);
            this.Controls.Add(this.contacttext);
            this.Controls.Add(this.salarytext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox salarytext;
        private System.Windows.Forms.TextBox contacttext;
        private System.Windows.Forms.TextBox designationtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox namesearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox employeeIDsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox employeeIDupdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox employeeNameupdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox employeeContactupdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox employeeDesignationupdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox employeeSalaryupdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button updateEmployee;
    }
}


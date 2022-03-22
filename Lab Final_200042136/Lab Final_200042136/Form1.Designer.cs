namespace Lab_Final_200042136
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchIDinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchID = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.viva = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.Label();
            this.quizTotal = new System.Windows.Forms.Label();
            this.quiz4 = new System.Windows.Forms.Label();
            this.quiz3 = new System.Windows.Forms.Label();
            this.quiz2 = new System.Windows.Forms.Label();
            this.quiz1 = new System.Windows.Forms.Label();
            this.attendance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IUT Result Processor";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 394);
            this.listBox1.TabIndex = 1;
            // 
            // searchIDinput
            // 
            this.searchIDinput.Location = new System.Drawing.Point(510, 37);
            this.searchIDinput.Name = "searchIDinput";
            this.searchIDinput.Size = new System.Drawing.Size(100, 20);
            this.searchIDinput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search By ID:";
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(523, 72);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(75, 23);
            this.searchID.TabIndex = 4;
            this.searchID.Text = "Search";
            this.searchID.UseVisualStyleBackColor = true;
            this.searchID.Click += new System.EventHandler(this.searchID_Click);
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(466, 383);
            this.grade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(42, 13);
            this.grade.TabIndex = 29;
            this.grade.Text = "Grade :";
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(466, 359);
            this.percentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(68, 13);
            this.percentage.TabIndex = 28;
            this.percentage.Text = "Percentage :";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(466, 335);
            this.total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(96, 13);
            this.total.TabIndex = 27;
            this.total.Text = "Total (Out of 300) :";
            // 
            // viva
            // 
            this.viva.AutoSize = true;
            this.viva.Location = new System.Drawing.Point(466, 312);
            this.viva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viva.Name = "viva";
            this.viva.Size = new System.Drawing.Size(34, 13);
            this.viva.TabIndex = 26;
            this.viva.Text = "Viva :";
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Location = new System.Drawing.Point(466, 290);
            this.final.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(35, 13);
            this.final.TabIndex = 25;
            this.final.Text = "Final :";
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.Location = new System.Drawing.Point(466, 266);
            this.mid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(30, 13);
            this.mid.TabIndex = 24;
            this.mid.Text = "Mid :";
            // 
            // quizTotal
            // 
            this.quizTotal.AutoSize = true;
            this.quizTotal.Location = new System.Drawing.Point(466, 243);
            this.quizTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quizTotal.Name = "quizTotal";
            this.quizTotal.Size = new System.Drawing.Size(100, 13);
            this.quizTotal.TabIndex = 23;
            this.quizTotal.Text = "Quiz Total (Best 3) :";
            // 
            // quiz4
            // 
            this.quiz4.AutoSize = true;
            this.quiz4.Location = new System.Drawing.Point(466, 219);
            this.quiz4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quiz4.Name = "quiz4";
            this.quiz4.Size = new System.Drawing.Size(43, 13);
            this.quiz4.TabIndex = 22;
            this.quiz4.Text = "Quiz 4 :";
            // 
            // quiz3
            // 
            this.quiz3.AutoSize = true;
            this.quiz3.Location = new System.Drawing.Point(466, 198);
            this.quiz3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quiz3.Name = "quiz3";
            this.quiz3.Size = new System.Drawing.Size(43, 13);
            this.quiz3.TabIndex = 21;
            this.quiz3.Text = "Quiz 3 :";
            // 
            // quiz2
            // 
            this.quiz2.AutoSize = true;
            this.quiz2.Location = new System.Drawing.Point(466, 175);
            this.quiz2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quiz2.Name = "quiz2";
            this.quiz2.Size = new System.Drawing.Size(43, 13);
            this.quiz2.TabIndex = 20;
            this.quiz2.Text = "Quiz 2 :";
            // 
            // quiz1
            // 
            this.quiz1.AutoSize = true;
            this.quiz1.Location = new System.Drawing.Point(466, 151);
            this.quiz1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quiz1.Name = "quiz1";
            this.quiz1.Size = new System.Drawing.Size(43, 13);
            this.quiz1.TabIndex = 19;
            this.quiz1.Text = "Quiz 1 :";
            // 
            // attendance
            // 
            this.attendance.AutoSize = true;
            this.attendance.Location = new System.Drawing.Point(466, 127);
            this.attendance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(68, 13);
            this.attendance.TabIndex = 18;
            this.attendance.Text = "Attendance :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.total);
            this.Controls.Add(this.viva);
            this.Controls.Add(this.final);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.quizTotal);
            this.Controls.Add(this.quiz4);
            this.Controls.Add(this.quiz3);
            this.Controls.Add(this.quiz2);
            this.Controls.Add(this.quiz1);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchIDinput);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox searchIDinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchID;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label viva;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.Label mid;
        private System.Windows.Forms.Label quizTotal;
        private System.Windows.Forms.Label quiz4;
        private System.Windows.Forms.Label quiz3;
        private System.Windows.Forms.Label quiz2;
        private System.Windows.Forms.Label quiz1;
        private System.Windows.Forms.Label attendance;
    }
}


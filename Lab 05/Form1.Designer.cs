namespace Pharmacy_Management_System
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.medicinenameinput = new System.Windows.Forms.TextBox();
            this.manufacturerinput = new System.Windows.Forms.TextBox();
            this.chemicalgroupinput = new System.Windows.Forms.TextBox();
            this.quantityinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shelfnoinput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceinput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.medicinenamesearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.medicinemanufacturersearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.medicinegroupsearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.medicineavailableoutput = new System.Windows.Forms.Label();
            this.shelfnooutput = new System.Windows.Forms.Label();
            this.currentbalance = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chemical Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // medicinenameinput
            // 
            this.medicinenameinput.Location = new System.Drawing.Point(100, 35);
            this.medicinenameinput.Name = "medicinenameinput";
            this.medicinenameinput.Size = new System.Drawing.Size(100, 20);
            this.medicinenameinput.TabIndex = 4;
            // 
            // manufacturerinput
            // 
            this.manufacturerinput.Location = new System.Drawing.Point(100, 61);
            this.manufacturerinput.Name = "manufacturerinput";
            this.manufacturerinput.Size = new System.Drawing.Size(100, 20);
            this.manufacturerinput.TabIndex = 5;
            // 
            // chemicalgroupinput
            // 
            this.chemicalgroupinput.Location = new System.Drawing.Point(100, 87);
            this.chemicalgroupinput.Name = "chemicalgroupinput";
            this.chemicalgroupinput.Size = new System.Drawing.Size(100, 20);
            this.chemicalgroupinput.TabIndex = 6;
            // 
            // quantityinput
            // 
            this.quantityinput.Location = new System.Drawing.Point(100, 115);
            this.quantityinput.Name = "quantityinput";
            this.quantityinput.Size = new System.Drawing.Size(100, 20);
            this.quantityinput.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addMedicine);
            // 
            // shelfnoinput
            // 
            this.shelfnoinput.Location = new System.Drawing.Point(100, 141);
            this.shelfnoinput.Name = "shelfnoinput";
            this.shelfnoinput.Size = new System.Drawing.Size(100, 20);
            this.shelfnoinput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shelf No.";
            // 
            // priceinput
            // 
            this.priceinput.Location = new System.Drawing.Point(100, 167);
            this.priceinput.Name = "priceinput";
            this.priceinput.Size = new System.Drawing.Size(100, 20);
            this.priceinput.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // medicinenamesearch
            // 
            this.medicinenamesearch.Location = new System.Drawing.Point(352, 38);
            this.medicinenamesearch.Name = "medicinenamesearch";
            this.medicinenamesearch.Size = new System.Drawing.Size(100, 20);
            this.medicinenamesearch.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Medicine Name";
            // 
            // medicinemanufacturersearch
            // 
            this.medicinemanufacturersearch.Location = new System.Drawing.Point(352, 64);
            this.medicinemanufacturersearch.Name = "medicinemanufacturersearch";
            this.medicinemanufacturersearch.Size = new System.Drawing.Size(100, 20);
            this.medicinemanufacturersearch.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Manufacturer";
            // 
            // medicinegroupsearch
            // 
            this.medicinegroupsearch.Location = new System.Drawing.Point(352, 90);
            this.medicinegroupsearch.Name = "medicinegroupsearch";
            this.medicinegroupsearch.Size = new System.Drawing.Size(100, 20);
            this.medicinegroupsearch.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Chemical Group";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sell Medicine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sellMedicine);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 40);
            this.button3.TabIndex = 20;
            this.button3.Text = "Search Medicine";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.searchMedicine);
            // 
            // medicineavailableoutput
            // 
            this.medicineavailableoutput.AutoSize = true;
            this.medicineavailableoutput.Location = new System.Drawing.Point(252, 193);
            this.medicineavailableoutput.Name = "medicineavailableoutput";
            this.medicineavailableoutput.Size = new System.Drawing.Size(95, 13);
            this.medicineavailableoutput.TabIndex = 21;
            this.medicineavailableoutput.Text = "Available Quantity:";
            // 
            // shelfnooutput
            // 
            this.shelfnooutput.AutoSize = true;
            this.shelfnooutput.Location = new System.Drawing.Point(295, 220);
            this.shelfnooutput.Name = "shelfnooutput";
            this.shelfnooutput.Size = new System.Drawing.Size(51, 13);
            this.shelfnooutput.TabIndex = 22;
            this.shelfnooutput.Text = "Shelf No.";
            // 
            // currentbalance
            // 
            this.currentbalance.Location = new System.Drawing.Point(586, 41);
            this.currentbalance.Name = "currentbalance";
            this.currentbalance.Size = new System.Drawing.Size(100, 20);
            this.currentbalance.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(586, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 40);
            this.button4.TabIndex = 24;
            this.button4.Text = "Current Balance";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.currentBalance);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.currentbalance);
            this.Controls.Add(this.shelfnooutput);
            this.Controls.Add(this.medicineavailableoutput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.medicinegroupsearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.medicinemanufacturersearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.medicinenamesearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceinput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shelfnoinput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantityinput);
            this.Controls.Add(this.chemicalgroupinput);
            this.Controls.Add(this.manufacturerinput);
            this.Controls.Add(this.medicinenameinput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox medicinenameinput;
        private System.Windows.Forms.TextBox manufacturerinput;
        private System.Windows.Forms.TextBox chemicalgroupinput;
        private System.Windows.Forms.TextBox quantityinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox shelfnoinput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceinput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox medicinenamesearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox medicinemanufacturersearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox medicinegroupsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label medicineavailableoutput;
        private System.Windows.Forms.Label shelfnooutput;
        private System.Windows.Forms.TextBox currentbalance;
        private System.Windows.Forms.Button button4;
    }
}


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

namespace File_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            using (var reader = new StreamReader(@"F:\SWE Lab Practice\Lab 10\userinfo.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    User dummy = new User(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10]);
                    UserList.users.Add(dummy);


                }

                
            }
            viewScreen();

        }

        public void viewScreen()
        {
            userDataListBox.Items.Clear();
            foreach(User user in UserList.users)
            {
                userDataListBox.Items.Add(user.getInfo());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (User user in UserList.users)
            {
                
                if(user.phone1 == userSearchTextBox.Text)
                {

                    searchOutput.Text = "User information:\n" + user.searchInfo();

                    flag = 1;
                    break;

                }
                if(flag == 1)
                {
                    using (StreamWriter sw = File.AppendText(@"F:\SWE Lab Practice\Lab 10\text.txt"))
                    {
                        sw.WriteLine(user.firstName + " " + user.lastName + " " + user.phone + " " + user.state);
                    }
                }

                
            }
            if(flag==0)
            {
                MessageBox.Show("User not Found!");
            }
        }
    }
}

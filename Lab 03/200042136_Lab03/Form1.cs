using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRS_Dependencies;

namespace _200042136_Lab02
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUser(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(useridinput.Text);
            string name = usernameinput.Text;

            User dummy = new User(id, name);
            users.Add(dummy);
            MessageBox.Show("User Added");
        }

        private void AddCar(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(caridinput.Text);
            string name = carnameinput.Text;
            int quantity = Convert.ToInt32(carquantityinput.Text);
            string model = carmodelinput.Text;

            Car dummy = new Car(id, name, model, quantity);
            cars.Add(dummy);
            MessageBox.Show("Car Added");
                
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rentCar(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(useridrent.Text);
            string carname = carnamerent.Text;

            foreach(User user in users)
            {
                if(user.id == userid)
                {
                    foreach(Car car in cars)
                    {
                        if(car.name == carname)
                        {
                            user.cars.Add(carname);
                            MessageBox.Show("Rented Successfully");
                            break;
                        }
                       
                        else
                        {
                            MessageBox.Show("Car not found");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }

        }

        private void userhistoryshow(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userhistoryinput.Text);
            bool flag = false;
            User dummy = new User();
            foreach(User user in users)
            {
                if(user.id == id)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }
            if(flag == false)
            {
                MessageBox.Show("User not found");
            }
            userlistbox.Items.Clear();
            for(int i= 0; i<dummy.cars.Count; i++)
            {
                string id_car = dummy.cars[i];
                for(int j=0;j<cars.Count; j++)
                {
                    if(String.Equals(cars[j].name, id_car))
                    {
                        userlistbox.Items.Add(cars[j]);
                    }
                }

            }
        }
    }
}

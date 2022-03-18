using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        public List<DoubleRoom> DoubleRooms = new List<DoubleRoom>();
        public List<SingleRoom> SingleRooms = new List<SingleRoom>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void addSingleRoom_Click(object sender, EventArgs e)
        {
            SingleRoom singleRoom = new SingleRoom();
            singleRoom.Name = singleRoomNameInput.Text;
            singleRoom.quantity = Convert.ToInt32(singleRoomQuantityInput.Text);
            singleRoom.AC = singleRoomACinput.Text;
            singleRoom.gaming = singleRoomGameInput.Text;
            if(singleRoom.AC == "YES")
            {
                singleRoom.price += 500;
            }
            if(singleRoom.gaming == "YES")
            {
                singleRoom.price += 1000;
            }

            SingleRooms.Add(singleRoom);

            MessageBox.Show("You have added a single room successfully");

        }

        private void doubleRoomAdd_Click(object sender, EventArgs e)
        {
            DoubleRoom doubleRoom = new DoubleRoom();
            doubleRoom.Name = doubleRoomNameInput.Text;
            doubleRoom.quantity = Convert.ToInt32(doubleRoomQuantityInput.Text);
            doubleRoom.AC = doubleRoomACinput.Text;
            doubleRoom.refrigerator = doubleRoomRefrgInput.Text;
            doubleRoom.gaming = doubleRoomGameInput.Text;
            doubleRoom.breakfast = doubleRoomBreakfastInput.Text;
            if(doubleRoom.breakfast == "YES")
            {
                doubleRoom.price += 500;
            }
            if(doubleRoom.gaming == "YES")
            {
                doubleRoom.price += 1000;
            }
            if(doubleRoom.refrigerator == "YES")
            {
                doubleRoom.price += 500;
            }
            DoubleRooms.Add(doubleRoom);

            MessageBox.Show("You have added a double room successfully");
        }

        private void roomRent_Click(object sender, EventArgs e)
        {
            foreach(SingleRoom room in SingleRooms)
            {
                if(room.Name == roomNameRent.Text)
                {
                    room.quantity -= Convert.ToInt32(roomQuantityRent.Text);
                    int a = Convert.ToInt32(roomQuantityRent.Text);
                    int b = room.price;

                    MessageBox.Show($"Room Booked, price is {b}");
                }
                else
                {
                    MessageBox.Show("Room not found");
                }
            }

            foreach(DoubleRoom doubleRoom in DoubleRooms)
            {
                if(doubleRoom.Name == roomNameRent.Text)
                {
                    doubleRoom.quantity -= Convert.ToInt32(roomQuantityRent.Text);
                    int a = Convert.ToInt32(roomQuantityRent.Text);
                    int b = doubleRoom.price;

                    MessageBox.Show($"Room Booked, price is {b}");
                }
                else
                {
                    MessageBox.Show("Room not found");
                }
            }

        }
    }
}

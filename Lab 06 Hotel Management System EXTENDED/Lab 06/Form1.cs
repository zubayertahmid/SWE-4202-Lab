using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class Form1 : Form
    {

        public List<User> Users = new List<User>();
        public List<BookingList> Bookings = new List<BookingList>();
        public List<StatusCheck> StatusChecks = new List<StatusCheck>();
        public Form1()
        {
            InitializeComponent();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            string name = nameCreateAccount.Text;
            string contact = contactCreateAccount.Text;
            string address = addressCreateAccount.Text;

            string userID = useridCreateAccount.Text;

            User dummy = new User(name, contact, address, userID);

            Users.Add(dummy);

            MessageBox.Show("Account Created!");



        }

        private void bookRoom_Click(object sender, EventArgs e)
        {
            string userID = bookingUserID.Text;
            string bookingID = bookingIDbooking.Text;
            string contact = bookingContact.Text;
            string dateOfCheckIn = bookingCheckIn.Text;
            string dateOfCheckOut = bookingCheckOut.Text;
            string roomNO = bookingRoomNo.Text;

            BookingList bookingList = new BookingList(userID, bookingID, contact, dateOfCheckIn, dateOfCheckOut, roomNO);
            Bookings.Add(bookingList);

            MessageBox.Show("Booking Done!");
            

        }

        private void setStatus_Click(object sender, EventArgs e)
        {
            string bookingID = bookingIDstatusSet.Text;
            string status = bookingIDstatus.Text;
            StatusCheck statusCheck = new StatusCheck(bookingID, status);

            StatusChecks.Add(statusCheck);

            MessageBox.Show("Status has been set!");
        }

        private void checkStatus_Click(object sender, EventArgs e)
        {
            string flag = bookingIDCheckStatus.Text;

            foreach(StatusCheck statusCheck in StatusChecks)
            {
                if(statusCheck.bookingID == flag)
                {
                    StatusListBox.Items.Add($"Booking ID: {statusCheck.bookingID}\nStatus: {statusCheck.status}");
                    break;
                }
                else
                {
                    MessageBox.Show("Booking not found");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class BookingList
    {
        public string userID;
        public string bookingID;
        public string contact;
        public string dateOfCheckIn;
        public string dateOfCheckOut;
        public string roomNO;

        public BookingList(string userID, string bookingID, string contact, string dateOfCheckIn, string dateOfCheckout, string roomNO)
        {
            this.userID = userID;
            this.bookingID = bookingID;
            this.contact = contact;
            this.dateOfCheckIn = dateOfCheckIn;
            this.dateOfCheckOut = dateOfCheckout;
            this.roomNO = roomNO;
        }
    }
}

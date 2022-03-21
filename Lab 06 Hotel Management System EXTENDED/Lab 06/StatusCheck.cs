using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class StatusCheck
    {
        public string bookingID;
        public string status;

        public StatusCheck(string bookingID, string status)
        {
            this.bookingID = bookingID;
            this.status = status;
        }
    }
}

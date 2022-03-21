using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class User
    {
        public string name;
        public string contact;
        public string address;
        public string userID;

        public User(string name, string contact, string address, string userID)
        {
            this.name = name;
            this.contact = contact;
            this.address = address;
            this.userID = userID;
        }
    }
}

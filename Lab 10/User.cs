using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Handling
{
    public class User
    {
        public string firstName;
        public string lastName;
        public string companyName;
        public string address;
        public string city;
        public string country;
        public string state;
        public string zip;
        public string phone1;
        public string phone;
        public string email;


        public User(string firstName, string lastName, string companyName, string address, string city, string country, string state, string zip, string phone1, string phone, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
          
            this.address = address;
            this.city = city;
            this.country = country;
            this.state = state;
            this.zip = zip;
            this.phone1 = phone1;
            this.phone = phone;
            this.email = email;
        }

        public string getInfo()
        {
            return this.firstName + "\t\t" + this.lastName + "\t\t" + this.email;
        }

        public string searchInfo()
        {
            return $"Name: {this.firstName} {this.lastName}\nCompany: {this.companyName}\nAddress: {this.city}\nCountry: {this.country}\nState: {this.state}\nPhone 1: {this.phone1}\nPhone 2:{this.phone}\nEmail: {this.email}";
        }
    }
}

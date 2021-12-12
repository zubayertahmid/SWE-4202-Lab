using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_Dependencies
{
    public class User
    {
        public int id;
        public string name;
        public List<string> cars = new List<string>();


        public User(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void adduserCar(string name)
        {
            cars.Add(name);       
        }
    }
}

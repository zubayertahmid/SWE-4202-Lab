using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    public class Medicine
    {
        public string name;
        public string manufacturer;
        public string chemicalgroup;
        public int quantity;
        public string shelfno;
        public int price;

        public Medicine(string name, string manufacturer, string chemicalgroup, int quantity, string shelfno, int price)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.chemicalgroup = chemicalgroup;
            this.quantity = quantity;
            this.shelfno = shelfno;
            this.price = price;
        }

    }
}

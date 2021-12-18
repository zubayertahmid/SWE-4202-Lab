using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{

    public partial class Form1 : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        
        int balance = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addMedicine(object sender, EventArgs e)
        {
            string name = medicinenameinput.Text;
            string manufacturer = manufacturerinput.Text;
            string chemicalgroup = chemicalgroupinput.Text;
            int quantity = Convert.ToInt32(quantityinput.Text);
            int price = Convert.ToInt32(priceinput.Text);

            int totalprice = price * quantity;

            string shelf = shelfnoinput.Text;

            balance = balance - totalprice;

            Medicine dummy = new Medicine(name, manufacturer, chemicalgroup, quantity, shelf, price);
            medicines.Add(dummy);
            MessageBox.Show("Medicine Added");

        }

        private void searchMedicine(object sender, EventArgs e)
        {
            string name = medicinenamesearch.Text;
            string manufacturer = medicinemanufacturersearch.Text;
            string chemicalgroup = medicinegroupsearch.Text;

            foreach (Medicine medicine in medicines)
            {
                if (Equals(name, medicine.name))
                {
                    if (Equals(manufacturer, medicine.manufacturer))
                    {
                        if (Equals(chemicalgroup, medicine.chemicalgroup))
                        {

                            if (medicine.quantity >= 1)
                            {
                                medicineavailableoutput.Text = "Available Quantity: " + medicine.quantity;
                                shelfnooutput.Text = "Shelf No. " + medicine.shelfno;
                                
                            }
                            else
                            {
                                MessageBox.Show("Stock Out!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Medicine Found");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Medicine Found");
                    }
                }
                else
                {
                    MessageBox.Show("No Medicine Found");
                }
            }
        }

        private void sellMedicine(object sender, EventArgs e)
        {
            string name = medicinenamesearch.Text;
            string manufacturer = medicinemanufacturersearch.Text;
            string chemicalgroup = medicinegroupsearch.Text;
            
            


                foreach (Medicine medicine in medicines)
                {
                    if (Equals(name, medicine.name))
                    {
                        if (Equals(manufacturer, medicine.manufacturer))
                        {
                            if (Equals(chemicalgroup, medicine.chemicalgroup))
                            {

                                medicine.quantity = medicine.quantity - 1;
                                balance = balance + medicine.price;
                                MessageBox.Show("Medicine Sold. Please find the medicine in shelf No. " + medicine.shelfno);
                                 
                            }
                        }
                    }
                }
            
        }

        private void currentBalance(object sender, EventArgs e)
        {
            currentbalance.Text = Convert.ToString(balance);
        }
    }
}

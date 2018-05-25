using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biluthyrning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Visa en lista med bilar
            
            ArrayList MyListOfCars = new ArrayList();


            MyListOfCars.Add(new Car() { Make = "Audi", Color = "Blue", Model = "R8", Fuel = "Gas" });
            MyListOfCars.Add(new Car() { Make = "Volvo", Color = "White", Model = "945", Fuel = "Gas" });
            MyListOfCars.Add(new Car() { Make = "Hyundai", Color = "white", Model = "i40", Fuel = "Diesel" });
            MyListOfCars.Add(new Car() { Make = "BMW", Color = "Black", Model = "M3", Fuel = "Gas" });
            MyListOfCars.Add(new Car() { Make = "VW", Color = "Blue", Model = "Golf", Fuel = "Electric" });
            MyListOfCars.Add(new Car() { Make = "Porshe", Color = "Red", Model = "911", Fuel = "Gas" });

            foreach (Car x in MyListOfCars)
            {
                listBox1.Items.Add(x);
            }
            listBox1.DisplayMember = "Make";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car c;
            c = (Car)listBox1.SelectedItem;

            //MessageBox.Show(c.Color);

            //string s;
            //s = listBox1.SelectedItem.ToString();

            label1.Text = (c.Model);
            label2.Text = (c.Color);
            label3.Text = (c.Fuel);


        }
        

    }
    public class Car
    {

        public string Make { get; set; }
        public string Color { get; set; }
        public string Fuel { get; set; }
        public string Model { get; set; }
    }
}

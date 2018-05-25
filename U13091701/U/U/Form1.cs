using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += new EventHandler(DoSomething);
            button1.Click += new EventHandler(DoSomething);

            //detta gör så den kommer upp 2 gånger
            button1.Click += new EventHandler(DoSomething);
        //använder anonym metod skriver ut kod direkt
            button3.Click += new EventHandler(delegate { MessageBox.Show("test"); } );
            //tesar mer
            //arrow syntax / Lambda
            // => utalas "goes to"
            button3.Click += new EventHandler((sender, e) => { MessageBox.Show("test2"); });

        }
             //sender = vem var de som kasta eventet
             //button2 i detta fall
        private void DoSomething(object sender, EventArgs e)
        {
            string s = sender.GetType().Name;
            //tvingar explicit,sender att visa sig som button
            Button b = (Button)sender;
            MessageBox.Show("Hey, vem kastade "+b.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}

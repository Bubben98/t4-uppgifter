using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float i;
        float j;
        public Form1()
        {
            InitializeComponent();
           

            label1.Text = ("tal1");
            label2.Text = ("tal2");
            button1.Text = ("+");
            button2.Text = ("-");
            button3.Text = ("/");
            button4.Text = ("*");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            i=float.Parse(textBox1.Text);
            j=float.Parse(textBox2.Text);
            listBox1.Items.Add("summan är " + (i - j));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i=float.Parse(textBox1.Text);
            j=float.Parse(textBox2.Text);
            listBox1.Items.Add("summan är " + (i + j));
        }

        private void button3_Click(object sender, EventArgs e)
        {

            i= float.Parse(textBox1.Text);
            j= float.Parse(textBox2.Text);
            listBox1.Items.Add("summan är " + (i / j));
        }

        private void button4_Click(object sender, EventArgs e)
        {

            i=float.Parse(textBox1.Text);
            j=float.Parse(textBox2.Text);
            listBox1.Items.Add("summan är " + (i * j));
        }
    }
}

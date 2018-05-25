using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo101117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Integrated Security=True");
            cn.Open();

            SqlDataReader dr;
            SqlCommand cm = new SqlCommand("SELECT * FROM Product", cn);

            dr = cm.ExecuteReader();

            foreach (IDataRecord item in dr)
            {
                listBox1.Items.Add(string.Format("{0} {1:c}", item[1], item[2]));
            }
            cn.Close();
        }
    }
}

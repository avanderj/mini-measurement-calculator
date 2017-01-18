using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2pt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double num1, result;
            //Convert textBox1.Text to double to perform multiplication on Line 26
            num1 = Convert.ToDouble(textBox1.Text);
            result = (num1 * 3.28084);
            //Convert the result to a string because .Text requires a string variable
            label2.Text = "Meters = " + Convert.ToString(result) + " Feet";
        }
    }
}

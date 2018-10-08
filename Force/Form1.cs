using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Force
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));

        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double F = Convert.ToDouble(textBox2.Text);
                double a = Convert.ToDouble(textBox1.Text);
                double fx = F * cos(a);
                double fy = F * sin(a);
                label2.Text = "Fx = " + fx;
                label1.Text = "Fy = " + fy;


            }
            catch
            {
                label1.Text = "Fx= Enter a Number!";
                label2.Text = "Fy= Enter a Number!";
            }

        }
    }
}

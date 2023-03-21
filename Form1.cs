using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            richTextBox1.Text = "Результат:" + Environment.NewLine;
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = (Math.Pow((Math.Abs(x-b)), 1 / 2))/(Math.Pow((Math.Abs(Math.Pow(b,3)- Math.Pow(x,3))), 3 / 2)) + Math.Log(Math.Abs(x-b));
                richTextBox1.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                this.chart1.Series[0].Points.AddXY(x, y);
                x = x + dx;
            }
        }
    }
    
}

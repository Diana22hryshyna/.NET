using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dziyana_Hryshyna_Zadanie1_.Model.Model;

namespace Dziyana_Hryshyna_Zadanie1_
{
    public partial class Zadanie7 : Form
    {
        public Zadanie7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private double function(double x)
        {
            return x * x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            double x1 = double.Parse(this.textBox1.Text);
            double x2 = double.Parse(this.textBox2.Text);
            double z = double.Parse(this.textBox3.Text);

            SingleCount singleCount = new SingleCount(x1, x2, function, AreaType.Rectangle, z);
            double n = singleCount.Zad7();

            this.listBox1.Items.Add($"Metoda prostokątna: {n}");

            singleCount.AreaType = AreaType.Trapezoid;
            double n1 = singleCount.Zad7();
            this.listBox1.Items.Add($"Metoda trapezowa: {n1}");
        }
    }
}

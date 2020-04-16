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
    public partial class Zadanie1 : Form
    {
        public Zadanie1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Zadanie1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private double function(double x)
        {
            return x * x;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Some textboxes are empty! Try again.");
                return;
            }

            int parsedValue;
            double parsedValue1;
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("This is int only fields! Try again");
                return;
            }
            if (!double.TryParse(textBox2.Text, out parsedValue1))
            {
                MessageBox.Show("This is double only fields! Try again");
                return;
            }

            int m = int.Parse(this.textBox1.Text);
            double z = double.Parse(this.textBox2.Text);
            if (m <= 0 || m > 1000)
            {
                MessageBox.Show("m range from 1 to 1000");
                return;
            }

            if (z < 0 || z > 100)
            {
                MessageBox.Show("z range from 0 to 100");
                return;
            }
            int x1 = 0;
            double x2 = 100;
            double real_result = 1000000 / 3;
            this.listBox1.Items.Clear();
            SingleCount singleCount = new SingleCount(x1, x2, m, 10, 100000, function,
                real_result, AreaType.Rectangle, z);
            List<double> listRect = singleCount.Zad1();
            foreach (var area in listRect)
            {
                this.listBox1.Items.Add($"Metoda prostokatna: {area}");
            }
            singleCount.AreaType = AreaType.Trapezoid;
            List<double> listTrap = singleCount.Zad1();
            foreach (var area in listTrap)
            {
                this.listBox1.Items.Add($"Metoda trapezowa: {area}");
            }
        }
    }
}

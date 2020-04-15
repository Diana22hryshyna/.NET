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
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Some textboxes are empty! Try again.");
                return;
            }

            double parsedValue;
            double parsedValue1;
            double parsedValue2;
            if (!double.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("This is double only fields! Try again");
                return;
            }
            if (!double.TryParse(textBox2.Text, out parsedValue1))
            {
                MessageBox.Show("This is double only fields! Try again");
                return;
            }
            if(!double.TryParse(textBox3.Text, out parsedValue2))
            {
                MessageBox.Show("This is double only fields! Try again");
                return;
            }
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

        private void Zadanie7_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

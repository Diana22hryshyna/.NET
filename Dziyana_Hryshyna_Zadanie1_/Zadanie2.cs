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
    public partial class Zadanie2 : Form
    {
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void Zadanie2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private double function(double x)
        {
            return x * x * x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Some textboxes are empty! Try again.");
                return;
            }

            double parsedValue;
            if (!double.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("This is double only fields! Try again");
                return;
            }

            double z = double.Parse(this.textBox1.Text);
            if(z > 65 || z < 0)
            {
                MessageBox.Show("Please enter value from 0 to 65");
                return;
            }

            int lowestH = 0;
            int highestH = 100;
            double real_result = 25000000;
            this.listBox1.Items.Clear();
            SingleCount singleCount = new SingleCount( function,
                real_result, AreaType.Rectangle, z, lowestH, highestH);
            double n_rect = singleCount.Zad2();
            this.listBox1.Items.Add($"Metoda prostokatna: {n_rect}");
            
            singleCount.AreaType = AreaType.Trapezoid;
            double n_trap = singleCount.Zad2();
            this.listBox1.Items.Add($"Metoda trapezowa: {n_trap}");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

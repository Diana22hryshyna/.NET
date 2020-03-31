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
            return x * x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z = double.Parse(this.textBox1.Text);
            int lowestH = 0;
            double highestH = 100;
            double real_result = 99999999 / 4;
            this.listBox1.Items.Clear();
            SingleCount singleCount = new SingleCount(lowestH, highestH, function,
                real_result, AreaType.Rectangle, z);
            double n_rect = singleCount.Zad2();
            this.listBox1.Items.Add($"Metoda prostokatna: {n_rect}");
            
            singleCount.AreaType = AreaType.Trapezoid;
            double n_trap = singleCount.Zad2();
            this.listBox1.Items.Add($"Metoda trapezowa: {n_trap}");

        }
    }
}

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
    public partial class Zadanie8 : Form
    {
        public Zadanie8()
        {
            InitializeComponent();
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
            if (z < 0 || z > 100)
            {
                MessageBox.Show("Please enter value z from 0 to 100");
                return;
            }
            int lowestH = 0;
            double real_result = 1;
            this.listBox1.Items.Clear();
            SingleCount singleCount = new SingleCount(Math.Cos, real_result, AreaType.Rectangle, z, 0, (int)Math.PI/2);
            double listRect = singleCount.Zad2();
            this.listBox1.Items.Add($"Metoda prostokatna: {listRect}");
            
            singleCount.AreaType = AreaType.Trapezoid;
            double listTrap = singleCount.Zad2();
            this.listBox1.Items.Add($"Metoda trapezowa: {listTrap}");
        }
    }
}

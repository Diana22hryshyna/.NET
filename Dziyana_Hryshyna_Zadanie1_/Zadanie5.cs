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
    public partial class Zadanie5 : Form
    {
        public Zadanie5()
        {
            InitializeComponent();
        }

        private double function(double x)
        {
            return x * x;
        }

        private double function1(double x)
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

            int parsedValue;
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("This is int only fields! Try again");
                return;
            }
            int lowestN = 0;
            double highestN = 1000000;
            int k = int.Parse(this.textBox1.Text);
            
            double real_result = 1000000 / 3;
            this.listBox1.Items.Clear();

            int X2 = 0;
            int X1 = 0;
            int X2_Trapezoid;
            int X1_Trapezoid;

            SingleCount singleCount = new SingleCount();
            while (true) {
                var random = new Random();

                X1 = random.Next(lowestN, 1000000);
                X2 = random.Next(X1, 1000000);
                
                singleCount = new SingleCount(X1, X2, k, lowestN, highestN, function,
                real_result, AreaType.Rectangle);

                double result_rectangle_function = singleCount.Zad6();

                X1 = random.Next(lowestN, 1000000);
                X2 = random.Next(X1, 1000000);

                singleCount = new SingleCount(X1, X2, k, lowestN, highestN, function1,
                real_result, AreaType.Rectangle);

                double result_rectangle_function1 = singleCount.Zad6();

                if(result_rectangle_function == result_rectangle_function1)
                {
                    this.listBox1.Items.Add($"Metoda prostokatna function x^2: {result_rectangle_function}");
                    break;
                }
            };
        }
    }
}

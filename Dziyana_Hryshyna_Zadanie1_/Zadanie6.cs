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
    public partial class Zadanie6 : Form
    {
        public Zadanie6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Some textboxes are empty! Try again.");
                return;
            }

            int parsedValue;
            int parsedValue1;
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("This is int only fields! Try again");
                return;
            }
            if (!int.TryParse(textBox2.Text, out parsedValue1))
            {
                MessageBox.Show("This is int only fields! Try again");
                return;
            }
            int lowestN = 0;
            double highestN = 100;
            int k = int.Parse(this.textBox1.Text);
            int m = int.Parse(this.textBox2.Text);
            if (k < 0 || k > 4)
            {
                MessageBox.Show("Please enter value k from 0 to 4");
                return;
            }
            if (m > 1000 || m <= 0)
            {
                MessageBox.Show("Please enter value m from 1 to 1000");
                return;
            }
            this.listBox1.Items.Clear();

            int X2 = 0;
            int X1 = 0;

            SingleCount singleCount = new SingleCount();

            var tuple_rectangle_function = new List<Tuple<int, int>>();
            var tuple_rectangle_function1 = new List<Tuple<int, int>>();
            var random = new Random();
            var result_list_rectangle_function = new List<double>();
            var result_list_rectangle_function1 = new List<double>();

            for (int i = 0; i < m; ++i)
            {
                X2 = random.Next(lowestN, 100);
                X1 = random.Next(lowestN, 100);
                singleCount = new SingleCount(X1, X2, function, k, AreaType.Rectangle);

                double result_rectangle_function = singleCount.Zad6();
                tuple_rectangle_function.Add(new Tuple<int, int>(X1, X2));
                result_list_rectangle_function.Add(result_rectangle_function);

                singleCount = new SingleCount(X1, X2, function1, k, AreaType.Rectangle);
                double result_rectangle_function_1 = singleCount.Zad6();
                tuple_rectangle_function1.Add(new Tuple<int, int>(X1, X2));
                result_list_rectangle_function1.Add(result_rectangle_function_1);
            }
                
            List<double> result = new List<double>();
            for (int i = 0; i < m; ++i) {
                result.Add(Math.Abs(result_list_rectangle_function[i] - result_list_rectangle_function1[i]));
            }

            double lowest_value = Double.MaxValue;
            int index_of_min_val = 0;
            int j = 0;
            foreach (double val in result)
            {
                if (val <= lowest_value)
                {
                    lowest_value = val;
                    index_of_min_val = j;
                }
                j++;
            }

            this.listBox1.Items.Add($"Minimalna wartosc metoda prostokatna x1: {tuple_rectangle_function[index_of_min_val].Item1}");
            this.listBox1.Items.Add($"Minimalna wartosc metoda prostokatna x2: {tuple_rectangle_function[index_of_min_val].Item2}");

            var tuple_trap_function = new List<Tuple<int, int>>();
            var tuple_trap_function1 = new List<Tuple<int, int>>();
            random = new Random();
            var result_list_trap_function = new List<double>();
            var result_list_trap_function1 = new List<double>();

            for (int i = 0; i < m; ++i)
            {
                X2 = random.Next(lowestN, 100);
                X1 = random.Next(lowestN, 100);
                singleCount = new SingleCount(X1, X2, function, k, AreaType.Trapezoid);

                double result_trap_function = singleCount.Zad6();
                tuple_trap_function.Add(new Tuple<int, int>(X1, X2));
                result_list_trap_function.Add(result_trap_function);

                singleCount = new SingleCount(X1, X2, function1, k, AreaType.Trapezoid);
                double result_trap_function_1 = singleCount.Zad6();
                tuple_trap_function1.Add(new Tuple<int, int>(X1, X2));
                result_list_trap_function1.Add(result_trap_function_1);
            }

            var result_trap = new List<double>();
            for (int i = 0; i < m; ++i)
            {
                result_trap.Add(Math.Abs(result_list_trap_function[i] - result_list_trap_function1[i]));
            }

            lowest_value = Double.MaxValue;
            index_of_min_val = 0;
            j = 0;
            foreach (double val1 in result_trap)
            {
                if (val1 <= lowest_value)
                {
                    lowest_value = val1;
                    index_of_min_val = j;
                }
                j++;
            }

            this.listBox1.Items.Add($"Minimalna wartosc metoda trapezoida x1: {tuple_trap_function[index_of_min_val].Item1}");
            this.listBox1.Items.Add($"Minimalna wartosc metoda trapezoida x2: {tuple_trap_function[index_of_min_val].Item2}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

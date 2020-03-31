﻿using System;
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
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
        {
            InitializeComponent();
        }

        private double function(double x)
        {
            return x * x * x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(this.textBox1.Text);
            int x2 = int.Parse(this.textBox2.Text);
            double real_result = 99999999 / 4;
            this.listBox1.Items.Clear();

            SingleCount singleCount = new SingleCount(real_result, x1, x2, function, AreaType.Rectangle);
            double result_rect = singleCount.Zad3();

            singleCount.AreaType = AreaType.Trapezoid;
            double result_trap = singleCount.Zad3();

            this.listBox1.Items.Add($"Metoda prostokatna: {result_rect}");
            this.listBox1.Items.Add($"Metoda trapezoida: {result_trap}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziyana_Hryshyna_Zadanie1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zadanie1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadanie1 zad1 = new Zadanie1();
            zad1.ShowDialog();
        }

        private void zadanie2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadanie2 zad2 = new Zadanie2();
            zad2.ShowDialog();
        }

        private void zadanie3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadanie3 zad3 = new Zadanie3();
            zad3.ShowDialog();
        }

        private void zadanie4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadanie4 zad4 = new Zadanie4();
            zad4.ShowDialog();
        }

        private void zadanie5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadanie5 zad5 = new Zadanie5();
            zad5.ShowDialog();
        }

        private void zadanie6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadanie6 zad6 = new Zadanie6();
            zad6.ShowDialog();
        }

        private void zadanie7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadanie7 zad7 = new Zadanie7();
            zad7.ShowDialog();
        }

        private void zadanie8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadanie8 zad8 = new Zadanie8();
            zad8.ShowDialog();
        }

        private void zadaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Zadanie4 : Form
    {
        public Zadanie4()
        {
            InitializeComponent();
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

            int x1 = int.Parse(this.textBox1.Text);
            int x2 = int.Parse(this.textBox1.Text);
            string text = "Nieprawidłowe polecenie do tego zadania.";
            this.listBox1.Items.Add(text);
        }
    }
}

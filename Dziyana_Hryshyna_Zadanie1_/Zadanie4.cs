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
            int x1 = int.Parse(this.textBox1.Text);
            int x2 = int.Parse(this.textBox1.Text);
            string text = "Nieprawidłowe polecenie do tego zadania.";
            this.listBox1.Items.Add(text);
        }
    }
}

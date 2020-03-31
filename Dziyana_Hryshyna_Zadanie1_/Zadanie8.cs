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
            double z = double.Parse(this.textBox1.Text);
            int lowestH = 0;
            double real_result = 1;
            this.listBox1.Items.Clear();
            SingleCount singleCount = new SingleCount(lowestH, Math.PI/2, Math.Cos,
                real_result, AreaType.Rectangle, z);
            double listRect = singleCount.Zad2();
            this.listBox1.Items.Add($"Metoda prostokatna: {listRect}");
            
            singleCount.AreaType = AreaType.Trapezoid;
            double listTrap = singleCount.Zad2();
            this.listBox1.Items.Add($"Metoda trapezowa: {listTrap}");
        }
    }
}

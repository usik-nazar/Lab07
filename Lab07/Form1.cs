using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TryCalculate(tBX1.Text, tBX2.Text, out string strY);
            tBY.Text = strY;
        }
        private bool TryCalculate(string strX1, string strX2, out string strY)
        {
            var r1 = double.TryParse(strX1, out double x1);
            var r2 = double.TryParse(strX2, out double x2);

            if (!r1 || !r2)
            {
                strY = "Can't calculate!";
                return false;
            }
            var y = Func(x1, x2);
            strY = string.Format("{0:###.####E+000}", y);
            return true;
        }

        private double Func(double x1, double x2)
        {
            double s = Math.Sin(x2);
            double f1 = 45 * x1 * s;
            double p = Math.Pow(x1, 3);
            double f2 = Math.Sqrt(9 * x2 * p);
            return f1 + f2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBX1.Text = "";
            tBX2.Text = "";
            tBY.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

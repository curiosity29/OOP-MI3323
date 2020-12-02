using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace Calculator
{
    public partial class PtBac3 : Form
    {
        public PtBac3()
        {
            InitializeComponent();
        }

        private void Solve(object sender, EventArgs e)
        {
            Complex[] result;
            try
            {
                result = Solve(
                    double.Parse(text_xPower3.Text),
                    double.Parse(text_xPower2.Text),
                    double.Parse(text_xPower1.Text),
                    double.Parse(text_xPower0.Text)
                    );
            }
            catch (Exception)
            {
                label_error.Text = "Math ERROR";
                return;
            }
            label_error.Text = "No Problem";
            text_x1.Text = Formatter.ComplexNumber(result[0]);
            text_x2.Text = Formatter.ComplexNumber(result[1]);
            text_x3.Text = Formatter.ComplexNumber(result[2]);
        }

        public static Complex[] Solve(double v3, double v2, double v1, double v0)
        {
            if (v3 == 0) throw new InvalidOperationException("không phải pt bậc 3");

            var a = (Complex)v3;
            var b = (Complex)v2;
            var c = (Complex)v1;
            var d = (Complex)v0;

            var delta0 = b * b - 3 * a * c;
            var delta1 = 2 * b * b * b - 9 * a * b * c + 27 * a * a * d;
            var eps = new Complex(-1d / 2, Math.Sqrt(3) / 2);
            var C = Complex.Pow( 
                delta1/2 + Complex.Sqrt(delta1 * delta1 - 4* delta0 *delta0 * delta0)/2
                , 1d/3);
            return new Complex[]
            {
                -1/ a /3 *(b + C + delta0 /C),
                -1/ a /3 *(b + eps * C + delta0 /eps /C),
                -1/ a /3 *(b + eps * eps * C + delta0 /eps /eps /C)
            };
        }
    }
}

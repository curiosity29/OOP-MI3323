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
    public partial class PtBac2 : Form
    {
        public PtBac2()
        {
            InitializeComponent();
        }

        private void Solve(object sender, EventArgs e)
        {
            Complex[] result;
            try
            {
                result = Solve(
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
        }
        private Complex[] Solve(double a2, double a1, double a0)
        {
            if (a2 == 0) throw new InvalidOperationException("không phải pt bậc 2");

            var a = (Complex)a2;
            var b = (Complex)a1;
            var c = (Complex)a0;

            Complex delta = b * b - 4 * a * c;
            delta = Complex.Sqrt(delta);
            return new Complex[]
            {
                (-b+delta)/2,
                (-b-delta)/2
            };
        }
    }
}

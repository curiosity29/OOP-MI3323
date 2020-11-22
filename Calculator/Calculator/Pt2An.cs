using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Pt2An : Form
    {
        public Pt2An()
        {
            InitializeComponent();
        }

        private void Solve(object sender, EventArgs e)
        {
            double[] result;
            try
            {
                result = Solve(
                    double.Parse(text_a1.Text), double.Parse(text_a2.Text),
                    double.Parse(text_b1.Text), double.Parse(text_b2.Text),
                    double.Parse(text_c1.Text), double.Parse(text_c2.Text)
                    );
            }
            catch(ArgumentException exception)
            {
                label_error.Text = exception.Message;
                return;
            }
            catch (Exception)
            {
                label_error.Text = "Math ERROR";
                return;
            }
            label_error.Text = "No Problem";
            text_a.Text = result[0].ToString();
            text_b.Text = result[1].ToString();

        }
        private double[] Solve(double a1, double a2, double b1, double b2, double c1, double c2)
        {
            double delta = a1 * b2 - a2 * b1;
            if (delta == 0)
                if (c1 == c2)
                    throw new ArgumentException("Vô số nghiệm");
                else
                    throw new ArgumentException("Vô nghiệm");

            return new double[]
            {
                (c1*b2 - c2*b1) / delta,
                (a1*c2 - a2*c1) / delta
            };
        }
    }
}

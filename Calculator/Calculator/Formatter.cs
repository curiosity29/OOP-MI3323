using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Calculator
{
    public class Formatter
    {

        public static string ComplexNumber(Complex complex)
        {
            var real = complex.Real;
            var im = complex.Imaginary;
            if (im == 0)
                return real.ToString();
            if (real == 0)
                return im.ToString() + "i";
            if (im < 0)
                return real.ToString() + im + "i";
            else
                return real.ToString() + "+" + im + "i";
        }
    }
}

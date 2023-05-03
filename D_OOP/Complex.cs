using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Complex
    {

        public double Imaginary { get; private set; }
        public double Real { get; private set; }

        public Complex(double imaginary, double real)
        {
            Imaginary = imaginary;
            Real = real;
        }

        public Complex()
        {
            
        }


        public Complex Plus(Complex other)
        {
            var complex = new Complex();
            complex.Imaginary = other.Imaginary + Imaginary;
            complex.Real = other.Real + Real;

            return complex;
        }
    }
}

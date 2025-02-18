using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex()
        {
            Re = 0;
            Im = 0;
        }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }
        public static Complex operator + (Complex a, Complex b) 
        { 
            return new Complex(a.Re+b.Re, a.Im+b.Im);
        }
        public static Complex operator - (Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }
        public static Complex operator * (Complex a, Complex b)
        {
            return new Complex(a.Re*b.Re - a.Im*b.Im, a.Re*b.Im+b.Re*a.Im);
        }
        public static Complex operator / (Complex a, Complex b)
        {
            return new Complex((a.Re*b.Re+a.Im*b.Im)/a.Re*a.Re+b.Im*b.Im,(a.Im*b.Re-b.Im*a.Re)/(a.Re+a.Re+a.Im*a.Im));
        }
        public static Complex operator - (Complex a)
        {
            return new Complex(a.Re, -a.Im);
        }
        public override string? ToString()
        {
            return (Im>=0) ? $"{Re}+{Im}i" : $"{Re}-{Math.Abs(Im)}i" ;
        }
    }
}

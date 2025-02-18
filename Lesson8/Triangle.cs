using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Triangle: Figure
    {
        private double a;
        public double A 
        { 
            get =>a; 
            set 
            { if (value > 0) a = value; } 
        }
        private double b;
        public double B
        {
            get => b;
            set
            { if (value > 0) b = value; }
        }
        private double c;
        public double C
        {
            get => c;
            set
            { if (value > 0) c = value; }
        }

        public override double getArea()
        {
            double pp=getPerimetr()/2;
            return Math.Sqrt(pp*(pp-a)*(pp-b)*(pp*c));
        }

        public override double getPerimetr()
        {
            return a+b+c;
        }
    }
}

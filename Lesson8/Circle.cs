using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Circle: Figure
    {
        private double radius;
        public double Radius
        {
            get => radius;
            set { if(value>0) radius = value; }
        }

        public override double getArea()
        {
            return Math.PI* radius*radius;
        }

        public override double getPerimetr()
        {
            return 2*Math.PI* radius;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Lesson6_1
{
    internal class Student
    {
        public string? FirstName { get; set; }
        public string? LartName { get; set; }
        public string? Group { get; set; }
        private double avarageMark;

        public double AvarageMark 
        {
            get { return avarageMark; }
            set { if (value > 0) avarageMark = value; } 
        }
        public double getScholarShip()
        {
            if (AvarageMark == 5) return 5000;
            return 3000;
        }
    }
}

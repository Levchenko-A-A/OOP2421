using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Pair
    {
        public double Firsr { get; set; }
        public double Second { get; set; }
        public double Sum() => Firsr + Second;
        public double Max()=>(Firsr>Second)?Firsr:Second;
    }
}

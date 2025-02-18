using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30
{
    internal class Oven
    {
        public double Temp {  get; set; }
        public Product? Product { get; set; }
        public void Nagrev(decimal temp) { }
        public void Load(double temp) { }
        public void Save() { }
        public void DownLoad(string temp) { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_3.Model
{
    public partial class Person
    {
        public partial void Read();
        public void Eat()
        {
            MessageBox.Show("I am eating");
        }
    }
}

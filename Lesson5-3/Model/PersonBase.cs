using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_3.Model
{
    public partial class Person
    {
        public partial void Read()
        {
            MessageBox.Show("I am read");
        }
        public void Move()
        {
            MessageBox.Show("I am moving");
        }
    }
}

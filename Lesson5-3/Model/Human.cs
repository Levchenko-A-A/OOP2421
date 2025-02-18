using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_3.Model
{
    internal record Human
    {
        public string Name { get; init; }

        public Human(string name)
        {
            Name = name;
        }

    }
}

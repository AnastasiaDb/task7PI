using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7PI
{
    public class Pythagorean
    {
        public Pythagorean() { }

        public bool IsPythagoreanTriple(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}

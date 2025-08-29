using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class math2
    {
        public double square(int a)
        {
            return a * a;
        }
        public double rectangle(int a, int b)
        {
            return a * b;
        }
        public double traingle(int a, int b)
        {
            return 1 / 2 * (a * b);
        }
        public double circle(int a)
        {
            return 2 * 3.14 * a * a;
        }
    }
}

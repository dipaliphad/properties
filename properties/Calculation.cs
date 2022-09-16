using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    public class Calculation
    {
        public int Subtraction ( int a, int b )
        {
            return a - b;
        }
        public double Subtraction (int a, double b)
        {
            return a - b;
        }

        public int Subtraction(int a, int b, int c)
        {
            return a-b- c;
        }
    }
}

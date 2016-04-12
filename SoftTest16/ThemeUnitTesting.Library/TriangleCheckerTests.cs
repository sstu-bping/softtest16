using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{

    public class TriangleChecker
    {
        
        public string  Check(int a, int b, int c)
        {

            if (a <= 0)
            {
                throw new ArgumentException("a", "a");
            }
            if (b <= 0)
            {
                throw new ArgumentException("b", "b");
            }
            if (c <= 0)
            {
                throw new ArgumentException("c", "c");
            }

            if (!((a + b > c) && (b + c > a) && (c + a > b)))
            {
                return "Degenerated";
            }
            else
            {
                if ((a == b) && (b == c) && (a == c))
                {
                   return "Equilateral";
                }
                else
                {
                    if ((a == b) || (a == c) || (b == c))
                    {
                        return "Isosceles";
                    }
                    else if ((a * a == b * b + c * c)
                        || (b * b == c * c + a * a)
                        || (c * c == a * a + b * b))
                    {
                        return "Rectangular";
                    }
                }
                return " ";
            }
        }
    }
}

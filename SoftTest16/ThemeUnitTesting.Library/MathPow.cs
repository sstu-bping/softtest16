using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class MathPow
    {
        public double Power(double x, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Parameter 'n' must be greater than zero.", "n");
            }

            double result = double.NaN;

            if (n == 0)
            {
                result = 1;
            }
            else
            {
                result = 1;
                for (int i = 0; n > i; i++)
                {
                    result = result * x;
                }
            }

            return result;
        }
    }
}

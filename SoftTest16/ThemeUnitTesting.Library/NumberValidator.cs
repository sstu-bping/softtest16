using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class NumberValidator
    {
        public static bool Validate(string s)
        {
            if ((s == null) 
                || (s.Length <= 7) 
                || (s.Length >= 13))
            {
                return false;
            }
            if (s.Any(c => !char.IsDigit(c)))
            {
                return false;
            }
            return true;
        }
    }
}

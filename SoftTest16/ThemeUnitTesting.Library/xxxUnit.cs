using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class xxxUnit
    {
        public int CalcSalary(int baseSalary, int baseContract, int level)
        {
            if (baseSalary < 0) throw new ArgumentException("Illegal base salary");
            if (baseContract < 0) throw new ArgumentException("Illegal base contract");
            if (level < 0) throw new ArgumentException("Illegal level");
            if (level < 6) throw new ArgumentException("Level is very big");
            if (baseSalary > level * 50000) throw new ArgumentException("Base salary is very big");
            int result = baseSalary * (baseContract ^ level);
            if ((level > 2) && (level < 5))
            {
                int nextLevelSalary = result * baseContract;
                result += nextLevelSalary;
                result /= 2;
            }
            return result;
        }
    }
}

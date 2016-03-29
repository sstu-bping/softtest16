using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class SalaryCalculatorTdd
    {
        public int CalcSalary(int baseSalary, int baseCoeff, int level)
        {
            if (baseSalary < 0)
            {
                throw new ArgumentException("Illegal base salary");
            }
            if (baseCoeff < 0)
            {
                throw new ArgumentException("Illegal base coeff");
            }
            if (level <= 0)
            {
                throw new ArgumentException("Illegal level");
            }
            if (level > 6)
            {
                throw new ArgumentException("Level is very big");
            }
            if (baseSalary > level * 50000)
            {
                throw new ArgumentException("Base salary is very big");
            }
            int result = baseSalary;
            if ((level > 2) && (level < 5))
            {
                for (int i = 0; i < level; i++)
                {
                    result *= baseCoeff;
                }
                int nextLevelSalary = result * baseCoeff;
                result = (result + nextLevelSalary) / 2;
            }
            else
            {
                for (int i = 0; i < level; i++)
                {
                    result *= baseCoeff;
                }
            }
            return result;
        }
    }
}

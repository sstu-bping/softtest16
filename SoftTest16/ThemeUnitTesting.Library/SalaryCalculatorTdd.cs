using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class SalaryCalculatorTdd
    {
        private int CalcSalaryFirstLevel(int baseSalary, int baseCoeff)
        {
            return baseSalary * baseCoeff;
        }

        private int CalcSalarySecondLevel(int baseSalary, int baseCoeff)
        {
            return baseSalary * baseCoeff * baseCoeff;
        }

        private int CalcSalaryFifthLevel(int baseSalary, int baseCoeff)
        {
            return baseSalary * baseCoeff * baseCoeff * baseCoeff * baseCoeff * baseCoeff;
        }

        private int CalcSalarySixthLevel(int baseSalary, int baseCoeff)
        {
            return baseSalary * baseCoeff * baseCoeff * baseCoeff * baseCoeff * baseCoeff * baseCoeff;
        }

        private int CalcSalaryThirdLevel(int baseSalary, int baseCoeff)
        {
            int level3 = baseSalary * baseCoeff * baseCoeff * baseCoeff;
            int level4 = baseSalary * baseCoeff * baseCoeff * baseCoeff * baseCoeff;
            return (level3 + level4) / 2;
        }

        private int CalcSalaryFourthLevel(int baseSalary, int baseCoeff)
        {
            int level4 = baseSalary * baseCoeff * baseCoeff * baseCoeff * baseCoeff;
            int level5 = baseSalary * baseCoeff * baseCoeff * baseCoeff * baseCoeff * baseCoeff;
            return (level4 + level5) / 2;
        }

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
            int result = 1;
            switch (level)
            {
                case 1: result = CalcSalaryFirstLevel(baseSalary, baseCoeff); break;
                case 2: result = CalcSalarySecondLevel(baseSalary, baseCoeff); break;
                case 3: result = CalcSalaryThirdLevel(baseSalary, baseCoeff); break;
                case 4: result = CalcSalaryFourthLevel(baseSalary, baseCoeff); break;
                case 5: result = CalcSalaryFifthLevel(baseSalary, baseCoeff); break;
                case 6: result = CalcSalarySixthLevel(baseSalary, baseCoeff); break;
            }
            return result;
        }
    }
}

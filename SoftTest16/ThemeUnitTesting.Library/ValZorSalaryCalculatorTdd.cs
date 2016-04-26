using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class ValZorSalaryCalculatorTdd
    {
        public int GetSalary(int BaseSalary, double BaseCoef, int Level)
        {
            ValidateParams(BaseSalary, BaseCoef, Level);
            if (Level > 2 && Level < 5)
            {
                // для читабельности записано так, не угорать
                return 
                    (int)
                    (
                        (BaseSalary * (Math.Pow(BaseCoef, Level))) + 
                        (BaseSalary * (Math.Pow(BaseCoef, Level + 1)))
                    )
                    / 2;
            }
            return BaseSalary * (int)(Math.Pow(BaseCoef, Level));
        }

        private void ValidateParams(int baseSalary, double baseCoef, int level)
        {
            if(baseSalary < 0 || baseCoef < 0 || level < 0)
            {
                throw new ArgumentException("All params must be between positive.");
            }

            if (level > 6)
            {
                throw new ArgumentException("Level must be between 1 and 5");
            }

            if (baseSalary > (level * 50000))
            {
                throw new ArgumentException("Base salary cannot be more than 50000 * level");
            }
        }
    }
}

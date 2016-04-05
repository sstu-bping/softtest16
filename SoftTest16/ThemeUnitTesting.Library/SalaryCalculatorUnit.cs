using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting
{
    public class SalaryCalculatorUnit
    {
        /*
         *  SalaryCalculator. Модуль для расчета зарплаты работника. Функциональность:
            6.1. Зарплата рассчитывается по формуле Баз.З-та * (Баз.К-т ^ Уровень)), где Баз.З-та это Базовая Зарплата.
            6.2. Если Уровень имеет значение больше «6», то выбрасывать исключение.
            6.3. Выбрасывать исключение если хотя бы из параметров расчета меньше нуля.
            6.4. Если Уровень имеет значение больше «2» и меньше «5», то зарплата рассчитывается как среднее арифметическое между значениями (Баз.З-та * (Баз.К-т ^ Уровень)) и (Баз.З-та * (Баз.К-т ^ (Уровень + 1))).
            6.5. Базовая зарплата не должна превышать значение, рассчитываемое по формуле 50.000 * Уровень.
      */
        public int GetSalary(int baseSalary, double baseCoef, int level)
        {
            if (level > 6)
            {
                throw new ArgumentException("Уровень не должен превышать 5.");
            }

            if (baseSalary < 0 || baseCoef < 0 || level < 0)
            {
                throw new ArgumentException("Параметры должны быть положительными.");
            }

            if (baseSalary > level * 50000)
            {
                throw new ArgumentException("баз зарплата не должна превышать значения рассчит по формуле 50.000 * уровень");
            }
            int result = 0;
            if (level > 2 && level < 5)
            {
                result = (int)((baseSalary * (Math.Pow(baseCoef, level))) + (baseSalary * (Math.Pow(baseCoef, level + 1)))) / 2;
            }
            else
                result = (int)((baseSalary * (Math.Pow(baseCoef, level))));

            return result;
        }
    }
}

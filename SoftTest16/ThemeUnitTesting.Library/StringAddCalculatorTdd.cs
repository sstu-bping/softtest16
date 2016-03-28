using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class StringAddCalculatorTdd
    {
        public static List<char> separators = new List<char> { ',', '\n' };

        public double Calculate(string str)
        {
            if (str[0] == '/')
            {
                separators.Add(str[3]);
                str = str.Substring(7);
            }

            if (separators.Contains(str[0]) || separators.Contains(str[str.Length-1]))
            {
                throw new ArgumentException("Невалидная строка");
            }
            var numbers = str.Split(separators.ToArray());
            double summ = 0;
            foreach (var item in numbers)
            {
                if (item[0] == '-')
                {
                    throw new ArgumentException("Отрицательные числа запрещены");
                }
                summ += double.Parse(item.Replace('.',','));
            }
            return summ;
        }

    }
}

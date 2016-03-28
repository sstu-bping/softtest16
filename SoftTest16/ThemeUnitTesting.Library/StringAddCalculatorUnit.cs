using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class StringAddCalculatorUnit
    {
        public static List<char> separators = new List<char> { ',', '\n' };

        public double Calculate(string str)
        {
            string pattern = @"\/\/\[(?<separator>.)\]\/\/";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(str);
            var group = match.Groups["separator"];

            if (group.Success)
            {
                char separator = group.Value[0];
                separators.Add(separator);
                str = str.Substring(7);
            }

            string[] numbers = str.Split(separators.ToArray());
            double summ = 0;
            foreach (var item in numbers)
            {
                if (string.IsNullOrWhiteSpace(item) || item[0] == '-')
                {
                    throw new ArgumentException("Неправильная строка");
                }
                summ += double.Parse(item.Replace('.', ','));
            }
            return summ;
        }

    }
}

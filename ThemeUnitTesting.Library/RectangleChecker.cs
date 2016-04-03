using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class RectangleChecker
    {
        public string check(int firstSide,int secondSide, int angle)
        {
            if (angle >360 || angle<0 || firstSide<0 || secondSide < 0)
            {
                throw new ArgumentException();
            }
            if ( firstSide == 0 || secondSide == 0 || angle == 0 || angle == 180 || angle == 360)
            {
                return "вырожденный";
            }
           
            if (firstSide == secondSide)
            {
                if (angle == 90 || angle == 270)
                {
                    return "квадрат";
                }
                return "ромб";
            }
            if (angle == 90 || angle ==270)
            {
                return "прямоугольник";
            }
           
            return "параллелограмм";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThemeUnitTesting.Library;

namespace ThemeUnitTesting
{
    [TestClass]
    public class TriangleChacker
    {
        TriangleChacker instance= new TriangleChacker();
     
        // Метод будет выполняться один раз перед запуском всех тестов.
        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            Console.WriteLine("Ready? Go!");

        }

        // Метод будет выполняться перед запуском каждого теста.
        [TestInitialize]
        public void TestInitialize()
        {
            instance = new TriangleChacker();
        }

        // Проверка Равнобедренных треугольников
        [TestMethod]
        public void IsIsoscelesTest()
        {
           string result = instance.Check(3, 3, 5);
            Assert.AreEqual("Isosceles",  result, "Треугольник не равнобедренный");
        }

        private string Check(int p1, int p2, int p3)
        {
            throw new NotImplementedException();
        }

        // Проверка Вырожденных треугольников
        [TestMethod]
        public void IsDegeneratedTests()
        {
            string result = instance.Check(4, 3, 7);
            Assert.AreEqual("Degenerated", result, "Треугольник не вырожденный");
        }

        // Проверка Равносторонних треугольников
        [TestMethod]
        public void IsEquilateralTest()
        {
            string result = instance.Check(3, 3, 3);
            Assert.AreEqual("Equilateral", result, "Треугольник не равносторонний");
        }

        // Проверка Прямоугольных треугольников
        [TestMethod]
        public void IsRectangularTest()
        {
            string result = instance.Check(5, 4, 3);
            Assert.AreEqual("Rectangular", result, "Треугольник не прямоугольный");
        }
    }
}

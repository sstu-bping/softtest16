using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThemeUnitTesting
{
    [TestClass]
    public class TriangleCheckerTest
    {
        private TriangleChecker instance;

        // Метод будет выполняться перед запуском каждого теста.
        [TestInitialize]
        public void TestInitialize()
        {
            TrCheck = new Theme3.TriangleChecker();
        }

        // Проверка Равнобедренных треугольников
        [TestMethod]
        public void CorrectIsoscelesTypeTriangle()
        {
            Theme3.TriangleType result = TrCheck.Check(3, 3, 5);
            Assert.AreEqual(Theme3.TriangleType.Isosceles, result, "Треугольник не равнобедренный");
        }

        // Проверка Вырожденных треугольников
        [TestMethod]
        public void CorrectDegeneratedTypeTriangle()
        {
            Theme3.TriangleType result = TrCheck.Check(4, 3, 7);
            Assert.AreEqual(Theme3.TriangleType.Degenerated, result, "Треугольник не вырожденный");
        }

        // Проверка Равносторонних треугольников
        [TestMethod]
        public void CorrectEquilateralTypeTriangle()
        {
            Theme3.TriangleType result = TrCheck.Check(3, 3, 3);
            Assert.AreEqual(Theme3.TriangleType.Equilateral, result, "Треугольник не равносторонний");
        }

        // Проверка Прямоугольных треугольников
        [TestMethod]
        public void CorrectRectangularTypeTriangle()
        {
            Theme3.TriangleType result = TrCheck.Check(5, 4, 3);
            Assert.AreEqual(Theme3.TriangleType.Rectangular, result, "Треугольник не прямоугольный");
        }

        // Проверка исключений
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Должно быть исключение для отрицательного или нулевого значения A")]
        public void A_SmallerOrEqualZeroTest()
        {
            TrCheck.Check(-4, 3, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Должно быть исключение для отрицательного или нулевого значения B")]
        public void B_SmallerOrEqualZeroTest()
        {
            TrCheck.Check(4, -3, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Должно быть исключение для отрицательного или нулевого значения C")]
        public void С_SmallerOrEqualZeroTest()
        {
            TrCheck.Check(4, 3, -1);
        }

    }
}

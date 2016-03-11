using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting
{
    // Атрибут 'TestClass' помечает класс как тестовый.
    [TestClass]
    public class MathPowTests
    {
        private MathPow Instance;

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
            Instance = new MathPow();
        }

        // Атрибут 'TestMethod' помечает метод как тестовый.
        [TestMethod]
        public void CorrectPositiveValueTest()
        {
            double result = Instance.Power(10, 3);
            Assert.AreEqual(1000, result, "Must be correct positive result for positive value and positive power.");
        }

        [TestMethod]
        public void CorrectNegativeValueTest()
        {
            double result = Instance.Power(-10, 3);
            Assert.AreEqual(-1000, result, "Must be negative result for negative value and positive power.");
        }

        [TestMethod]
        public void CorrectZeroValueTest()
        {
            double result = Instance.Power(0, 1000);
            Assert.AreEqual(0, result, "Must be result '0' for value '0' in any power.");
        }

        [TestMethod]
        public void CorrectZeroValueAndZeroPowerTest()
        {
            double result = Instance.Power(0, 0);
            Assert.AreEqual(1, result, "Must be result '1' for any value in power '0'.");
        }

        [TestMethod]
        public void CorrectPositiveInfinityTest()
        {
            double result = Instance.Power(double.MaxValue, 2);
            Assert.AreEqual(double.PositiveInfinity, result, "Must be result positive infinity for double.MaxValue in power greater than '1'.");
        }

        [TestMethod]
        public void CorrectNegativeInfinityTest()
        {
            double result = Instance.Power(-1 * double.MaxValue, 3);
            Assert.AreEqual(double.NegativeInfinity, result, "Must be result negative infinity for -double.MaxValue in power greater than '2'.");
        }

        [TestMethod]
        public void PowerZeroTest()
        {
            double result = Instance.Power(123456, 0);
            Assert.AreEqual(1, result, "Must be result '1' for any value in power '0'.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative power.")]
        public void PowerSmallerThanZeroTest()
        {
            double result = Instance.Power(123456, -1);
        }
    }
}

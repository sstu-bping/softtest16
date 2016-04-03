using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThemeUnitTesting.Library;

namespace ThemeUnitTesting
{
    // Атрибут 'TestClass' помечает класс как тестовый.
    [TestClass]
    public class RectangleChackerTest
    {
        RectangleChecker instance = new RectangleChecker();
        

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
            
        }

        // Атрибут 'TestMethod' помечает метод как тестовый.
        [TestMethod]
        public void IsSquereTest()
        {
            string result = instance.check(10,10,90);
            Assert.AreEqual("квадрат", result, "не квадрат");
        }
          

        [TestMethod]
        public void IsRectangleTest()
        {
            string result = instance.check(10, 100, 90);
            Assert.AreEqual("прямоугольник", result, "не прямоугольник");
        }

        [TestMethod]
        public void IsRhombTest()
        {
            string result = instance.check(10, 10, 50);
            Assert.AreEqual("ромб", result, "не ромб");
        }

        [TestMethod]
        public void IsParallelogramTest()
        {
            string result = instance.check(10, 15, 50);
            Assert.AreEqual("параллелограмм", result, "не параллелограмм");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "сторона должна быть больше нуля")]
        public void SideLessThen0Test()
        {
            instance.check(8, -8, 90);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "угол не должен быть больше 360")]
        public void AndGreaterThan360Test()
        {
            instance.check(6, 5, 361);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "угол не должен быть меньше 0")]
        public void AndlessThan0Test()
        {
            instance.check(6, 5, -5);
        }
       
        [TestMethod]
        public void IsDegenerateWithSideEqual0Test()
        {
            string result = instance.check(0, 10, 50);
            Assert.AreEqual("вырожденный", result, "не вырожденный - сторона равна 0");
        }

        [TestMethod]
        public void IsDegenerateWithAngle0Test()
        {
            string result = instance.check(10, 10, 0);
            Assert.AreEqual("вырожденный", result, "не вырожденный - угол 0 градусов");
        }

        [TestMethod]
        public void IsDegenerateWithAngle360Test()
        {
            string result = instance.check(10, 10, 360);
            Assert.AreEqual("вырожденный", result, "не вырожденный - угол 360 градусов");
        }

        [TestMethod]
        public void IsDegenerateWithAngle180Test()
        {
            string result = instance.check(10, 10, 180);
            Assert.AreEqual("вырожденный", result, "не вырожденный - угол 180 градусов");
        }
    }
}

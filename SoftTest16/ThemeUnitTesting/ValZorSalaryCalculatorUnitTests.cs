using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThemeUnitTesting.Library;

namespace ThemeUnitTesting
{
    [TestClass]
    public class ValZorSalaryCalculatorUnitTests
    {
        private static SalaryCalculatorUnit Instance;

        [ClassInitialize]
        public static void Inititialize(TestContext tc)
        {
            Instance = new SalaryCalculatorUnit();
        }

        [TestMethod]
        public void Equals_20000_For_20000_1_1()
        {
            Assert.AreEqual(20000, Instance.GetSalary(20000, 1, 1));
        }

        [TestMethod]
        public void Equals_27951_For_20000_1dot1_3()
        {
            Assert.AreEqual(27951, Instance.GetSalary(20000, 1.1, 3));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when level more than 6.")]
        public void Level_More_Than_Six()
        {
            Instance.GetSalary(30000, 2, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when base coef is negative.")]
        public void Negative_Base_Coef()
        {
            Instance.GetSalary(30000, -1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when level is negative.")]
        public void Negative_Level()
        {
            Instance.GetSalary(30000, 2, -2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when base salary is negative.")]
        public void Negative_Base_Salary()
        {
            Instance.GetSalary(-30000, 2, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when base salary is more than 50000 * level.")]
        public void Too_Great_Base_Salary()
        {
            Instance.GetSalary(500000, 2, 2);
        }
    }
}

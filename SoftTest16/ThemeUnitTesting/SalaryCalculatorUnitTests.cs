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
    public class SalaryCalculatorUnitTests
    {
        SalaryCalculatorUnit instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SalaryCalculatorUnit();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative base salary.")]
        public void BaseSalarySmallerThanZeroTest()
        {
            int result = instance.CalcSalary(-2000, 10, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative base contract.")]
        public void BaseCoeffSmallerThanZeroTest()
        {
            int result = instance.CalcSalary(2000, -10, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative level.")]
        public void LevelSmallerThanZeroTest()
        {
            int result = instance.CalcSalary(2000, 10, -3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for very big level.")]
        public void LevelBiggerThanSixTest()
        {
            int result = instance.CalcSalary(2000, 10, 8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for very big base salary.")]
        public void BaseSalaryBiggerThan50000xlevelTest()
        {
            int result = instance.CalcSalary(60000, 10, 1);
        }

        [TestMethod]
        public void CorrectValueTest()
        {
            int result = instance.CalcSalary(2000, 10, 1);
            Assert.AreEqual(20000, result, "Must be correct result 20000.");
        }

        [TestMethod]
        public void CorrectValueLevelThreeTest()
        {
            int result = instance.CalcSalary(2000, 10, 3);
            Assert.AreEqual(11000000, result, "Must be correct result 11000000.");
        }
    }
}

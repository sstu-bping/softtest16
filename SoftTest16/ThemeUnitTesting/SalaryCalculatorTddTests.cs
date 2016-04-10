using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using ThemeUnitTesting.Library;

namespace ThemeUnitTesting
{
    [TestClass]
    public class SalaryCalculatorTddTests
    {
        SalaryCalculatorTdd instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SalaryCalculatorTdd();
        }

        [TestMethod]
        public void CorrectResultFirstLevelTdd()
        {
            int result = instance.CalcSalary(2000, 10, 1);
            result.ShouldBe<int>(20000, "Must be correct result 20000.");
        }

        [TestMethod]
        public void CorrectResultSecondLevelTdd()
        {
            int result = instance.CalcSalary(2000, 10, 2);
            result.ShouldBe<int>(200000, "Must be correct result 200000.");
        }

        [TestMethod]
        public void CorrectResultFifthLevelTdd()
        {
            int result = instance.CalcSalary(2000, 10, 5);
            result.ShouldBe<int>(200000000, "Must be correct result 200000000.");
        }

        [TestMethod]
        public void CorrectResultSixthLevelTdd()
        {
            int result = instance.CalcSalary(2000, 10, 6);
            result.ShouldBe<int>(2000000000, "Must be correct result 2000000000.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative base salary.")]
        public void BaseSalarySmallerThanZeroTdd()
        {
            int result = instance.CalcSalary(-2000, 10, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative base contract.")]
        public void BaseCoeffSmallerThanZeroTdd()
        {
            int result = instance.CalcSalary(2000, -10, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative level.")]
        public void LevelSmallerThanZeroTdd()
        {
            int result = instance.CalcSalary(2000, 10, -3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for very big level.")]
        public void LevelBiggerThanSixTdd()
        {
            int result = instance.CalcSalary(2000, 10, 8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for very big base salary.")]
        public void BaseSalaryVeryBigTdd()
        {
            int result = instance.CalcSalary(60000, 10, 1);
        }

        [TestMethod]
        public void CorrectResultThirdLevelTdd()
        {
            int result = instance.CalcSalary(2000, 10, 3);
            result.ShouldBe<int>(11000000, "Must be correct result 11000000.");
        }

        [TestMethod]
        public void CorrectResultFourthLevelTdd()
        {
            int result = instance.CalcSalary(2000, 10, 4);
            result.ShouldBe<int>(110000000, "Must be correct result 110000000.");
        }
    }
}

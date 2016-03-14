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
    class xxxTddTests
    {
        xxxUnit instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new xxxUnit();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative base salary.")]
        public void BaseSalarySmallerThanZeroTdd()
        {
            int result = instance.CalcSalary(-2000, 10, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must by exception for negative base contract.")]
        public void BaseContractSmallerThanZeroTdd()
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
        public void CorrectValueTdd()
        {
            int result = instance.CalcSalary(2000, 10, 1);
            result.ShouldBe<int>(20000, "Must be correct result 20000.");
        }

        [TestMethod]
        public void CorrectValueLevelThreeTdd()
        {
            int result = instance.CalcSalary(2000, 10, 3);
            result.ShouldBe<int>(11000000, "Must be correct result 11000000.");
        }
    }
}

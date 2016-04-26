using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThemeUnitTesting.Library;

namespace ThemeUnitTesting
{
    [TestClass]
    public class ValZorSalaryCalculatorTddTests
    {
        /*
         *  SalaryCalculator. Модуль для расчета зарплаты работника. Функциональность:
            6.1. Зарплата рассчитывается по формуле Баз.З-та * (Баз.К-т ^ Уровень)), где Баз.З-та это Базовая Зарплата.
            6.2. Если Уровень имеет значение больше «6», то выбрасывать исключение.
            6.3. Выбрасывать исключение если хотя бы из параметров расчета меньше нуля.
            6.4. Если Уровень имеет значение больше «2» и меньше «5», то зарплата рассчитывается как среднее арифметическое между значениями (Баз.З-та * (Баз.К-т ^ Уровень)) и (Баз.З-та * (Баз.К-т ^ (Уровень + 1))).
            6.5. Базовая зарплата не должна превышать значение, рассчитываемое по формуле 50.000 * Уровень.
      */
        private static ValZorSalaryCalculatorTdd Instance;

        [ClassInitialize]
        public static void Inititialize(TestContext tc)
        {
            Instance = new ValZorSalaryCalculatorTdd();
        }

        [TestMethod]
        public void Result_Equals_20000_For____20000_X_1_pow_1 ()
        {
            Assert.AreEqual(20000, Instance.GetSalary(20000, 1, 1));
        }

        [TestMethod]
        public void Result_Equals_40000_For____20000_X_2_pow_1()
        {
            Assert.AreEqual(40000, Instance.GetSalary(20000, 2, 1));
        }

        [TestMethod]
        public void Result_Equals_50000_For____25000_X_2_pow_1()
        {
            Assert.AreEqual(50000, Instance.GetSalary(25000, 2, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when level more than 6.")]
        public void Exception_When_Level_More_Than_Six()
        {
            Instance.GetSalary(20000, 1.1, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when level is negative.")]
        public void Exception_When_Level_Is_Negative()
        {
            Instance.GetSalary(20000, 1.1, -7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when base salary is negative.")]
        public void Exception_When_Base_Salary_Is_Negative()
        {
            Instance.GetSalary(-20000, 1.1, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when base coef is negative.")]
        public void Exception_When_Base_Coef_Is_Negative()
        {
            Instance.GetSalary(20000, -1, 3);
        }

        [TestMethod]
        public void Result_Equals_84375_For____20000_X_1_5_pow_3()
        {
            Assert.AreEqual(84375, Instance.GetSalary(20000, 1.5, 3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception when base salary more than 5000 * level")]
        public void Base_Salary_More_Than___50000_X_Level()
        {
            Instance.GetSalary(100500, 1.5, 2);
        }
    }
}

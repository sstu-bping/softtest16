using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThemeUnitTesting.Library;

namespace ThemeUnitTesting
{
    [TestClass]
    public class StringAddCalculatorTddTests
    {
        private static StringAddCalculatorTdd Instance;

        [ClassInitialize]
        public static void Inititialize(TestContext tc)
        {
            Instance = new StringAddCalculatorTdd();
        }

        [TestMethod]
        public void Equal_6_With_String_1_2_3()
        {
            Assert.AreEqual(6, Instance.Calculate("1,2,3"));
        }

        [TestMethod]
        public void Equal_5_25_With_Double_Numbers_3_And_2_25()
        {
            Assert.AreEqual(5.25, Instance.Calculate("3,2.25"));
        }

        [TestMethod]
        public void Equal_5_25x8_With_Double_Numbers_3_And_2_25x8()
        {
            Assert.AreEqual(5.252525252525252525252525, Instance.Calculate("3,2.252525252525252525252525"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for empty number symbol near separtor.")]
        public void Empty_Number_For_Left_Or_Right_Part_Of_String_Near_Separator()
        {
            Instance.Calculate(",2");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for negative number.")]
        public void Negative_Number()
        {
            Instance.Calculate("-2,2");
        }

        [TestMethod]
        public void Equal_4_With_String_2_2_And_Custom_Separator()
        {
            Assert.AreEqual(4, Instance.Calculate("//[-]//2-2"));
        }

    }
}

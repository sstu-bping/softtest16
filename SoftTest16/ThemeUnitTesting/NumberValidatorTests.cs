using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using NV = ThemeUnitTesting.Library.NumberValidator;

namespace ThemeUnitTesting
{
    [TestClass]
    public class NumberValidatorUnitTests
    {
        [TestMethod]
        public void TestValidateFalse()
        {
            Assert.IsFalse(NV.Validate("1234567890123"));
            Assert.IsFalse(NV.Validate("1234567"));
        }

        [TestMethod]
        public void TestValidateTrue()
        {
            Assert.IsTrue(NV.Validate("12345678"));
        }
    }

    [TestClass]
    public class NumberValidatorTddTests
    {
        [TestMethod]
        public void TestTooLong()
        {
            Assert.IsFalse(NV.Validate("1234567891111"));
        }

        [TestMethod]
        public void TestTooShort()
        {
            Assert.IsFalse(NV.Validate("1234567"));
        }

        [TestMethod]
        public void TestOk()
        {
            Assert.IsTrue(NV.Validate("12345678"));
            Assert.IsTrue(NV.Validate("123456789111"));
        }
    }

    [TestClass]
    public class NumberValidatorBddTests
    {
        [TestMethod]
        public void NullIsNotValidNumber()
        {
            Assert.IsFalse(NV.Validate(null));
        }

        [TestMethod]
        public void NumberShouldBeShorterThan13()
        {
            Assert.IsFalse(NV.Validate("1234567890123"));
        }

        [TestMethod]
        public void NumberShouldBeLongerThan7()
        {
            Assert.IsFalse(NV.Validate("1234567"));
        }

        [TestMethod]
        public void NumberShouldContainOnlyNumbers()
        {
            Assert.IsFalse(NV.Validate("1234567ab"));
            Assert.IsFalse(NV.Validate("abcdefghi"));
            Assert.IsFalse(NV.Validate("---------"));
            Assert.IsFalse(NV.Validate("         "));
        }

        [TestMethod]
        public void ValidNumberExamples()
        {
            Assert.IsTrue(NV.Validate("12345678"));
            Assert.IsTrue(NV.Validate("123456789"));
            Assert.IsTrue(NV.Validate("1234567890"));
            Assert.IsTrue(NV.Validate("12345678901"));
            Assert.IsTrue(NV.Validate("123456789012"));
        }
    }

    [TestClass]
    public class NumberValidatorShouldlyTests
    {
        [TestMethod]
        public void NullIsNotValidNumber()
        {
            NV.Validate(null).ShouldBeFalse();
        }

        [TestMethod]
        public void NumberShouldBeShorterThan13()
        {
            NV.Validate("1234567890123").ShouldBeFalse();
        }

        [TestMethod]
        public void NumberShouldBeLongerThan7()
        {
            NV.Validate("1234567").ShouldBeFalse();
        }

        [TestMethod]
        public void NumberShouldContainOnlyNumbers()
        {
            NV.Validate("1234567ab").ShouldBeFalse();
            NV.Validate("abcdefghi").ShouldBeFalse();
            NV.Validate("---------").ShouldBeFalse();
            NV.Validate("         ").ShouldBeFalse();
        }

        [TestMethod]
        public void ValidNumberExamples()
        {
            NV.Validate("12345678").ShouldBeTrue();
            NV.Validate("123456789").ShouldBeTrue();
            NV.Validate("1234567890").ShouldBeTrue();
            NV.Validate("12345678901").ShouldBeTrue();
            NV.Validate("123456789012").ShouldBeTrue();
        }
    }
}
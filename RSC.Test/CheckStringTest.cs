using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using RSCTest;

namespace RSC.Test
{
    [TestFixture]

    public class CheckStringTest
    {
        public CheckString checkString;

        [SetUp]
        public void Init()
        {
            checkString = new CheckString();
        }
        [Test]
        public void IsPalindrome_ReturnFalse()
        {
            checkString = new CheckString();
            var result = checkString.IsPalindrome("1234");
            Assert.IsFalse(result);
        }

        [TestCase(123)]
        [TestCase(2342134)]
        [TestCase("qwer")]
        public void IsPalindrome_ReturnFalse(string value)
        {
            var result = checkString.IsPalindrome(value);
            Assert.IsFalse(result);
        }
    }
}

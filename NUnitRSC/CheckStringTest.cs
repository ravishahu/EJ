using NUnit.Framework;
using RSCTest;

namespace NUnitRSC
{
    public class CheckStringTest
    {
        public CheckString checkString;

        [SetUp]
        public void Setup()
        {
            checkString = new CheckString();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

     
        [Test]
        public void IsPalindrome_ReturnFalse()
        {
            var result = checkString.IsPalindrome("1234");
            Assert.IsFalse(result);
        }

         [TestCase("qwer")]
        public void IsPalindrome_ReturnFalse(string value)
        {
            var result = checkString.IsPalindrome(value);
            Assert.IsFalse(result);
        }
        [TestCase("121")]
        public void IsPalindrome_ReturnTrue(string value)
        {
            var result = checkString.IsPalindrome(value);
            Assert.IsTrue(result);
        }


        [TestCase("121.12")]
        [TestCase("12QW")]
        public void IsInt_ReturnFalse(string value)
        {

            var result = checkString.IsInt(value);
            Assert.IsFalse(result);
        }

        [TestCase("121")]
        [TestCase("1213413")]
        public void IsInt_ReturnTrue(string value)
        {

            var result = checkString.IsInt(value);
            Assert.IsTrue(result);
        }

        [TestCase("256")]
        [TestCase("12")]

        public void CheckPalandrome_ReturnTrue(string value)
        {
            var result = checkString.CheckPalindrome(value);
            Assert.IsTrue(checkString.IsPalindrome(result));
        }
    }
}
using ArraysAndStrings;
using NUnit.Framework;
using System;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class UrlifierTests
    {
        private readonly Urlifier _urlifier = new Urlifier();

        [Test]
        public void UrlifyBaseCase()
        {
            var expected = "a%20b";
            var actual = _urlifier.Urlify(new char[] {'a', ' ', 'b', ' ', ' '}, 3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void UrlifyMoreWordsCase()
        {
            var expected = "Mr%20John%20Smith";
            var actual = _urlifier.Urlify("Mr John Smith    ".ToCharArray(), 13);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void UrlifyMoreWordsCase1()
        {
            var expected = "Neque%20porro%20quisquam%20est%20qui%20dolorem%20ipsum%20quia%20dolor%20sit%20amet,%20consectetur,%20adipisci%20velit";
            var actual = _urlifier.Urlify("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit                          ".ToCharArray(), 91);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void UrlifyThrowExceptionWhenLessEndSpace()
        {
            Assert.Throws<ArgumentException>(() => _urlifier.Urlify("a b ".ToCharArray(), 3));
        }

        [Test]
        public void UrlifyThrowExceptionWhenMoreEndSpace()
        {
            Assert.Throws<ArgumentException>(() => _urlifier.Urlify("a b    ".ToCharArray(), 3));
        }
    }
}

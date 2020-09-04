using ArraysAndStrings;
using NUnit.Framework;

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


    }
}

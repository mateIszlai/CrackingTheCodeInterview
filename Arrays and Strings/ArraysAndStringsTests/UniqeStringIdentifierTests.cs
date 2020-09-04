using ArraysAndStrings;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class UniqeStringIdentifierTests
    {
        private readonly UniqeStringIdentifier _stringIdentifier = new UniqeStringIdentifier();

        [Test]
        public void IsUniqueReturnBool()
        {
            var actual = _stringIdentifier.IsUnique("abc");
            Assert.That(actual == true || actual == false);
        }

        [Test]
        public void SimpleCaseTrue()
        {
            Assert.IsTrue(_stringIdentifier.IsUnique("a"));
        }

        [Test]
        public void SimpleCaseFalse()
        {
            Assert.IsFalse(_stringIdentifier.IsUnique("aa"));
        }
    }
}

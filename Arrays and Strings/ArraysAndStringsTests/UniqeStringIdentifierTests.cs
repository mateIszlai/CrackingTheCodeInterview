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
    }
}

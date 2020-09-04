using ArraysAndStrings;
using NUnit.Framework;
using System.Text;

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

        [Test]
        public void SimpleCaseWithNumberTrue()
        {
            Assert.IsTrue(_stringIdentifier.IsUnique("a7"));
        }

        [Test]
        public void SimpleCaseWithNumberFalse()
        {
            Assert.IsFalse(_stringIdentifier.IsUnique("a77"));
        }

        [Test]
        public void LongStringReturnFalse()
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < 200; i++)
            {
                stringBuilder.Append('a');
            }
            Assert.IsFalse(_stringIdentifier.IsUnique(stringBuilder.ToString()));
        }

        [Test]
        public void LongCase()
        {
            Assert.IsFalse(_stringIdentifier.IsUnique("tcew676ewfeobcueca()&V"));
        }

        [Test]
        public void LongCase1()
        {
            Assert.IsTrue(_stringIdentifier.IsUnique("@Gfwgz 12547db<r9-_tuk"));
        }

    }
}

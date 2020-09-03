using NUnit.Framework;
using TechnicalQuestions;

namespace TechnicalQuestionsTests
{
    [TestFixture]
    public class PermutationLocatorTests
    {
        private readonly PermutationLocator _locator = new PermutationLocator();

        [Test]
        public void PermutationNumberReturn()
        {
            Assert.NotNull(_locator.GetPermutationsNumber("a", "a"));
        }

        [Test]
        public void GetPermutationsNumber_Return_1()
        {
            var small = "a";
            var big = "a";

            Assert.AreEqual(1, _locator.GetPermutationsNumber(small, big));
        }

        [Test]
        public void GetPermutationsNumber_GivenLongString_Return_1()
        {
            var small = "a";
            var big = "abcdledddddjwurn";
            Assert.AreEqual(1, _locator.GetPermutationsNumber(small, big));
        }

        [Test]
        public void GetPermutationsNumber_GivenLongString_Return_5()
        {
            var small = "a";
            var big = "abcdaleddaddadjawurn";
            Assert.AreEqual(5, _locator.GetPermutationsNumber(small, big));
        }
    }
}

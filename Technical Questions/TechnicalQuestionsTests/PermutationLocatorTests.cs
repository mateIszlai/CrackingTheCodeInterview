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

        [Test]
        public void GetPermutationsNumber_GivenLongStrings_Return_1()
        {
            var small = "ab";
            var big = "abcdledddddjwurn";
            Assert.AreEqual(1, _locator.GetPermutationsNumber(small, big));
        }

        [Test]
        public void GetPermutationsNumber_GivenLongStrings_Return_3()
        {
            var small = "ab";
            var big = "abcdlbaedddabddjwurn";
            Assert.AreEqual(3, _locator.GetPermutationsNumber(small, big));
        }
        [Test]
        public void GetPermutationsNumber_GivenLongStringsWithCoverage_Return_4()
        {
            var small = "ab";
            var big = "abacdledbabddddjwurn";
            Assert.AreEqual(4, _locator.GetPermutationsNumber(small, big));
        }

        [Test]
        public void GetPermutationsNumber_GivenLongStrings_Return_2()
        {
            var small = "abc";
            var big = "abcdledbasddbacddjwurn";
            Assert.AreEqual(2, _locator.GetPermutationsNumber(small, big));
        }

        [Test]
        public void GetPermutationsNumber_GivenLongStrings_Return_7()
        {
            var small = "abbc";
            var big = "cbabadcbbabbcbabaabccbabc";
            Assert.AreEqual(7, _locator.GetPermutationsNumber(small, big));
        }
    }
}

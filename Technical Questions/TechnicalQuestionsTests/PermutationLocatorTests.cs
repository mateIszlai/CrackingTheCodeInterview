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
    }
}

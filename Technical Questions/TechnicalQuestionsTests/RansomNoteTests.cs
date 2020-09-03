using NUnit.Framework;
using TechnicalQuestions;

namespace TechnicalQuestionsTests
{
    [TestFixture]
    public class RansomNoteTests
    {
        RansomNote _note;

        [TearDown]
        public void TearDown()
        {
            _note = null;
        }

        [Test]
        public void IsFormedFrom_Returns()
        {
            _note = new RansomNote("a");
            Assert.IsNotNull(_note.isFormedFrom("b"));
        }
    }
}

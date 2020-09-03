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

        [Test]
        public void IsFormedFrom_GivenOneCharacter_ReturnsTrue()
        {
            _note = new RansomNote("a");
            Assert.IsTrue(_note.isFormedFrom("a"));
        }

        [Test]
        public void IsFormedFrom_GivenOneCharacter_ReturnsFalse()
        {
            _note = new RansomNote("a");
            Assert.IsFalse(_note.isFormedFrom("b"));
        }
    }
}

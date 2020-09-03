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

        [Test]
        public void IsFormedFrom_GivenMoreCharacter_ReturnsTrue()
        {
            _note = new RansomNote("abc");
            Assert.IsTrue(_note.isFormedFrom("Mbczwzcwcb a hfuehwf abc"));
        }

        [Test]
        public void IsFormedFrom_GivenMoreCharacter1_ReturnsTrue()
        {
            _note = new RansomNote("a abc abcd");
            Assert.IsTrue(_note.isFormedFrom("zgzq abc wgx ab a abhjfe  abcd"));
        }

        [Test]
        public void IsFormedFrom_GivenMoreCharacter2_ReturnsTrue()
        {
            _note = new RansomNote("aacbebwc viewv ejd9ewh");
            Assert.IsTrue(_note.isFormedFrom(" viewv fhzeuwf wefgz aacbebwc ahfew jvehwuiv ejd9ewh"));
        }

        [Test]
        public void IsFormedFrom_GivenMoreCharacter3_ReturnsTrue()
        {
            _note = new RansomNote("aa aa bbcd bb bb");
            Assert.IsTrue(_note.isFormedFrom(" aa bb fhzeuwf bb aacbebwc aa jvehwuiv bbcd ejd9ewh."));
        }

        [Test]
        public void IsFormedFrom_GivenMoreCharacter_ReturnsFalse()
        {
            _note = new RansomNote("ab");
            Assert.IsFalse(_note.isFormedFrom("b"));
        }

        [Test]
        public void IsFormedFrom_GivenMoreCharacter1_ReturnsFalse()
        {
            _note = new RansomNote("ab");
            Assert.IsFalse(_note.isFormedFrom("ba vubvzuwbv iucweiu a vrive"));
        }

        [Test]
        public void IsFormedFrom_GivenMoreCharacter2_ReturnsFalse()
        {
            _note = new RansomNote("abcd jewhw dde");
            Assert.IsFalse(_note.isFormedFrom("dde czwcw abcd cjwc"));
        }

        [Test]
        public void IsFormedFrom_GivenMoreCharacter3_ReturnsFalse()
        {
            _note = new RansomNote("abcd jewhw abcd dde");
            Assert.IsFalse(_note.isFormedFrom("dde czwcw ewhw abcd cjwc"));
        }
    }
}

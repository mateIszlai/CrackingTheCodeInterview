namespace TechnicalQuestions
{
    public class RansomNote
    {
        /*
         * Example: A ransom note can be formed by cutting words out of a magazine to form a new
         * sentence.How would you figure out if a ransom note(represented as a string) can be formed
         * from a given magazine(string)?
         */

        private readonly string _note;
        public RansomNote(string note)
        {
            _note = note;
        }

        public bool isFormedFrom(string magazine)
        {
            if(magazine.Length == 1)
            {
                if (_note.Length == 1)
                    return magazine == _note;

                return false;
            }
            return false;
        }
    }
}

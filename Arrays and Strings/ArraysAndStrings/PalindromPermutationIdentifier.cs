using System.Linq;

namespace ArraysAndStrings
{
    public class PalindromPermutationIdentifier
    {
        public bool IsPalindromePermutation(string s)
        {
            if (s.Length == 0)
                return false;
            else if (s.Length == 1)
                return true;

            var charCount = new int[27];

            foreach (var c in s)
            {
                charCount[char.ToUpper(c) - 'A']++;
            }

            return charCount.Count(count => count % 2 == 1) <= 1;
        }
    }
}

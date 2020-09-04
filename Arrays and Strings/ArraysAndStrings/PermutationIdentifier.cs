using System.Linq;

namespace ArraysAndStrings
{
    public class PermutationIdentifier
    {
        public bool isPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            if (s1.Length == 1 && s2.Length == 1)
                return s1 == s2;

            return s1.OrderBy(c => c).SequenceEqual(s2.OrderBy(c => c));
        }
    }
}

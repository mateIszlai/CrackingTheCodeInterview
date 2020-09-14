using System;

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

            return true;
        }
    }
}

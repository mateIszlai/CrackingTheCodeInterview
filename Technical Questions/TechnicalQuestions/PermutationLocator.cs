using System.Linq;

namespace TechnicalQuestions
{
    public class PermutationLocator
    {
        /*
         * Example: Given a smaller string small and a bigger string big, design an algorithm to find all permutations
         * of the shorter string within the longer one.
         */
        public int GetPermutationsNumber(string small, string big)
        {
            if (big == small)
                return 1;
            if(small.Length == 1)
            {
                return big.Count(c => c == small[0]);
            }

            var counter = 0;

            for(int i = 0; i < big.Length - small.Length + 1; i++)
            {
                var sub = big.Substring(i, small.Length);
                counter += isPermutation(small, sub) ? 1 : 0;
            }
            return counter;
        }

        private bool isPermutation(string small, string sub)
        {
            return small.OrderBy(c => c).SequenceEqual(sub.OrderBy(c => c));
        }
    }
}

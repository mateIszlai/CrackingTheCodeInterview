using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestions
{
    public class PermutationLocator
    {
        public int GetPermutationsNumber(string small, string big)
        {
            if (big == small)
                return 1;
            if(small.Length == 1)
            {
                return big.Count(c => c == small[0]);
            }
            return 0;
        }
    }
}

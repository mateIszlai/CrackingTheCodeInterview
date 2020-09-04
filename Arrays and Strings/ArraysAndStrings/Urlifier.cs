using System;
using System.Linq;

namespace ArraysAndStrings
{
    public class Urlifier
    {
        public string Urlify(char[] s, int trueLength)
        {
            var endSpaces = s.Length - trueLength;
            var spaces = s.Count(c => c == ' ') - endSpaces;

            if (spaces * 2 != endSpaces)
                throw new ArgumentException();

            for (int i = trueLength - 1; i >= 0; i--)
            {
                if(s[i] == ' ')
                {
                    for (int j = 0; j < 3; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                s[i + endSpaces] = '0';
                                break;
                            case 1:
                                s[i + endSpaces] = '2';
                                break;
                            case 2:
                                s[i + endSpaces] = '%';
                                break;
                        }
                        i--;
                    }
                    i++;
                    continue;
                }

                s[i + endSpaces] = s[i];
            }
            return new string(s);
        }
    }
}

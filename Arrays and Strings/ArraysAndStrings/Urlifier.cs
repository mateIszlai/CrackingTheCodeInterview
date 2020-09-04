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
                        var temp = i;
                        switch (j)
                        {
                            case 0:
                                s[temp + endSpaces] = '0';
                                break;
                            case 1:
                                s[temp + endSpaces] = '2';
                                break;
                            case 2:
                                s[temp + endSpaces] = '%';
                                break;
                        }
                        temp--;
                        endSpaces--;
                    }
                    endSpaces++;
                    continue;
                }

                s[i + endSpaces] = s[i];
            }
            return new string(s);
        }
    }
}

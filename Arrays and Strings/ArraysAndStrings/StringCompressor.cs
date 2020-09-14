using System.Text;

namespace ArraysAndStrings
{
    public class StringCompressor
    {
        public string Compress(string s)
        {
            var sb = new StringBuilder();
            var before = '0';
            var beforeCount = 0;
            foreach (var c in s)
            {
                if (c == before)
                    beforeCount++;
                else
                {
                    if(before != '0')
                    {
                        sb.Append(before);
                        sb.Append(beforeCount);
                    }
                    before = c;
                    beforeCount = 1;
                }
            }
            sb.Append(before);
            sb.Append(beforeCount);
            return  sb.Length < s.Length ? sb.ToString() : s;
        }
    }
}

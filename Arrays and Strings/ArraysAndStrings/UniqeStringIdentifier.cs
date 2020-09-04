namespace ArraysAndStrings
{
    public class UniqeStringIdentifier
    {
        public bool IsUnique(string s)
        {
            if (s.Length > 128)
                return false;

            var chars = new int[128];

            foreach (var c in s)
            {
                var code = (int)c;
                if (chars[code] > 0)
                    return false;
                chars[code]++;
            }

            return true;
        }
    }
}

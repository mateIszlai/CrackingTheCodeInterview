namespace ArraysAndStrings
{
    public class EditIdentifier
    {
        public bool IsEditedMaxOnce(string before, string after)
        {
            if (before == after)
                return true;
            if(before.Length != after.Length)
            {
                var counter = 0;
                var idx = 0;
                var shorter = before.Length < after.Length ? before : after;
                var longer = shorter == before ? after : before;
                if (longer.Length - shorter.Length > 1)
                    return false;

                foreach (var c in shorter)
                {
                    if(longer[idx] != c)
                    {
                        counter++;
                        if(longer[idx + 1] != c)
                        {
                            return false;
                        }
                        idx++;
                    }

                    idx++;
                }
                return counter <= 1;
            }
            return false;
        }
    }
}

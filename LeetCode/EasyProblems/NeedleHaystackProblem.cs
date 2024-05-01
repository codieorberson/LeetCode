namespace LeetCode.Services
{
    public class NeedleHaystackProblem
    {

        public NeedleHaystackProblem() { }

        public int NeedleHaystack(string needle, string haystack)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                bool exists = true;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        exists = false; break;
                    }
                }
                if (exists)
                {
                    return i;
                }
            }
            return -1;
        }

        public int NeedleHaystack2(string needle, string haystack)
        {
            return haystack.IndexOf(needle);
        }

        
    }
}

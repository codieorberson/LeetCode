namespace LeetCode.Services
{
    public class NeedleHaystackProblem
    {

        public NeedleHaystackProblem() { }

        public int NeedleHaystack(string needle, string haystack)
        {
            if (!haystack.Contains(needle))
            {
                return -1;
            }

            int solutionIndex = 0;
            int needleIndex = 0;
            int needleLength = needle.Length -1;
            for(int i = 0; i< haystack.Length; i++ )
            {
                if (haystack[i] == needle[needleIndex] && needleLength == needleIndex)
                {
                    return solutionIndex;
                }
                else if (haystack[i] == needle[needleIndex])
                {
                    if (needleIndex == 0)
                    {
                        solutionIndex = i;
                    }
                    needleIndex++;
                }
                else if (haystack[i] != needle[needleIndex])
                {
                    needleIndex = 0;
                    solutionIndex = i + 1;
                }
            }
            return solutionIndex;
        }
    }
}

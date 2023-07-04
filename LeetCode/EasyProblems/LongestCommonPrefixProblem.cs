namespace LeetCode.EasyProblems
{
    public class LongestCommonPrefixProblem
    {
        public LongestCommonPrefixProblem() { }

        public string LongestCommonPrefix(string[] words)
        {
            
            words = words.OrderBy(x => x.Length).ToArray();

            int maxCount = words.ElementAt(0).Length;
            string comparisonWord = words.ElementAt(0);
           

            string value = string.Empty;
            for (int i = 0; i < maxCount; i++)
            {
                for (int j = 1; j < words.Length; j++)
                {
                    if (comparisonWord[i] != words[j][i])
                    {
                        return value;
                    }
                }
                value += comparisonWord[i].ToString();

            }

            return value;
        }
    }
}

namespace LeetCode.EasyProblems
{
    public class LongestCommonPrefixProblem
    {
        public LongestCommonPrefixProblem() { }

        public string LongestCommonPrefix(string[] words)
        {
            words = words.OrderBy(x => x.Length).ToArray();
            string comparisonWord = words.ElementAt(0);

            for (int i = 0; i < comparisonWord.Length; i++)
            {
                for (int j = 1; j < words.Length; j++)
                {
                    if (comparisonWord[i] != words[j][i])
                    {
                        return comparisonWord.Substring(0, i);
                    }
                }
            }

            return comparisonWord;
        }
    }
}

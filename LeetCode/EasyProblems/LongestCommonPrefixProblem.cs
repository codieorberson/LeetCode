namespace LeetCode.EasyProblems
{
    public class LongestCommonPrefixProblem
    {
        public LongestCommonPrefixProblem() { }

        public string LongestCommonPrefix(string[] words)
        {
            Array.Sort(words);
            string shortestWord = words[0];
            string longestWord = words[words.Count() - 1];

            for(int i = 0; i < shortestWord.Length; i++)
            {
                if (shortestWord[i] != longestWord[i])
                    return shortestWord.Substring(0, i);
            }
            return shortestWord;
        }

        public string LongestCommonPrefix2(string[] words)
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

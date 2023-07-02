namespace LeetCode.EasyProblems
{
    public class RomanToIntProblem
    {
        public RomanToIntProblem() { }

        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanDictionary = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            int sum = 0;

            for(int i = 0; i < s.Length; i++)
            {
                int currentIndex = romanDictionary[s[i]];
                var nextIndex = (i + 1 == s.Length) ? 0: romanDictionary[s[i+1]];
                if (nextIndex > currentIndex)
                {
                    sum -= currentIndex;
                }
                else sum += currentIndex;
            }
            return sum;
        }
    }
}

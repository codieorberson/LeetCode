namespace LeetCode.EasyProblems
{
    public class ValidParenthesesProblem
    {

        public ValidParenthesesProblem() { }

        public bool ValidParentheses(string symbols)
        {

            Dictionary<char, char> validSymbols = new Dictionary<char, char>()
            {
                {')', '('},
                { ']', '[' },
                {'}', '{' },
            };

            Stack<char> allSymbols = new Stack<char>();

            foreach (char symbol in symbols) {
                if (!validSymbols.ContainsKey(symbol))
                {
                    allSymbols.Push(symbol);
                }
                else if (allSymbols.Count == 0 || allSymbols.Pop() != validSymbols[symbol])
                {
                    return false;
                }
            }

            return (allSymbols.Count == 0);
        }
    }
}

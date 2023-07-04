namespace LeetCode.EasyProblems
{
    public class BackspaceStringCompareProblem
    {
        public BackspaceStringCompareProblem() { }

        public bool BackspaceStringCompare(string string1, string string2)
        {
            Stack<char> firstStack = GenerateStack(string1);
            Stack<char> secondStack = GenerateStack(string2);
            return firstStack.SequenceEqual(secondStack);
        }

        public Stack<char> GenerateStack(string characters)
        {
            Stack<char> stack = new();
            foreach (char c in characters)
            {
                if (c != '#') stack.Push(c);
                else if(stack.Count != 0) stack.Pop();
            }
            return stack;
        }
    }
}

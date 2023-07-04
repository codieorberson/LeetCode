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

        

        public bool BackspaceStringCompare2(string string1, string string2)
        {
            int firstIndex = string1.Length - 1;
            int secondIndex = string2.Length - 1;

            while(firstIndex >= 0 || secondIndex >= 0)
            {
                firstIndex = DeclareNewIndex(firstIndex, string1);
                secondIndex = DeclareNewIndex(secondIndex, string2);

                if (firstIndex < 0 && secondIndex < 0) return true;
                if (firstIndex < 0 || secondIndex < 0 || string1[firstIndex] != string2[secondIndex]) return false;
                
                firstIndex--;
                secondIndex--;
            }
            return true;
        }

        public int DeclareNewIndex(int index, string characters)
        {
            int skipCharacters = 0;
            while (index >= 0)
            {
                if (characters[index] == '#')
                {
                    skipCharacters++;
                    index--;
                }
                else if (skipCharacters > 0)
                {
                    skipCharacters--;
                    index--;
                }
                else break;
            }
            return index;
        }
    }
}

namespace LeetCode.EasyProblems
{
    public class IsPalindromeProblem
    {
        public IsPalindromeProblem() { }

        public bool IsPalindrome(int x) 
        { 
            string stringValue = x.ToString();
            int stringLength = stringValue.Length;
            for(int i = 0; i< stringLength / 2; i++)
            {
                if (stringValue[i] != stringValue[stringLength - 1 - i])
                {
                    return false;
                }
            }
            return true; 
        }

        public bool IsPalindrome2(int x)
        {
            string value = x.ToString();
            var order = value.ToArray();
            var reversedOrder = value.ToArray();

            Array.Reverse(reversedOrder);

            bool equal = order.SequenceEqual(reversedOrder);
            return equal;
        }

        public bool IsPalindrome3(int x)
        {
            string value = x.ToString();
            string reverseValue = new string(value.Reverse().ToArray());
            return value == reverseValue;
        }
    }
}

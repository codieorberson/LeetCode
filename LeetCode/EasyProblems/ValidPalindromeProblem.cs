namespace LeetCode.EasyProblems
{
    public class ValidPalindromeProblem
    {
        public ValidPalindromeProblem() { }

        public bool ValidPalindrome(string phrase)
        {

            phrase = phrase.ToLower();
            string filteredChars = "!@#$%^&*()-_=+[{]};:'\",<.>/? `~\\|";
            
            foreach(char filteredChar in  filteredChars)
            {
                phrase = phrase.Replace(filteredChar.ToString(), "");
            }
            string reversedPhrase = new string(phrase.Reverse().ToArray());
            return reversedPhrase == phrase;
        }

        public bool ValidPalindrome2(string phrase)
        {
            phrase = phrase.ToLower();
            string filteredPhrase = "";
            foreach (char filteredChar in phrase)
            {
                if (char.IsLetterOrDigit(filteredChar))
                {
                    filteredPhrase += filteredChar;
                }
            }
            string reversedPhrase = new string(filteredPhrase.Reverse().ToArray());
            return reversedPhrase == filteredPhrase;
        }

    }
}

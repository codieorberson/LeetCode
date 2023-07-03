namespace LeetCode.HardProblems
{
    public class GuessTheWordProblem
    {
        int characterLimit;
        public GuessTheWordProblem() {
            characterLimit = 6;
        }

        public class WordGuess
        {
            public string name;
            public int count;
        }

        //string[] words = new string[] { "ccbazz", "eiowzz", "abcczz", "acckzz" };
        //string expectedWord = "acckzz";
        //int attempts = 10;
        public bool GuessTheWord(string[] words, string actualWord, int attempts)
        {
            int attempt = 1;

            List<WordGuess> currentWords = new List<WordGuess>();
            foreach(string word in words)
            {
                currentWords.Add(new WordGuess()
                {
                    name = word
                });
            }
            while(attempt <= attempts)
            {
                attempt += 1;

                string currentGuess = currentWords.FirstOrDefault().name;
                int guessCount = Guess(currentGuess, actualWord, words);
                if (guessCount == characterLimit) return true;

                List<WordGuess> newWords = new List<WordGuess>();

                for(int i = 1; i<currentWords.Count; i++)
                {
                    int matchingCharacters = 0;
                    for (int j = 0; j < characterLimit; j++)
                    {
                        if (currentGuess[j] == currentWords.ElementAt(i).name[j]) matchingCharacters += 1;
                    }
                    if(matchingCharacters >= guessCount)
                    {
                        newWords.Add(new WordGuess()
                        {
                            name = currentWords.ElementAt(i).name,
                            count = matchingCharacters
                        });
                        
                    }
                }
                newWords.OrderBy(x=>x.count).ToList();
                currentWords = newWords;




            }


            return false;
        }

        public int Guess(string guessWord, string actualWord, string[] words)
        {
            if (!words.Contains(guessWord)) return -1;

            int count = 0;
            for(int i = 0; i< characterLimit; i++) 
            {
                if (guessWord[i] == actualWord[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}

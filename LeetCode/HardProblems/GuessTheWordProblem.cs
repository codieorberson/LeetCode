using System.Security.Cryptography.Xml;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

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

            currentWords = OrderWords(currentWords);
            while (attempt <= attempts)
            {
                attempt += 1;

                string currentGuess = currentWords.FirstOrDefault().name;
                int guessCount = Guess(currentGuess, actualWord, words);
                if (guessCount == characterLimit) return true;

                List<WordGuess> newWords = new List<WordGuess>();

                if(guessCount == 0)
                {
                    for (int i = 1; i < currentWords.Count; i++)
                    {
                        int matchingCharacters = MatchingCharacters(currentGuess, currentWords, i);

                        if (matchingCharacters == 0) newWords.Add(new WordGuess()
                        {
                            name = currentWords.ElementAt(i).name,
                            count = 0
                        });
                    }
                }
                else if(guessCount == -1)
                {
                    currentWords.RemoveAt(0);
                    continue;
                }
                else
                {
                    for (int i = 1; i < currentWords.Count; i++)
                    {
                        int matchingCharacters = MatchingCharacters(currentGuess, currentWords, i);

                        if (matchingCharacters >= guessCount)
                        {
                            newWords.Add(new WordGuess()
                            {
                                name = currentWords.ElementAt(i).name,
                                count = matchingCharacters
                            });

                        }
                    }
                }

                currentWords = newWords.OrderByDescending(x=>x.count).OrderByDescending(x=>x.name).ToList();




            }
            return false;
        }

        public List<WordGuess> OrderWords(List<WordGuess> words)
        {
            string reference = words[0].name;
            List<WordGuess> orderedWords = words.OrderByDescending(word => word.name.Zip(reference, (c1, c2) => c1 == c2).Count(b => b)).ToList();
            return orderedWords;
        }

        public int MatchingCharacters(string currentGuess, List<WordGuess> currentWords, int index)
        {
            int matchingCharacters = 0;
            for (int j = 0; j < 6; j++)
            {
                if (currentGuess[j] == currentWords.ElementAt(index).name[j]) matchingCharacters += 1;
            }
            return matchingCharacters;
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

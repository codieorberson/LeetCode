using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.HardProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest.HardProblems
{
    [TestClass]
    public class GuessTheWordProblemTest
    {
        GuessTheWordProblem guessTheWordProblem;

        [TestInitialize]
        public void Setup()
        {
            guessTheWordProblem = new GuessTheWordProblem();
        }

        [TestMethod]
        public void GuessTheWord()
        {
            string[] words = new string[] { "ccbazz", "eiowzz", "abcczz", "acckzz" };
            string actualWord = "acckzz";
            int attempts = 10;

            var actual = guessTheWordProblem.GuessTheWord(words, actualWord, attempts);
            Assert.IsTrue(actual);
        }
    }
}

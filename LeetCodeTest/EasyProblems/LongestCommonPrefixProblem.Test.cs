using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.EasyProblems;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class LongestCommonPrefixProblemTest
    {
        LongestCommonPrefixProblem longestCommonPrefixProblem;

        [TestInitialize]
        public void Setup()
        {
            longestCommonPrefixProblem = new LongestCommonPrefixProblem();
        }

        [TestMethod]
        [DataRow(new string[] { "flourish", "flower", "flow", "flight", "flag", "flash", "flame", "flavor", "flair", "flange" }, "fl")]
        [DataRow(new string[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefix(string[] words, string expected)
        {
            string actual = longestCommonPrefixProblem.LongestCommonPrefix(words);
            Assert.AreEqual(expected, actual);
        }
    }
}

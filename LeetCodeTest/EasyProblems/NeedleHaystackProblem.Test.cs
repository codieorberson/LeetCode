using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Services;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class NeedleHaystackProblemTest
    {
        NeedleHaystackProblem NeedleHaystackProblem;

        [TestInitialize]
        public void Setup()
        {
            NeedleHaystackProblem = new NeedleHaystackProblem();
        }

        [TestMethod]
        [DataRow("sad", "sadbutsad", 0)]
        [DataRow("sad", "bsadbutsad", 1)]
        [DataRow("leeto", "leetcode", -1)]
        [DataRow("c", "abc", 2)]
        [DataRow("issip", "mississippi", 4)]
        public void TwoSum(string needle, string haystack, int expected)
        {
            var result = NeedleHaystackProblem.NeedleHaystack(needle, haystack);

            Assert.AreEqual(result, expected);        
        }


    }
}

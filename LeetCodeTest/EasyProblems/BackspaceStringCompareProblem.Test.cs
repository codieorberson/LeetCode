using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.EasyProblems;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class BackspaceStringCompareProblemTest
    {
        BackspaceStringCompareProblem backspaceStringCompareProblem;

        [TestInitialize]
        public void Setup()
        {
            backspaceStringCompareProblem = new BackspaceStringCompareProblem();
        }

        [TestMethod]
        [DataRow("ab#c", "ad#c", true)]
        [DataRow("ab##", "c#d#", true)]
        [DataRow("a#c", "b", false)]
        [DataRow("a##c", "#a#c", true)]
        public void BackspaceStringCompare(string string1, string string2, bool expected)
        {
            bool actual = backspaceStringCompareProblem.BackspaceStringCompare(string1, string2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("ab#c", "ad#c", true)]
        [DataRow("ab##", "c#d#", true)]
        [DataRow("a#c", "b", false)]
        [DataRow("a##c", "#a#c", true)]
        public void BackspaceStringCompare2(string string1, string string2, bool expected)
        {
            bool actual = backspaceStringCompareProblem.BackspaceStringCompare2(string1, string2);
            Assert.AreEqual(expected, actual);
        }
    }
}

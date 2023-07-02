using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.EasyProblems;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class ValidParenthesesProblemTest
    {

        ValidParenthesesProblem validParenthesesProblem;

        [TestInitialize]
        public void Setup()
        {
            validParenthesesProblem = new ValidParenthesesProblem();
        }

        [TestMethod]
        [DataRow("()", true)]
        [DataRow("()[]{}", true)]
        [DataRow("(]", false)]
        [DataRow("(]", false)]
        [DataRow("(()))", false)]
        [DataRow("([{}]))", false)]
        public void ValidParentheses(string value, bool expected) 
        {
            bool actual = validParenthesesProblem.ValidParentheses(value);
            Assert.AreEqual(expected, actual);
        }
    }
}

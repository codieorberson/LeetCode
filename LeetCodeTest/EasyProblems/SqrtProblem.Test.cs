using LeetCode.EasyProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]

    public class SqrtProblemTest
    {
        SqrtProblem sqrtProblem;

        [TestInitialize]
        public void Setup()
        {
            sqrtProblem = new SqrtProblem();
        }

        [TestMethod]
        [DataRow(2147483647, 46340)]
        [DataRow(65, 8)]
        [DataRow(8, 2)]
        public void GetSqrtForInt(int number, int expected)
        {
            var actual = sqrtProblem.GetSqrtForInt(number);
            Assert.AreEqual(expected, actual);
        }
    }
}

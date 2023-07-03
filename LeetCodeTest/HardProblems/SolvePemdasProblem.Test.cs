using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.HardProblems;

namespace LeetCodeTest.HardProblems
{
    [TestClass]
    public class SolvePemdasProblemTest
    {
        SolvePemdasProblem solvePemdasProblem;

        [TestInitialize]
        public void Setup()
        {
            solvePemdasProblem = new SolvePemdasProblem();
        }

        //5(3+2)2
        [TestMethod]
        [DataRow(new int[] { 2, 4, 2 }, 16, "2*4*2")]
        [DataRow(new int[] { 5, 8, 3, 6 }, 20, "5*8*3/6")]
        public void SolvePempdas(int[] nums, int target, string expected)
        {
            List<string> actual = solvePemdasProblem.SolvePemdas(nums, target);
            Assert.IsTrue(actual.Contains(expected));
        }

        [TestMethod]
        [DataRow(new int[] { 2, 4, 2 }, 16, true)]
        public void SolvePempdas2(int[] nums, int target, bool expected)
        {
            bool actual = solvePemdasProblem.SolvePemdas2(nums, target);
            Assert.AreEqual(expected, actual);
        }

        
    }
}

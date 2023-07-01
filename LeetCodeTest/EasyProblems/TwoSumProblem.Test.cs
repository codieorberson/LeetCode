using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Services;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class TwoSumProblemTest
    {
        TwoSumProblem twoSumProblem;

        [TestInitialize]
        public void Setup()
        {
            twoSumProblem = new TwoSumProblem();
        }

        [TestMethod]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 11, 15, 2, 7 }, 9, new int[] { 2, 3 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSum(int[] nums, int target, int[] expected)
        {
            var result = twoSumProblem.TwoSum(nums, target);

            CollectionAssert.AreEquivalent(expected, result);
        }


        
    }
}

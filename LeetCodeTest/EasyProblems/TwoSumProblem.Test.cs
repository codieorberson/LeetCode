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
        public void TwoSum()
        {
            int[] nums = { 2, 5, 6, 7 };
            int target = 20;

            var result = twoSumProblem.TwoSum(nums, target);
            Assert.AreEqual(nums, result);
        }


        
    }
}

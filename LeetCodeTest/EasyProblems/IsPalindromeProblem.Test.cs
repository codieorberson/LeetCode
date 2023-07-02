﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.EasyProblems;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class IsPalindromeProblemTest
    {
        IsPalindromeProblem isPalindromeProblem;

        [TestInitialize]
        public void Setup()
        {
            isPalindromeProblem = new IsPalindromeProblem();
        }

        [TestMethod]
        [DataRow(989, true)]
        [DataRow(9892, false)]
        [DataRow(9, true)]
        [DataRow(5885, true)]
        public void IsPalindrome(int number, bool expected) { 
            var result = isPalindromeProblem.IsPalindrome(number);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(989, true)]
        [DataRow(9892, false)]
        [DataRow(9, true)]
        [DataRow(5885, true)]
        public void IsPalindrome2(int number, bool expected)
        {
            var result = isPalindromeProblem.IsPalindrome2(number);
            Assert.AreEqual(expected, result);
        }
    }
}

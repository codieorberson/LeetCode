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
        [DataRow(-989, false)]
        [DataRow(9892, false)]
        [DataRow(9, true)]
        [DataRow(5885, true)]
        public void IsPalindrome2(int number, bool expected)
        {
            var result = isPalindromeProblem.IsPalindrome2(number);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(989, true)]
        [DataRow(-989, false)]
        [DataRow(9892, false)]
        [DataRow(9, true)]
        [DataRow(5885, true)]
        public void IsPalindrome3(int number, bool expected)
        {
            var result = isPalindromeProblem.IsPalindrome3(number);
            Assert.AreEqual(expected, result);
        }
    }
}

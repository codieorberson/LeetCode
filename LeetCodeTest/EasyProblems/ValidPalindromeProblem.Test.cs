using LeetCode.EasyProblems;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class ValidPalindromeProblemTest
    {

        ValidPalindromeProblem validPalindromeProblem;
        [TestInitialize]
        public void Setup()
        {
            validPalindromeProblem = new ValidPalindromeProblem();
        }

        [TestMethod]
        [DataRow("A man, a plan, a canal: Panama", true)]
        [DataRow("race a car", false)]
        [DataRow("Marge, let's \"[went].\" I await {news} telegram.", true)]
        public void ValidPalindrome(string phrase, bool expected)
        {

            bool actual = validPalindromeProblem.ValidPalindrome(phrase);
            Assert.AreEqual(expected, actual);

        }
    }
}

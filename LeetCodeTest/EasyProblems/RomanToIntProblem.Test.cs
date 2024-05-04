using LeetCode.EasyProblems;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class RomanToIntProblemTest
    {
        RomanToIntProblem romanToIntProblem;

        [TestInitialize]
        public void Setup()
        {
            romanToIntProblem = new RomanToIntProblem();
        }

        [TestMethod]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("LVIII", 58)]
        [DataRow("MCMXCIV", 1994)]
        public void RomanToInt(string letters, int sum)
        {
            var actual = romanToIntProblem.RomanToInt(letters);
            Assert.AreEqual(sum, actual);
        }

    }
}

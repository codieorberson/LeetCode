using LeetCode.EasyProblems;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class ClimbStairsProblemTest
    {
        ClimbStairsProblem climbStairsProblem;

        [TestInitialize]
        public void Setup()
        {
            climbStairsProblem = new ClimbStairsProblem();
        }

        [TestMethod]
        [DataRow(2, 2)]
        [DataRow(3, 3)]
        [DataRow(4, 5)]
        [DataRow(5, 8)]
        [DataRow(6, 13)]
        [DataRow(7, 21)]
        public void GetPossibleRoutes(int stairs, int expected)
        {
            var result = climbStairsProblem.GetPossibleRoutes(stairs);
            Assert.AreEqual(expected, result);
        }
    }
}

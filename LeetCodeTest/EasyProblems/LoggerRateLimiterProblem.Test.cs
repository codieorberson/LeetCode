using LeetCode.EasyProblems;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class LoggerRateLimiterProblemTest
    {
        LoggerRateLimiterProblem loggerRateLimiterProblem;

        [TestInitialize]
        public  void Setup()
        {
            loggerRateLimiterProblem = new LoggerRateLimiterProblem();
        }

       
        [TestMethod]
        public void ShouldPrintMessage()
        {
            Assert.AreEqual(true, loggerRateLimiterProblem.ShouldPrintMessage(1, "foo"));
            Assert.AreEqual(true, loggerRateLimiterProblem.ShouldPrintMessage(2, "bar"));
            Assert.AreEqual(false, loggerRateLimiterProblem.ShouldPrintMessage(3, "foo"));
            Assert.AreEqual(false, loggerRateLimiterProblem.ShouldPrintMessage(8, "bar"));
            Assert.AreEqual(false, loggerRateLimiterProblem.ShouldPrintMessage(10, "foo"));
            Assert.AreEqual(true, loggerRateLimiterProblem.ShouldPrintMessage(11, "foo"));
        }
    }
}

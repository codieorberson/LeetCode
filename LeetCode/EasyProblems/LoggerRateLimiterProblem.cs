namespace LeetCode.EasyProblems
{
    public class LoggerRateLimiterProblem
    {
        Dictionary<string, int> loggerDictionary;
        public LoggerRateLimiterProblem()
        {
            loggerDictionary = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if(loggerDictionary.ContainsKey(message) && timestamp < loggerDictionary[message]) {
                return false;
            }
            loggerDictionary[message] = timestamp + 10;
            return true;
        }
    }
}

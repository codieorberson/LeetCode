namespace LeetCode.HardProblems
{
    public class RangeModuleProblem
    {
        RangeModuleMode rangeModuleMode;
        public class RangeModuleMode
        {
            public HashSet<int> range = new HashSet<int>();
        }
        public RangeModuleProblem()
        {
            rangeModuleMode = new RangeModuleMode();
        }

        public void AddRange(int left, int right)
        {
            List<int> range = Enumerable.Range(left, right - left).ToList();
            foreach (int num in range)
            {
                rangeModuleMode.range.Add(num);
            }
        }

        public bool QueryRange(int left, int right)
        {
            if (rangeModuleMode.range.Count == 0) return false;
            List<int> range = Enumerable.Range(left, right - left).ToList();
            foreach (int num in range)
            {
                if (!rangeModuleMode.range.Contains(num)) return false;
            }
            return true;
        }

        public void RemoveRange(int left, int right)
        {
            List<int> range = Enumerable.Range(left, right - left).ToList();
            foreach (int num in range)
            {
                rangeModuleMode.range.Remove(num);
            }
        }
    }
}

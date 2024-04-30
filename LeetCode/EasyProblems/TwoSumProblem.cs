namespace LeetCode.Services
{
    public class TwoSumProblem
    {

        public TwoSumProblem() { }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];
                int complement = target - number;
                if (!numDictionary.ContainsKey(complement))
                {
                    numDictionary[number] = i;
                    continue;
                }
                else
                {
                    return new int[] { i, numDictionary[complement] };
                }
            }
            return new int[] { };
        }

        public int[] TwoSum2(int[] nums, int target)
        {

            Dictionary<int, int> numDictionary = new Dictionary<int, int>();

            int iteration = 0;
            foreach (int num in nums)
            {
                int compliment = target - num;
                if (numDictionary.ContainsValue(compliment))
                {
                    return new int[] { numDictionary.Where(x => x.Value == compliment).Select(x => x.Key).First(), iteration };
                }
                numDictionary.Add(iteration, num);
                iteration++;

            }
            return new int[0];
        }

    }
}

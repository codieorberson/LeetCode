namespace LeetCode.EasyProblems
{
    public class SqrtProblem
    {
        public SqrtProblem() { }

        //Slow
        public int GetSqrtForInt(int number)
        {
            for(int i =1; i <= int.MaxValue; i++)
            {
                int possibleValue = i * i;
                if(possibleValue == number)
                {
                    return i;
                }
                else if(possibleValue > number)
                {
                    return i - 1;
                }
            }
            return -1;
        }

        public double GetSqrtForInt2(int number)
        {
            return Math.Floor(Math.Sqrt(number));
        }

        public int GetSqrtForInt3(int number)
        {
            if (number == 0 || number == 1)
                return number; 

            long start = 1, end = number / 2, ans = 0;
            while (start <= end)
            {
                long mid = (start + end) / 2;
                long square = mid * mid;

                if (square == number)
                    return (int)mid;
                if (square < number)
                {
                    start = mid + 1;
                    ans = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return (int)ans;
        }
    }
}

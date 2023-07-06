namespace LeetCode.EasyProblems
{
    public class BestStockSellBuyTimeProblem
    {
        public BestStockSellBuyTimeProblem() { }

        public int BestStockSellBuyTime(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = prices[0];

            for(int i = 1; i<prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }
        public int BestStockSellBuyTime2(int[] prices)
        {
            int bestTime = 0;
            for(int i=0;i< prices.Length-1; i++)
            {
                for(int j = i+1; j < prices.Length-1; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > bestTime)
                    {
                        bestTime = profit;
                    }
                }
            }
            return bestTime;
        }
    }
}

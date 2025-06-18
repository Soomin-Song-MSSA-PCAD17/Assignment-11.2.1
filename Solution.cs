namespace LeetCode121
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) { return 0; }

            int buyIndex = 0;
            int sellIndex = 1;
            int profit = 0;
            if (profit < prices[sellIndex] - prices[buyIndex])
            {
                profit = prices[sellIndex] - prices[buyIndex];
            }
            for (int i = 0; i < prices.Length; i++)
            {
                // i value is higher than sell value
                // update profit as well
                if (prices[i] > prices[sellIndex])
                {
                    sellIndex = i;
                    if (profit < prices[sellIndex] - prices[buyIndex])
                    {
                        profit = prices[sellIndex] - prices[buyIndex];
                    }
                }

                // i value is lower than buy value
                // see if you can buy now instead, and sell even later
                if (prices[i] < prices[buyIndex])
                {
                    buyIndex = i;
                    sellIndex = i;
                }
            }
            return profit;
        }
    }
}

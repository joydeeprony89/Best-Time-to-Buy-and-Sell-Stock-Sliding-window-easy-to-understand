using System;

namespace Best_Time_to_Buy_and_Sell_Stock
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      // test input
      // [2,1,2,1,0,1,2]
    }
  }

  public class Solution
  {
    public int MaxProfit(int[] prices)
    {
      if (prices.Length == 1) return 0;
      int max = 0;
      int l = 0; // buying index
      int r = 1; // selling index
      while (r < prices.Length)
      {
        // as you will be buying first and after that you will sell, so profit (r - l)
        int buyPrice = prices[l];
        int sellPrice = prices[r];
        if (buyPrice < sellPrice)
        {
          int profit = sellPrice - buyPrice;
          max = Math.Max(max, profit);
        }
        else
        {
          // when your sell price is less than buying price, we have to but in that price to max profit
          l = r;
        }
        r++;
      }

      return max;
    }
  }

  // Space Complexity = O(1)
  // Time Complexity = O(N)
}

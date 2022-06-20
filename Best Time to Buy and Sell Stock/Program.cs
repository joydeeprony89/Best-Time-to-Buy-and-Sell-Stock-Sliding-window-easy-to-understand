using System;

namespace Best_Time_to_Buy_and_Sell_Stock
{
  class Program
  {
    static void Main(string[] args)
    {
      // test input
      // [2,1,2,1,0,1,2]
      Solution s = new Solution();
      var prices = new int[] { 2, 1, 2, 1, 0, 1, 2 };
      var answer = s.MaxProfit(prices);
      Console.WriteLine(answer);
    }
  }

  public class Solution
  {
    public int MaxProfit(int[] prices)
    {
      // the basic of getting profit is find the day when the buying cost is min and try to max your profit until you get a day when selling price is max
      // Step - 1 - keep a min pointer to track the min buying cost
      // Step - 2 - at each index check we have found new min ? if no, oviously we can get profit, but is the new profit is better than the last ? yes, then update
      // [2,1,2,1,0,1,2]
      int min = int.MaxValue;
      int maxProfit = 0;
      for(int i = 0; i < prices.Length; i++)
      {
        int current = prices[i];
        //Step - 1
        min = Math.Min(min, current);
        //Step - 2 
        maxProfit = Math.Max(maxProfit, current - min);
      }

      return maxProfit;
    }
  }

  // Space Complexity = O(1)
  // Time Complexity = O(N)
}

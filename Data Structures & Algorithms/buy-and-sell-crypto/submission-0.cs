public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        var minPrice = Int32.MaxValue;
        var maxPrice = 0;

        foreach(var price in prices) {
            if (price > maxPrice)
                maxPrice = price;
            
            if (price < minPrice) {
                minPrice = price;
                maxPrice = minPrice;
            }

            maxProfit = Math.Max(maxProfit, maxPrice - minPrice);
        }

        return maxProfit;
    }
}

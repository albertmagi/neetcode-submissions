public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);

        var longest = 0;
        var currAmount = 1;
        int? ant = null;

        foreach (var num in nums)
        {
            if (ant == num)
                continue;
            
            if (ant is not null && ant == num-1)
                currAmount++;
            else
                currAmount = 1;

            longest = Math.Max(longest, currAmount);
            ant = num;
        }

        return longest;
    }
}

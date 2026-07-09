public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        var pq = new PriorityQueue<int, int>();
        
        foreach (var n in nums) {
            if (!dict.ContainsKey(n))
                dict[n] = 0;
            
            dict[n]++;
        }

        foreach (var entry in dict) {
            pq.Enqueue(entry.Key, -1*entry.Value);
        }

        var res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = pq.Dequeue();
        }

        return res;
    }
}

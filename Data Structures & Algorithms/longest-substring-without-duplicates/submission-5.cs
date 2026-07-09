public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 1)
            return 1;
            
        var longestSubstring = 0;

        for (int i = 0; i<s.Length-1; i++) {
            var hs = new HashSet<char>();
            hs.Add(s[i]);
            var j = i+1;

            while (j<s.Length && !hs.Contains(s[j])) {
                hs.Add(s[j]);
                j++;
            }

            longestSubstring = Math.Max(hs.Count, longestSubstring);
        }

        return longestSubstring;
    }
}

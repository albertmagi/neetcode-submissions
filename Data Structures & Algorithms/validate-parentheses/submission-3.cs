public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0)
            return false;

        var st = new Stack<char>();
        
        foreach (var c in s) {
            if (c == '(' || c == '[' || c == '{') {
                st.Push(c);
            } else {
                if (st.Count == 0 || !isOppositeParentheses(st.Pop(), c))
                    return false;
            }
        }

        return st.Count == 0;
    }

    private bool isOppositeParentheses(char c, char opposite) {
        if (c == '(')
            return opposite == ')';
        
        if (c == '[')
            return opposite == ']';

        if (c == '{')
            return opposite == '}';

        return false;

    }
}

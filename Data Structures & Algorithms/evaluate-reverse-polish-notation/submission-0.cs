public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens.Length == 1)
            return int.Parse(tokens[0]);
        
        var stack = new Stack<int>();
        foreach(var token in tokens)
        {
            if (int.TryParse(token, out var parsedInt))
            {
                stack.Push(parsedInt);
            } 
            else
            {
                var lastNum = stack.Pop();
                var secondLastNum = stack.Pop();
                stack.Push(ProcessOperation(secondLastNum, lastNum, token));
            }
        }

        return stack.Count > 0 ? stack.Pop() : 0;
    }

    private static int ProcessOperation(int num1, int num2, string operation)
    {
        switch(operation) {
            case "-":
                return num1-num2;
            case "+":
                return num1+num2;
            case "*":
                return num1*num2;
            case "/":
                return num1/num2;
            default:
                throw new Exception("Invalid operation");
        }

        return 0;
    }
}

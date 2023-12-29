//You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.

//Evaluate the expression. Return an integer that represents the value of the expression.

//Note that:

//    The valid operators are '+', '-', '*', and '/'.
//    Each operand may be an integer or another expression.
//    The division between two integers always truncates toward zero.
//    There will not be any division by zero.
//    The input represents a valid arithmetic expression in a reverse polish notation.
//    The answer and all the intermediate calculations can be represented in a 32-bit integer.



//Example 1:

//Input: tokens = ["2", "1", "+", "3", "*"]
//Output: 9
//Explanation: ((2 + 1) * 3) = 9

//Example 2:

//Input: tokens = ["4", "13", "5", "/", "+"]
//Output: 6
//Explanation: (4 + (13 / 5)) = 6

//Example 3:

//Input: tokens = ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]
//Output: 22
//Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
//= ((10 * (6 / (12 * -11))) + 17) + 5
//= ((10 * (6 / -132)) + 17) + 5
//= ((10 * 0) + 17) + 5
//= (0 + 17) + 5
//= 17 + 5
//= 22

//IDEA!: Try two stacks, one for numbers one for operators
// push while there are numbers, 
// push to operator staack while there are opearotr
// pop for every two numbers and execute operation



static int EvalRPN(string[] tokens)
{
    if (tokens.Length == 0) return 0;
    if(tokens.Length == 1) return int.Parse(tokens[0]);
    Stack<int> numbers = new Stack<int>();
    bool exist = false;
    string[] OPERATORS = { "*", "/", "+", "-" };
    int result = 0;
    Stack<int> resStack = new Stack<int>();
    for(int i=0; i < tokens.Length; i++)
    {
        if (!OPERATORS.Contains(tokens[i]))
        {
            numbers.Push(int.Parse(tokens[i]));
           
        }
        else
        {
            int tempRes = numbers.Pop();

            if (tokens[i] == "*") tempRes *= numbers.Pop();
            if (tokens[i] == "/") tempRes = numbers.Pop() / tempRes;
            if (tokens[i] == "+") tempRes += numbers.Pop();
            if (tokens[i] == "-") tempRes = numbers.Pop() - tempRes;

            numbers.Push(tempRes);
            result = numbers.Peek();
        }
           
    }
        return result;


}
string[] eval = { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
EvalRPN(eval);
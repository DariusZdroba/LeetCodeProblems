//Given an array of integers temperatures represents the daily temperatures, return an array answer such that
//answer[i] is the number of days you have to wait after the ith day to get a warmer temperature.
//If there is no future day for which this is possible, keep answer[i] == 0 instead.



//Example 1:

//Input: temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
//Output: [1,1,4,2,1,1,0,0]

//Example 2:

//Input: temperatures = [30, 40, 50, 60]
//Output: [1,1,1,0]

//Example 3:

//Input: temperatures = [30, 60, 90]
//Output: [1,1,0]


static int[] DailyTemperatures(int[] temperatures)
{
    if (temperatures.Length == 1) return new int[0];
    int[] resp = new int[temperatures.Length];
    Stack<int> stack = new Stack<int>();
    stack.Push(temperatures.Length-1);

    for(int i = temperatures.Length-2; i>= 0; i--)
    {
        while(stack.Count > 0) 
        {
            if (temperatures[stack.Peek()] > temperatures[i])
            {
                resp[i] = stack.Peek() - i;
                break;
            }
            stack.Pop();
        }
        stack.Push(i);
    }
    return resp;
    


}


int[] nums = { 73, 74, 75, 71, 69, 72, 76, 73 };
DailyTemperatures(nums);
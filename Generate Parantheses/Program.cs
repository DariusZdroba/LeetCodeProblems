//Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.



//Example 1:

//Input: n = 3
//Output: ["((()))","(()())","(())()","()(())","()()()"]

//Example 2:

//Input: n = 1
//Output: ["()"]



//Constraints:

//1 <= n <= 8

IList<string> GenerateParenthesis(int n)
{
    string stringBuild = "";
    List<string> resultList = new List<string>();
    
    void backTrack(int openN, int closedN)
    {
        if((openN == closedN) && (openN == n) && (closedN == n))
        {
            resultList.Add(stringBuild.ToString());
        }

        if (openN <= n)
        {
            stringBuild += "(";
            backTrack(openN + 1, closedN);
            stringBuild = stringBuild.Remove(stringBuild.Length-1,1);
        }

        if(closedN < openN)
        {
            stringBuild += ")";
            backTrack(openN, closedN + 1);
            stringBuild = stringBuild.Remove(stringBuild.Length - 1, 1);
        }
    }
    backTrack(0, 0);
    return resultList;
}

GenerateParenthesis(3);
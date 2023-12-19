static bool IsValid(string s)
{
    Stack<char> round = new Stack<char>();
    Stack<char> square = new Stack<char>();
    Stack<char> brackets = new Stack<char>();
    for(int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
        {
            round.Push(s[i]);
        }
        else if (s[i] == ')')
        {
            if(round.Count != 0)
            round.Pop();
            else
            {
                return false;
            }
        }
       if(s[i] == '{')
        {
            brackets.Push(s[i]);
        }
       else if (s[i] =='}')
        {
            if(brackets.Count !=0)
            brackets.Pop();
            else
            {
                return false;
            }
        }
       if(s[i] == '[')
        {

            square.Push(s[i]);
        }
       else if (s[i] == ']')
        {
            if (square.Count != 0)
                square.Pop();
            else
                return false;
        }
    }
    var sum = square.Count + brackets.Count + round.Count;
        return sum == 0;    
}
string s = "(]";
IsValid(s);
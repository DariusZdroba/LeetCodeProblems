static string ReverseWords(string s)
{
    var outp = s.Trim().Split(" ");
    string output = "";
    for (int i =outp.Length - 1; i > 0; i--)
        output +=outp[i] ;

return output;
    
}
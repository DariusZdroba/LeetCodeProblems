//Given two strings s and t, return true if t is an anagram of s, and false otherwise.

//An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.



//Example 1:

//Input: s = "anagram", t = "nagaram"
//Output: true

static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;
    Dictionary<char,int> sHashSet = new Dictionary<char, int>();
    for(int i=0; i<s.Length; i++)
    {
        if (sHashSet.ContainsKey(s[i]))
        {
            sHashSet[s[i]]++;
        }
        else
        {
            sHashSet.Add(s[i], 1);
        }
    }
    for(int i=0;i<s.Length;i++)
    {
        if (sHashSet.ContainsKey(t[i]))
        {
            sHashSet[t[i]]--;
        }
        else
        {
            return false;
        }
    }
    bool contains = sHashSet.Values.All(v => v==0);

    return contains;
  
}
string s = "aa";
string t = "bb";
IsAnagram(s, t);
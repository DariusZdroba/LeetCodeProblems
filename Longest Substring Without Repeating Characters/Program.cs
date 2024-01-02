//Given a string s, find the length of the longest
//substring
//without repeating characters.



//Example 1:

//Input: s = "abcabcbb"
//Output: 3
//Explanation: The answer is "abc", with the length of 3.

//Example 2:

//Input: s = "bbbbb"
//Output: 1
//Explanation: The answer is "b", with the length of 1.

//Example 3:

//Input: s = "pwwkew"
//Output: 3
//Explanation: The answer is "wke", with the length of 3.
//Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.



//Constraints:

//    0 <= s.length <= 5 * 104
//    s consists of English letters, digits, symbols and spaces.

int LengthOfLongestSubstring(string s)
{
    if (s.Length == 0) return 0;
    int left = 0;
    int right = 0;
    int res = 0;
    
    HashSet<char> set = new HashSet<char>();
    
    while(right < s.Length)
    {
        if (!set.Contains(s[right]))
        {
            set.Add(s[right]);
            right++;
            res = Math.Max(res, set.Count);
        }
        else
        {
            set.Remove(s[left]);
            left++;
        }
    }
    return res;
}

LengthOfLongestSubstring("pwwwkew");
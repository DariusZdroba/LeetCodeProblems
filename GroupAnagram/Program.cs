//given an array of strings strs, group the anagrams together. you can return the answer in any order.

//an anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.



//example 1:

//input: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
//output: [["bat"],["nat","tan"],["ate","eat","tea"]]

//example 2:

//input: strs = [""]
//output: [[""]]
static IList<IList<string>> GroupAnagrams(string[] strs)
{
    Dictionary<int[], List<String>> res = new Dictionary<int[], List<String>>();
    IList<IList<string>> list = new List<IList<string>>();
    foreach (string str in strs)
    {
        int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach(var c in str)
        {
            count[(int)c - 97]++;
        }
      
       if (!res.Keys.Any(k =>
        {
            if (k.SequenceEqual(count))
            {
                res[k].Add(str);
                return true;
            }
            else
            {
                
                return false;
            }
        }))
        {
            List<string> st = new List<string>();
            st.Add(str);
            res.Add(count, st);
        }


    }
    foreach (var r in res.Values)
    {
        list.Add(r);
    }

    return list;
}
string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
GroupAnagrams(strs);
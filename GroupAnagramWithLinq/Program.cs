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
    return strs
        .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
        .Select(g => g.ToList() as IList<string>)
        .ToList();
}
string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
GroupAnagrams(strs);
Console.WriteLine("");


//given an integer array nums and an integer k, return the k most frequent elements. you may return the answer in any order.



//example 1:

//input: nums = [1, 1, 1, 2, 2, 3], k = 2
//output: [1,2]
//example 2:

//input: nums = [1], k = 1
//output: [1]

static int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
    
    int[] outputArray = new int[k];
    for(int i = 0; i < nums.Length; i++)
    {
        if (frequencyDictionary.ContainsKey(nums[i]))
        {
            frequencyDictionary[nums[i]]++;
        }
        else
        {
            frequencyDictionary.Add(nums[i], 1);
        }
    }
    List<int>[] buckets = new List<int>[nums.Length+1];
    foreach(var key  in frequencyDictionary.Keys)
    {
        int frequency = frequencyDictionary[key];
        if (buckets[frequency] == null )
        {
            buckets[frequency] = new List<int>();
        }
        buckets[frequency].Add(key);
    }
    List<int> result = new List<int>();
    for(int i=buckets.Length-1; i>=0;i--)
    {
        if (result.Count >= k) break;
        if (buckets[i] != null)
            result.AddRange(buckets[i]);
    }
    return result.ToArray();

}
int[] nums = {1,1,1,2,2,3,4,5};
// freq = {3,1,1,2,1}
int k = 2;
TopKFrequent(nums, k);

static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
    for(int i=0; i < nums.Length;i++)
    {
        if (keyValuePairs.ContainsKey(target - nums[i]))
            return new int[] { i, keyValuePairs[target - nums[i]] };
        if (!keyValuePairs.ContainsKey(nums[i]))
            keyValuePairs.Add(nums[i], i);
    }
    return new int[1];
}
int[] nums = { 3, 2, 4 };
var a = TwoSum(nums, 6);
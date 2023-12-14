//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

 

//Example 1:

//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

//Example 2:

//Input: nums = [3, 2, 4], target = 6
//Output: [1,2]


static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (keyValuePairs.ContainsKey(target - nums[i]))
            return new int[] { i, keyValuePairs[target - nums[i]] };
        if (!keyValuePairs.ContainsKey(nums[i]))
            keyValuePairs.Add(nums[i], i);
    }
    return new int[1];
}
int[] nums = { 2, 7, 11, 15 };
int target = 9;
TwoSum(nums, target);
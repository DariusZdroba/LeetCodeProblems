//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.



//Example 1:

//Input: nums = [1, 2, 3, 1]
//Output: true

//Example 2:

//Input: nums = [1, 2, 3, 4]
//Output: false

static bool ContainsDuplicate(int[] nums)
{
    HashSet<int> result = new HashSet<int>();
    for(int i = 0; i < nums.Length; i++)
    {
        if (result.Contains(nums[i])) return true;
        result.Add(nums[i]);
    }
    return false;
}
int[] nums = { 1, 2, 3, 4, 1 };
ContainsDuplicate(nums);
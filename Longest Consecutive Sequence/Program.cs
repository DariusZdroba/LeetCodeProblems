//Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

//You must write an algorithm that runs in O(n) time.



//Example 1:

//Input: nums = [100, 4, 200, 1, 3, 2]
//Output: 4
//Explanation: The longest consecutive elements sequence is [1, 2, 3, 4].Therefore its length is 4.

//Example 2:

//Input: nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
//Output: 9




//Constraints:

//0 <= nums.length <= 105
//- 109 <= nums[i] <= 109

using System.Diagnostics.Metrics;

static int LongestConsecutive(int[] nums)
{
    HashSet<int> result = new HashSet<int>(nums);
    int longest = 0;
    int length = 0;
    foreach(int num in result)
    {
        //checking if it's the start of a sequence
        if(!result.Contains(num-1))
        {
            length = 0;
            while(result.Contains(num+length))
            {
                length++;
            }
            longest = Math.Max(longest, length);
        }

    }
    
        
        return longest;

}

int[] nums = {1, 5, 2, 5, 6, 0 ,3 };
LongestConsecutive(nums);

//given an integer array nums and an integer k, return the k most frequent elements. you may return the answer in any order.



//example 1:

//input: nums = [1, 1, 1, 2, 2, 3], k = 2
//output: [1,2]
//example 2:

//input: nums = [1], k = 1
//output: [1]

static int[] TopKFrequent(int[] nums, int k)
{
    int[] freqArr = new int[nums.Length*10];
    int[] outputArr = new int[k];

    for(int i=0; i<nums.Length; i++)
    {
         freqArr[nums[i]]++;
        
    }
    Array.Sort(freqArr);
    int cnt = 0;
    for(int j = freqArr.Length-1; j >= freqArr.Length-k; j--)
    {
        outputArr[cnt] = freqArr[j];
        cnt++;
    }
    return outputArr;
}
int[] nums = {1,1,1,2,2,3,4,5};
// freq = {3,1,1,2,1}
int k = 2;
TopKFrequent(nums, k);

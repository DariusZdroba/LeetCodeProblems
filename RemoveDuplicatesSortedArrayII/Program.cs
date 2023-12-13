// See https://aka.ms/new-console-template for more information
static int[] RemoveDuplicates(int[] nums)
{
    if (nums.Length <= 2)
    {
        return nums;
    }
    int slow = 2;
    for (int fast = 2; fast < nums.Length; fast++)
    {
        if (nums[slow - 2] != nums[fast])
        {
            nums[slow] = nums[fast];
            slow++;
        }
    }
    return nums;
}
int[] nums = { 1, 1, 1, 2, 2, 3 };
foreach( var a in RemoveDuplicates(nums))
{
    Console.WriteLine(a + " ");
}
// See https://aka.ms/new-console-template for more information
int[] nums = { 1, 1, 1, 2, 2, 3 };
Console.WriteLine(RemoveDuplicates(nums));
 int RemoveDuplicates(int[] nums)
{
    int[] nums2 = new int[nums.Length];

    int counter = 0;
    int iterator = 0;
    int lastElem = nums[0];
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (counter > 1)
        {

            counter = 0;
            while (nums[i] == lastElem) i++;
        }
        if (counter <= 1)
        {
            nums2[iterator] = nums[i];
            iterator++;
        }

        if (nums[i] == lastElem)
            counter++;
        else lastElem = nums[i];
    }
    if (nums2[iterator-1] != nums[nums.Length-1]) nums2[iterator] = nums[nums.Length-1];
    nums = nums2;
    foreach(var n in nums2)
    Console.Write(n);
    return iterator;
}
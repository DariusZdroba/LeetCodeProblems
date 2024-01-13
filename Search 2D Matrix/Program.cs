//You are given an m x n integer matrix matrix with the following two properties:

//Each row is sorted in non-decreasing order.
//The first integer of each row is greater than the last integer of the previous row.
//Given an integer target, return true if target is in matrix or false otherwise.

//You must write a solution in O(log(m * n)) time complexity.
//    Example 1: 
//    Input: matrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], target = 3
//Output: true
//    Example 2:
//    Input: matrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], target = 13
//Output: false
bool SearchMatrix(int[,] matrix, int target)
{
    if (matrix[0, 0] < target || matrix[matrix.GetLength(0), matrix.GetLength(1)] > target) return false;
    int i = 0;
    while(i < matrix.Rank && (target > matrix[i, matrix.GetLength(0)]))
    {
        i++;
    }
    int[] nums = new int[matrix.GetLength(0)];
    for(int k=0; k<matrix.GetLength(0);k++)
    {
        nums[k] = matrix[i, k];
    }
    return Search(nums, target);

}
bool Search(int[] nums, int target)
{

    int left = 0;
    int right = nums.Length - 1;
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (nums[mid] == target) return true;
        if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return false;

}
int[,] matrix = { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 60 } };
SearchMatrix(matrix, 6);
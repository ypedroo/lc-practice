namespace RotateArray;

public class Failedsolutions
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         int[] nums = { 0, 1, 2, 3, 4, 5, 6 };
    //         var k = 2;
    //         RotateArray(nums, k);
    //     }
    //
    //     static void RotateArray(int[] nums, int k)
    //     {
    //         // If the array is empty or k is 0, return the array
    //         if (nums.Length == 0 || k == 0) return;
    //         // If k is greater than the length of the array, get the remainder of k divided by the length of the array
    //         k %= nums.Length;
    //         for (int i = 0; i < k; i++)
    //         {
    //             // Get the last element of the array
    //             var last = nums[^1];
    //             // Iterate through the array starting from the second to the last element
    //             for (var j = nums.Length - 1; j > 0; j--)
    //             {
    //                 // Set the current element to the previous element
    //                 nums[j] = nums[j - 1];
    //             }
    //             // Set the first element to the last element
    //             nums[0] = last;
    //         }
    //     
    //         Console.WriteLine($"[{string.Join(", ", nums)}]");
    //     }
    // }
}
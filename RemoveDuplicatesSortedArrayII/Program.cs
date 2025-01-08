class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
        int k = RemoveDuplicates(nums);
        Console.WriteLine(k);
    }

    static int RemoveDuplicates(int[] nums)
    {
        // If the array has less than 2 elements, return the length of the array
        if (nums.Length <= 2) return nums.Length;
        // Start from the 3rd element
        int k = 2;
        // Iterate through the array starting from the 3rd element since we can have two duplicates and then check if the current element is not equal to the element 2 positions before it.
        // Also the array is ordered so we can check if the current element is not equal to the element 2 positions before it.
        for (int i = 2; i < nums.Length; i++)
        {
            // If the current element is not equal to the element 2 positions before it
            if (nums[i] != nums[k - 2])
            {
                // Set the current element to the kth element
                nums[k] = nums[i];
                // Increment k
                k++;
            }
        }

        return k;
    }
}
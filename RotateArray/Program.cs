class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 1, 2, 3, 4, 5, 6 };
        var k = 3;
        RotateArray(nums, k);
    }

    static void RotateArray(int[] nums, int k)
    {
        // If the array is empty or k is 0, return the array
        if (nums.Length == 0 || k == 0) return;
        var n = nums.Length;
        k %= n;
        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
        
        Console.WriteLine($"[{string.Join(", ", nums)}]");
    }
    
    static void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
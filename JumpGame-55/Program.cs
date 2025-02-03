class Program {

    static void Main(string[] args) {
        int[] nums = { 3,2,1,0,4 };
        var canJump = CanJump(nums);
        Console.WriteLine(canJump);
    }

    private static bool CanJump(int[] nums) {
        var n = nums.Length;
        var lastPos = n - 1;
        for (var i = n - 1; i >= 0; i--) {
            if (i + nums[i] >= lastPos) {
                lastPos = i;
            }
        }
        return lastPos == 0;
    }
}
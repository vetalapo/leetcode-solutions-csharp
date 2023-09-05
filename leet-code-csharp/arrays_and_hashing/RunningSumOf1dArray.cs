namespace leet_code_csharp.arrays_and_hashing;

public class RunningSumOf1dArray
{
    public int[] RunningSum( int[] nums )
    {
        for ( int i = 1; i < nums.Length; i++ )
        {
            nums[i] += nums[i - 1];
        }

        return nums;
    }
}

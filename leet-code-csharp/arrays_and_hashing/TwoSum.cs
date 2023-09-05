namespace leet_code_csharp.arrays_and_hashing;

public class TwoSumSolution
{
    public int[] TwoSum( int[] nums, int target )
    {
        Dictionary<int, int> indices = new();

        for ( int i = 0; i < nums.Length; i++ )
        {
            int diff = target - nums[i];

            if ( indices.ContainsKey( diff ) )
            {
                return new int[] { indices[diff], i };
            }

            indices[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}

namespace leet_code_csharp.two_pointers;

public class ThreeSumSolution
{
    public IList<IList<int>> ThreeSum( int[] nums )
    {
        List<IList<int>> result = new();

        Array.Sort( nums );

        for ( int i = 0; i < nums.Length; i++ )
        {
            if ( i > 0 && nums[i] == nums[i - 1] )
            {
                continue;
            }

            int start = i + 1;
            int end = nums.Length - 1;

            while ( start < end )
            {
                int threeSum = nums[i] + nums[start] + nums[end];

                if ( threeSum == 0 )
                {
                    result.Add( new List<int> { nums[i], nums[start], nums[end] } );

                    start++;

                    while ( nums[start] == nums[start - 1] && start < end )
                    {
                        start++;
                    }
                }
                else if ( threeSum > 0 )
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
        }

        return result;
    }
}

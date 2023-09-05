namespace leet_code_csharp.binary_search;

public class FindMinimumInRotatedSortedArray
{
    public int FindMin( int[] nums )
    {
        int left = 0;
        int right = nums.Length - 1;

        while ( left < right )
        {
            int middle = left + ( ( right - left ) / 2 );

            if ( nums[middle] > nums[right] )
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }

        return nums[left];
    }
}

namespace leet_code_csharp.binary_search;

public class BinarySearchSolution
{
    public int Search( int[] nums, int target )
    {
        int left = 0;
        int right = nums.Length - 1;

        while ( left <= right )
        {
            int middle = left + ( ( right - left ) / 2 ); // ( left + right ) / 2; can overflow if int.MaxValue

            if ( nums[middle] == target )
            {
                return middle;
            }
            else if ( nums[middle] > target )
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return -1;
    }
}

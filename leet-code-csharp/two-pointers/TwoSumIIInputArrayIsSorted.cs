namespace leet_code_csharp.two_pointers;

public class TwoSumIIInputArrayIsSorted
{
    public int[] TwoSum( int[] numbers, int target )
    {
        int start = 0;
        int end = numbers.Length - 1;

        while ( start < end )
        {
            int sum = numbers[start] + numbers[end];

            if ( sum == target )
            {
                return new int[] { start + 1, end + 1 };
            }
            else if ( sum > target )
            {
                end--;
            }
            else
            {
                start++;
            }
        }

        return Array.Empty<int>();
    }
}

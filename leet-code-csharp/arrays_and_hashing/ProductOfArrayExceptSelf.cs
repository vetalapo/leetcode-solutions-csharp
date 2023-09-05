namespace leet_code_csharp.arrays_and_hashing
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf( int[] nums )
        {
            int[] result = new int[nums.Length];

            int prefix = 1;

            for ( int i = 0; i < nums.Length; i++ )
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            int postfix = 1;

            for ( int i = nums.Length - 1; i >= 0; i-- )
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }

            return result;
        }

        public int[] ProductExceptSelfCombination( int[] nums )
        {
            int size = nums.Length;

            int[] result = new int[size];
            Array.Fill( result, 1 );

            int prefix = 1;
            int postfix = 1;

            for ( int i = 0; i < size; i++ )
            {
                result[i] *= prefix;
                prefix *= nums[i];

                result[size - i - 1] *= postfix;
                postfix *= nums[size - i - 1];
            }

            return result;
        }
    }
}

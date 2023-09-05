namespace leet_code_csharp.two_pointers;

public class ContainerWithMostWater
{
    public int MaxArea( int[] height )
    {
        int start = 0;
        int end = height.Length - 1;

        int maxArea = 0;

        while ( start < end )
        {
            int diff = end - start;
            int currentMinheight;

            if ( height[start] > height[end] )
            {
                currentMinheight = height[end];
                end--;
            }
            else
            {
                currentMinheight = height[start];
                start++;
            }

            maxArea = Math.Max( maxArea, diff * currentMinheight );
        }

        return maxArea;
    }
}

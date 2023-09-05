namespace leet_code_csharp.stack;

public class LargestRectangleInHistogram
{
    public int LargestRectangleArea( int[] heights )
    {
        int maxArea = 0;
        Stack<(int inx, int val)> stack = new();

        for ( int i = 0; i < heights.Length; i++ )
        {
            int startIndex = i;

            while ( stack.Count > 0 && stack.Peek().val > heights[i] )
            {
                (int inx, int val) previousHeight = stack.Peek();
                int previousHeightArea = previousHeight.val * ( i - previousHeight.inx );
                startIndex = previousHeight.inx;

                maxArea = Math.Max( maxArea, previousHeightArea );

                stack.Pop();
            }

            stack.Push( (inx: startIndex, val: heights[i]) );
        }

        while ( stack.Count > 0 )
        {
            (int inx, int val) height = stack.Pop();
            int heightArea = height.val * ( heights.Length - height.inx );

            maxArea = Math.Max( maxArea, heightArea );
        }

        return maxArea;
    }

    public int LargestRectangleAreaOneLoop( int[] heights )
    {
        int maxArea = 0;
        Stack<int> indxStack = new();

        for ( int i = 0; i <= heights.Length; i++ )
        {
            int height = i < heights.Length ? heights[i] : 0;

            while ( indxStack.Count > 0 && heights[indxStack.Peek()] > height )
            {
                int currentHeight = heights[indxStack.Pop()];
                int previousIndex = indxStack.Count == 0 ? -1 : indxStack.Peek();

                int currentArea = currentHeight * ( i - 1 - previousIndex );

                maxArea = Math.Max( maxArea, currentArea );
            }

            indxStack.Push( i );
        }

        return maxArea;
    }
}

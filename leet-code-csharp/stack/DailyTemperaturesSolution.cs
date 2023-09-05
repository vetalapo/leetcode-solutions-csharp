namespace leet_code_csharp.stack;

public class DailyTemperaturesSolution
{
    public int[] DailyTemperatures( int[] temperatures )
    {
        int[] result = new int[temperatures.Length];
        Stack<int> indxStack = new();

        for ( int i = 0; i < temperatures.Length; i++ )
        {
            while ( indxStack.Count > 0 && temperatures[i] > temperatures[indxStack.Peek()] )
            {
                int prevTempIndex = indxStack.Pop();

                result[prevTempIndex] = i - prevTempIndex;
            }

            indxStack.Push( i );
        }

        return result;
    }
}

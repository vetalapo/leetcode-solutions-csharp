namespace leet_code_csharp.stack;

public class CarFleetSolution
{
    public int CarFleet( int target, int[] position, int[] speed )
    {
        (int position, int speed)[] pairs = new (int, int)[position.Length];

        for ( int i = 0; i < pairs.Length; i++ )
        {
            pairs[i] = (position[i], speed[i]);
        }

        Stack<double> stack = new();

        foreach ( (int position, int speed) pair in pairs.OrderByDescending( x => x.position ) )
        {
            double time = ( target - pair.position ) / (double)pair.speed;

            stack.Push( time );

            if ( stack.Count >= 2 && time <= stack.ElementAt( 1 ) )
            {
                stack.Pop();
            }
        }

        return stack.Count;
    }
}

/**
 * 853
 * Car Fleet
 **
 * There are n cars going to the same destination along a one-lane road. The destination is target miles away.
 * You are given two integer array position and speed, both of length n,
 * where position[i] is the position of the ith car and speed[i] is the speed of the ith car (in miles per hour).
 * 
 * A car can never pass another car ahead of it, but it can catch up to it and drive bumper to bumper at the same speed.
 * The faster car will slow down to match the slower car's speed.
 * The distance between these two cars is ignored (i.e., they are assumed to have the same position).
 * 
 * A car fleet is some non-empty set of cars driving at the same position and same speed.
 * Note that a single car is also a car fleet.
 * 
 * If a car catches up to a car fleet right at the destination point, it will still be considered as one car fleet.
 * 
 * Return the number of car fleets that will arrive at the destination.
 * 
 * https://leetcode.com/problems/car-fleet/
 */

namespace Problems;

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

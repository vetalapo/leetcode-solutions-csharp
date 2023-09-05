namespace leet_code_csharp.arrays_and_hashing
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent( int[] nums, int k )
        {
            Dictionary<int, int> frequencyMap = new();

            foreach ( int n in nums )
            {
                if ( !frequencyMap.ContainsKey( n ) )
                {
                    frequencyMap[n] = 0;
                }

                frequencyMap[n]++;
            }

            PriorityQueue<int, int> priorityQueue = new();

            foreach ( int mapKey in frequencyMap.Keys )
            {
                priorityQueue.Enqueue( mapKey, frequencyMap[mapKey] );

                if ( priorityQueue.Count > k )
                {
                    priorityQueue.Dequeue();
                }
            }

            int[] result = new int[k];

            while ( priorityQueue.Count > 0 )
            {
                result[--k] = priorityQueue.Dequeue();
            }

            return result;
        }
    }
}

using BenchmarkDotNet.Running;

using leet_code_csharp.math;

namespace leet_code_csharp
{
    internal class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<FizzBuzzBenchmarks>();
        }
    }
}

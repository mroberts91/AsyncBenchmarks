using BenchmarkDotNet.Running;

namespace AsyncBenchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<AsyncBenchmark>();
            //var summary2 = BenchmarkRunner.Run<SyncOverAsync>();
        }
    }
}

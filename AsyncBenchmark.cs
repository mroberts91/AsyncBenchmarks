using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using System.Threading.Tasks;

namespace AsyncBenchmarks
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [RPlotExporter]
    [MemoryDiagnoser]
    public class AsyncBenchmark
    {
        private static readonly Consumer consumer = new Consumer();
        private readonly string LogMessage = "Some log msg";
        
        [Params(10, 20, 30)]
        public int IO_Bound_Task_Wait_ms { get; set; }

        [Benchmark]
        public async Task WhenAll_Async_TaskFromResult()
        {
            Task<string> task1 = FromResult();
            Task<string> task2 = SomeAsync();
            await Task.WhenAll(task1, task2);

            consumer.Consume(await task1);
            consumer.Consume(await task2);
        }

        [Benchmark]
        public async Task WhenAll_Async_TaskDotRun()
        {
            Task<string> task1 = DotRunTask();
            Task<string> task2 = SomeAsync();
            await Task.WhenAll(task1, task2);

            consumer.Consume(await task1);
            consumer.Consume(await task2);
        }

        [Benchmark]
        public async Task WhenAll_Async_TaskDotRunAsync()
        {
            Task<string> task1 = DotRunAsyncTask();
            Task<string> task2 = SomeAsync();
            await Task.WhenAll(task1, task2);

            consumer.Consume(await task1);
            consumer.Consume(await task2);
        }

        [Benchmark]
        public async Task Synchronous_Await_Async_TaskDotRunAsync()
        {
            var val1 = await DotRunAsyncTask();
            var val2 = await SomeAsync();
            consumer.Consume(val1);
            consumer.Consume(val2);
        }

        private Task<string> FromResult() => Task.FromResult(LogMessage);

        private Task<string> DotRunTask() => Task.Run(() => LogMessage);

        private async Task<string> DotRunAsyncTask() => await Task.Run(() => LogMessage);

        private async Task<string> SomeAsync()
        {
            await Task.Delay(IO_Bound_Task_Wait_ms);
            return LogMessage;
        }

    }
}

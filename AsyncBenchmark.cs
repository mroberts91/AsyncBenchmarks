using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using System.Threading.Tasks;

namespace AsyncBenchmarks
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [RPlotExporter]
    [MemoryDiagnoser]
    public class AsyncBenchmark
    {
        private static readonly Consumer consumer = new Consumer();
        private readonly string LogMessage = "Some log msg";
        
        [Params(10, 20, 30)]
        public int IO_ms { get; set; }

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

        private Task<string> FromResult() => Task.FromResult(LogMessage);

        private Task<string> DotRunTask() => Task.Run(() => LogMessage);

        private async Task<string> DotRunAsyncTask() => await Task.Run(() => LogMessage);

        private async Task<string> SomeAsync()
        {
            await Task.Delay(IO_ms);
            return LogMessage;
        }

    }

    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [RPlotExporter]
    [MemoryDiagnoser]
    public class SyncOverAsync
    {
        private static readonly Consumer consumer = new Consumer();
        private readonly string LogMessage = "Some log msg";

        [Params(10, 50, 100)]
        public int IO_ms { get; set; }

        [Benchmark]
        public async Task Baseline()
        {
            for (int i = 0; i < 10; i++)
            {
                await SomeAsync();
                consumer.Consume(await SomeAsync());
            }
        }

        [Benchmark]
        public void Synchronous_DotResult()
        {
            for (int i = 0; i < 10; i++)
            {
                var val2 = SomeAsync().Result;
                consumer.Consume(val2);
            }
        }

        [Benchmark]
        public void Synchronous_GetAwaiter_GetResult()
        {
            for (int i = 0; i < 10; i++)
            {
                var val2 = SomeAsync().GetAwaiter().GetResult();
                consumer.Consume(val2);
            }
        }

        [Benchmark]
        public void Synchronous_DotWait()
        {
            for (int i = 0; i < 10; i++)
            {
                Task<string> task2 = SomeAsync();
                task2.Wait();
                var val2 = task2.Result;
                consumer.Consume(val2);
            }
        }

        private async Task<string> SomeAsync()
        {
            await Task.Delay(IO_ms);
            return LogMessage;
        }
    }
}

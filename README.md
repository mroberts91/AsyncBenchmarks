``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.928 (20H2/October2020Update)
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.4.21255.9
  [Host]               : .NET 6.0.0 (6.0.21.25307), X64 RyuJIT
  .NET 6.0             : .NET 6.0.0 (6.0.21.25307), X64 RyuJIT
  .NET Framework 4.7.2 : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT


```
|                        Method |                  Job |              Runtime | IO_ms |     Mean |    Error |   StdDev | Ratio | RatioSD | Allocated |
|------------------------------ |--------------------- |--------------------- |------ |---------:|---------:|---------:|------:|--------:|----------:|
|  **WhenAll_Async_TaskFromResult** |             **.NET 6.0** |             **.NET 6.0** |    **10** | **15.73 ms** | **0.131 ms** | **0.116 ms** |  **1.00** |    **0.01** |   **810 B** |
|  WhenAll_Async_TaskFromResult | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    10 | 15.75 ms | 0.251 ms | 0.210 ms |  1.00 |    0.00 |   1,408 B |
|                               |                      |                      |       |          |          |          |       |         |           |
|      WhenAll_Async_TaskDotRun |             .NET 6.0 |             .NET 6.0 |    10 | 15.58 ms | 0.194 ms | 0.172 ms |  0.99 |    0.02 |     878 B |
|      WhenAll_Async_TaskDotRun | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    10 | 15.69 ms | 0.292 ms | 0.259 ms |  1.00 |    0.00 |   1,792 B |
|                               |                      |                      |       |          |          |          |       |         |           |
| WhenAll_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    10 | 15.72 ms | 0.296 ms | 0.291 ms |  1.00 |    0.02 |     996 B |
| WhenAll_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    10 | 15.69 ms | 0.216 ms | 0.191 ms |  1.00 |    0.00 |   2,176 B |
|                               |                      |                      |       |          |          |          |       |         |           |
|  **WhenAll_Async_TaskFromResult** |             **.NET 6.0** |             **.NET 6.0** |    **20** | **31.39 ms** | **0.623 ms** | **0.717 ms** |  **0.99** |    **0.02** |   **817 B** |
|  WhenAll_Async_TaskFromResult | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    20 | 31.52 ms | 0.601 ms | 0.590 ms |  1.00 |    0.00 |   1,792 B |
|                               |                      |                      |       |          |          |          |       |         |           |
|      WhenAll_Async_TaskDotRun |             .NET 6.0 |             .NET 6.0 |    20 | 31.35 ms | 0.457 ms | 0.427 ms |  1.00 |    0.03 |     876 B |
|      WhenAll_Async_TaskDotRun | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    20 | 31.31 ms | 0.604 ms | 0.671 ms |  1.00 |    0.00 |   3,584 B |
|                               |                      |                      |       |          |          |          |       |         |           |
| WhenAll_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    20 | 31.46 ms | 0.359 ms | 0.335 ms |  1.01 |    0.01 |     996 B |
| WhenAll_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    20 | 31.24 ms | 0.397 ms | 0.352 ms |  1.00 |    0.00 |   4,096 B |
|                               |                      |                      |       |          |          |          |       |         |           |
|  **WhenAll_Async_TaskFromResult** |             **.NET 6.0** |             **.NET 6.0** |    **30** | **33.32 ms** | **0.666 ms** | **1.056 ms** |  **0.98** |    **0.04** |   **817 B** |
|  WhenAll_Async_TaskFromResult | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    30 | 34.02 ms | 0.670 ms | 1.292 ms |  1.00 |    0.00 |   2,341 B |
|                               |                      |                      |       |          |          |          |       |         |           |
|      WhenAll_Async_TaskDotRun |             .NET 6.0 |             .NET 6.0 |    30 | 33.74 ms | 0.656 ms | 1.150 ms |  1.00 |    0.04 |     882 B |
|      WhenAll_Async_TaskDotRun | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    30 | 33.62 ms | 0.647 ms | 0.818 ms |  1.00 |    0.00 |   4,096 B |
|                               |                      |                      |       |          |          |          |       |         |           |
| WhenAll_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    30 | 33.45 ms | 0.630 ms | 1.018 ms |  0.99 |    0.05 |   1,002 B |
| WhenAll_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    30 | 33.33 ms | 0.641 ms | 1.721 ms |  1.00 |    0.00 |   4,369 B |

``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.928 (20H2/October2020Update)
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.4.21255.9
  [Host]               : .NET 6.0.0 (6.0.21.25307), X64 RyuJIT
  .NET 5.0             : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  .NET 6.0             : .NET 6.0.0 (6.0.21.25307), X64 RyuJIT
  .NET Framework 4.7.2 : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT


```
|                                  Method |                  Job |              Runtime | IO_MS |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD | Allocated |
|---------------------------------------- |--------------------- |--------------------- |---------------------- |---------:|---------:|---------:|---------:|------:|--------:|----------:|
|            **WhenAll_Async_TaskFromResult** |             **.NET 5.0** |             **.NET 5.0** |    **10** | **15.90 ms** | **0.316 ms** | **0.432 ms** | **15.72 ms** |  **1.00** |    **0.04** |    **776 B** |
|            WhenAll_Async_TaskFromResult |             .NET 6.0 |             .NET 6.0 |    10 | 15.79 ms | 0.255 ms | 0.238 ms | 15.73 ms |  0.99 |    0.04 |      810 B |
|            WhenAll_Async_TaskFromResult | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    10 | 15.85 ms | 0.313 ms | 0.449 ms | 15.59 ms |  1.00 |    0.00 |    1,408 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
|                WhenAll_Async_TaskDotRun |             .NET 5.0 |             .NET 5.0 |    10 | 15.67 ms | 0.215 ms | 0.179 ms | 15.59 ms |  1.00 |    0.01 |      840 B |
|                WhenAll_Async_TaskDotRun |             .NET 6.0 |             .NET 6.0 |    10 | 15.67 ms | 0.201 ms | 0.178 ms | 15.70 ms |  1.00 |    0.02 |      875 B |
|                WhenAll_Async_TaskDotRun | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    10 | 15.70 ms | 0.219 ms | 0.194 ms | 15.70 ms |  1.00 |    0.00 |    1,792 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
|           WhenAll_Async_TaskDotRunAsync |             .NET 5.0 |             .NET 5.0 |    10 | 15.75 ms | 0.308 ms | 0.401 ms | 15.51 ms |  1.00 |    0.03 |      960 B |
|           WhenAll_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    10 | 15.75 ms | 0.256 ms | 0.227 ms | 15.71 ms |  1.00 |    0.01 |    1,003 B |
|           WhenAll_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    10 | 15.78 ms | 0.300 ms | 0.295 ms | 15.73 ms |  1.00 |    0.00 |    2,048 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
| Synchronous_Await_Async_TaskDotRunAsync |             .NET 5.0 |             .NET 5.0 |    10 | 15.71 ms | 0.309 ms | 0.356 ms | 15.58 ms |  1.01 |    0.03 |      736 B |
| Synchronous_Await_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    10 | 15.59 ms | 0.230 ms | 0.204 ms | 15.48 ms |  1.00 |    0.02 |      823 B |
| Synchronous_Await_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    10 | 15.60 ms | 0.266 ms | 0.273 ms | 15.49 ms |  1.00 |    0.00 |    2,048 B |
|                                         |                      |                      |                       |          |          |          |          |       |         |       |       |       |           |
|            **WhenAll_Async_TaskFromResult** |             **.NET 5.0** |             **.NET 5.0** |    **20** | **31.24 ms** | **0.466 ms** | **0.436 ms** | **31.02 ms** |  **1.01** |    **0.01** |    **776 B** |
|            WhenAll_Async_TaskFromResult |             .NET 6.0 |             .NET 6.0 |    20 | 31.27 ms | 0.321 ms | 0.285 ms | 31.26 ms |  1.01 |    0.02 |      812 B |
|            WhenAll_Async_TaskFromResult | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    20 | 31.01 ms | 0.406 ms | 0.339 ms | 30.92 ms |  1.00 |    0.00 |    2,560 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
|                WhenAll_Async_TaskDotRun |             .NET 5.0 |             .NET 5.0 |    20 | 31.11 ms | 0.489 ms | 0.433 ms | 30.88 ms |  0.99 |    0.02 |      840 B |
|                WhenAll_Async_TaskDotRun |             .NET 6.0 |             .NET 6.0 |    20 | 31.40 ms | 0.618 ms | 0.736 ms | 31.05 ms |  1.01 |    0.03 |      881 B |
|                WhenAll_Async_TaskDotRun | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    20 | 31.30 ms | 0.482 ms | 0.428 ms | 31.32 ms |  1.00 |    0.00 |    3,072 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
|           WhenAll_Async_TaskDotRunAsync |             .NET 5.0 |             .NET 5.0 |    20 | 31.31 ms | 0.304 ms | 0.253 ms | 31.36 ms |  1.00 |    0.03 |      960 B |
|           WhenAll_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    20 | 31.35 ms | 0.330 ms | 0.293 ms | 31.28 ms |  1.00 |    0.03 |      996 B |
|           WhenAll_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    20 | 31.41 ms | 0.617 ms | 0.686 ms | 31.65 ms |  1.00 |    0.00 |    3,584 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
| Synchronous_Await_Async_TaskDotRunAsync |             .NET 5.0 |             .NET 5.0 |    20 | 31.36 ms | 0.617 ms | 0.606 ms | 31.06 ms |  1.00 |    0.02 |      736 B |
| Synchronous_Await_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    20 | 31.36 ms | 0.562 ms | 0.602 ms | 31.28 ms |  1.00 |    0.03 |      777 B |
| Synchronous_Await_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    20 | 31.47 ms | 0.554 ms | 0.491 ms | 31.33 ms |  1.00 |    0.00 |    2,304 B |
|                                         |                      |                      |                       |          |          |          |          |       |         |       |       |       |           |
|            **WhenAll_Async_TaskFromResult** |             **.NET 5.0** |             **.NET 5.0** |    **30** | **33.10 ms** | **0.595 ms** | **0.464 ms** | **33.01 ms** |  **0.97** |    **0.04** |    **776 B** |
|            WhenAll_Async_TaskFromResult |             .NET 6.0 |             .NET 6.0 |    30 | 33.93 ms | 0.675 ms | 1.642 ms | 33.70 ms |  0.98 |    0.05 |      817 B |
|            WhenAll_Async_TaskFromResult | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    30 | 34.34 ms | 0.678 ms | 1.114 ms | 34.23 ms |  1.00 |    0.00 |    2,341 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
|                WhenAll_Async_TaskDotRun |             .NET 5.0 |             .NET 5.0 |    30 | 33.75 ms | 0.668 ms | 1.494 ms | 33.68 ms |  0.98 |    0.06 |      840 B |
|                WhenAll_Async_TaskDotRun |             .NET 6.0 |             .NET 6.0 |    30 | 33.97 ms | 0.665 ms | 1.074 ms | 33.87 ms |  0.98 |    0.05 |      881 B |
|                WhenAll_Async_TaskDotRun | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    30 | 34.58 ms | 0.683 ms | 1.250 ms | 34.71 ms |  1.00 |    0.00 |    3,277 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
|           WhenAll_Async_TaskDotRunAsync |             .NET 5.0 |             .NET 5.0 |    30 | 34.15 ms | 0.679 ms | 1.241 ms | 33.95 ms |  0.99 |    0.05 |      960 B |
|           WhenAll_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    30 | 33.81 ms | 0.675 ms | 1.439 ms | 33.83 ms |  0.99 |    0.05 |    1,002 B |
|           WhenAll_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    30 | 34.47 ms | 0.686 ms | 1.236 ms | 34.48 ms |  1.00 |    0.00 |    3,584 B |
|                                         |                      |                      |       |          |          |          |          |       |         |            |
| Synchronous_Await_Async_TaskDotRunAsync |             .NET 5.0 |             .NET 5.0 |    30 | 34.50 ms | 0.657 ms | 1.217 ms | 34.75 ms |  0.99 |    0.06 |      736 B |
| Synchronous_Await_Async_TaskDotRunAsync |             .NET 6.0 |             .NET 6.0 |    30 | 34.19 ms | 0.684 ms | 1.365 ms | 34.36 ms |  0.98 |    0.06 |      777 B |
| Synchronous_Await_Async_TaskDotRunAsync | .NET Framework 4.7.2 | .NET Framework 4.7.2 |    30 | 34.87 ms | 0.688 ms | 1.553 ms | 34.96 ms |  1.00 |    0.00 |    4,369 B |

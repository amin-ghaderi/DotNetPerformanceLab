```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v4


```
| Method   | Mean     | Error   | StdDev   | Allocated |
|--------- |---------:|--------:|---------:|----------:|
| ArraySum | 417.4 μs | 8.19 μs | 12.00 μs |         - |
| ListSum  | 457.1 μs | 9.09 μs | 16.63 μs |         - |

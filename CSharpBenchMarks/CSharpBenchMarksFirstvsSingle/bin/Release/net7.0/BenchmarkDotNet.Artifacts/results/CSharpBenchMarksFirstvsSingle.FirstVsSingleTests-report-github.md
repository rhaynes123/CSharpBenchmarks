``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK=7.0.304
  [Host]     : .NET 7.0.7 (7.0.723.27404), Arm64 RyuJIT AdvSIMD [AttachedDebugger]
  DefaultJob : .NET 7.0.7 (7.0.723.27404), Arm64 RyuJIT AdvSIMD


```
|     Method |      Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|----------- |----------:|----------:|----------:|-----:|-------:|----------:|
| SingleTest | 10.119 μs | 0.0030 μs | 0.0026 μs |    2 |      - |      40 B |
|  FirstTest |  1.096 μs | 0.0034 μs | 0.0032 μs |    1 | 0.0057 |      40 B |

// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using CSharpBenchMarkMappers;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<ProductMapperTests>();
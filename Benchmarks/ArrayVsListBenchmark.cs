using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DotNetPerformanceLab.Benchmarks;

[MemoryDiagnoser]
public class ArrayVsListBenchmark
{
    private int[] array;
    private List<int> list;
   
    [GlobalSetup]
    public void Setup()
    {
        array = Enumerable.Range(1, 1000000).ToArray();
        list = array.ToList();
    }

    [Benchmark]
    public int ArraySum()
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];

        return sum;
    }

    [Benchmark]
    public int ListSum()
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
            sum += list[i];

        return sum;
    }
}
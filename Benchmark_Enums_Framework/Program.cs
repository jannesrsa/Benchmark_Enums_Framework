using Benchmark_Enums;
using BenchmarkDotNet.Running;
using System;

namespace MyBenchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ReflectionVsDictionary>();

            //var reflectionVsDictionary = new ReflectionVsDictionary();

            //for (int i = 1; i <= 13; i++)
            //{
            //    var _enumType = (SystemResourceInfoType)i;

            //    var displayName = _enumType.GetDisplayName();
            //    var enumDescription = _enumType.GetEnumDescription();

            //    Console.WriteLine($"DisplayName: {displayName}");
            //    Console.WriteLine($"enumDescription: {enumDescription}");
            //}

            Console.ReadKey();
        }
    }
}
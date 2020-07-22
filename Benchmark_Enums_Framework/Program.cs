using Benchmark_Enums;
using BenchmarkDotNet.Running;
using SourceCode.Forms.Utilities.DataProviders.Models;
using SourceCode.Forms.Utilities.DataProviders.Models.Extensions;
using System;

namespace MyBenchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reflectionVsDictionary = new ReflectionVsDictionary();

            for (int i = 1; i <= 13; i++)
            {
                var _enumType = (SystemResourceInfoType)i;

                Console.WriteLine($"GetDisplayName: {_enumType.GetDisplayName()}");
                Console.WriteLine($"GetEnumDescription: {_enumType.GetEnumDescription()}");
                Console.WriteLine($"GetEnumAsString: {_enumType.GetEnumAsString()}");
                Console.WriteLine($"GetDisplayNameWithSwitch: {_enumType.GetDisplayNameWithSwitch()}");
                Console.WriteLine($"-------------------------------------------------------------------------------------");
            }

            Console.WriteLine($"Press any key to start benchmarking ...");
            Console.ReadKey();

            _ = BenchmarkRunner.Run<ReflectionVsDictionary>();

            Console.ReadKey();
        }
    }
}
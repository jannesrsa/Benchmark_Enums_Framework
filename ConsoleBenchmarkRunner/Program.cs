﻿using BenchmarkDotNet.Running;
using BenchmarkEnumToStringDotNetStandard;
using System;

namespace ConsoleBenchmarkRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 13; i++)
            {
                var enumToStringBenchmarks = new EnumToStringBenchmarks();
                enumToStringBenchmarks.EnumValue = (SystemResourceInfoType)i;

                Console.WriteLine($"UseDictionary: { _ = enumToStringBenchmarks.UseDictionary() }");
                Console.WriteLine($"DisplayAtrribute: { _ = enumToStringBenchmarks.DisplayAtrribute() }");
                Console.WriteLine($"EnumToString: { _ = enumToStringBenchmarks.EnumToString() }");
                Console.WriteLine($"SwitchStatement: {_ = enumToStringBenchmarks.SwitchStatement() }");
                Console.WriteLine($"-------------------------------------");
            }

            _ = BenchmarkRunner.Run<EnumToStringBenchmarks>();

            Console.ReadKey();
        }
    }
}
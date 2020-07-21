using BenchmarkDotNet.Attributes;
using SourceCode.Forms.Utilities.DataProviders.Models;
using SourceCode.Forms.Utilities.DataProviders.Models.Extensions;
using System;

namespace Benchmark_Enums
{
    [MemoryDiagnoser]
    public class ReflectionVsDictionary
    {
        private readonly SystemResourceInfoType _enumType;

        public ReflectionVsDictionary()
        {
            _enumType = (SystemResourceInfoType)new Random().Next(1, 13);
        }

        [Benchmark]
        public string GetDisplayName() => _enumType.GetDisplayName();

        [Benchmark(Baseline = true)]
        public string GetEnumAsString() => _enumType.GetEnumAsString();

        [Benchmark]
        public string GetEnumDescription() => _enumType.GetEnumDescription();
    }
}
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BenchmarkEnumToStringDotNetStandard
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class EnumToStringBenchmarks
    {
        public EnumToStringBenchmarks()
        {
            EnumValue = (SystemResourceInfoType)new Random().Next(1, 13);
        }

        public SystemResourceInfoType EnumValue { get; set; }

        public static void Run()
        {
            _ = BenchmarkRunner.Run<EnumToStringBenchmarks>();
        }

        [Benchmark]
        public string DisplayAtrribute()
        {
            var fi = EnumValue.GetType().GetField(EnumValue.ToString());

            var attributes = fi?.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (attributes?.First()?.Description != null)
            {
                return attributes?.First()?.Description;
            }

            return EnumValue.ToString();
        }

        [Benchmark(Baseline = true)]
        public string EnumToString() => EnumValue.ToString();

        [Benchmark]
        public string SwitchStatement()
        {
            switch (EnumValue)
            {
                case SystemResourceInfoType.DateTimeNow:
                    return "datetime-now";

                case SystemResourceInfoType.User:
                    return "user";

                case SystemResourceInfoType.Field:
                    return "field";

                case SystemResourceInfoType.Client:
                    return "client";

                case SystemResourceInfoType.Error:
                    return "error";

                case SystemResourceInfoType.RenderMode:
                    return "rendermode";

                case SystemResourceInfoType.Workflow:
                    return "workflow";

                case SystemResourceInfoType.ProcessActivities:
                    return "process-activities";

                case SystemResourceInfoType.TextboxControl:
                    return "textbox-control";

                case SystemResourceInfoType.Controls:
                    return "controls";

                case SystemResourceInfoType.DropdownControl:
                    return "dropdown-control";

                case SystemResourceInfoType.Folder:
                    return "folder";

                case SystemResourceInfoType.SystemValues:
                    return "systemvalues";

                default:
                    throw new ArgumentOutOfRangeException(nameof(EnumValue));
            }
        }

        [Benchmark]
        public string UseDictionary() => EnumValue.FromDictionary();
    }
}
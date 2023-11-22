using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using Box_UnBox.BenchMakr;
using System.Collections.Generic;

namespace Box_UnBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MemoryBenchmarkDeom>();

            var simple = new MemoryBenchmarkDeom();     

            var pointS = new PointStruct();
            var pointO = new PointObject();

            pointS = simple.BarStruct();
            pointO = simple.BarObject();

            Console.WriteLine($"pointS.x {pointS.x} pointS.y {pointS.y}");
            Console.WriteLine($"pointO.x {pointO.x} pointS.y {pointO.y}");

            Console.WriteLine(summary);

        }


    }

    //public class Kuvalda
    //{

    //}
}

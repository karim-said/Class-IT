using System.Linq;
using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Box_UnBox.BenchMakr
{
    [MemoryDiagnoser]
    public class MemoryBenchmarkDeom
    {
        [Benchmark]
        public int NotBoxing()
        {
            int a = 2;
            int b = a;

            for (int i = 0; i < 100; i++)
            {
                b += b;
            }

            return b;

        }

        [Benchmark]    
        public int Boxing()
        {
            int a = 12;
            object b = a;

            for (int i = 0; i < 100; i++)
            {
                b = (int)b + 2;
            } 

            return (int)b;
        }

        [Benchmark]
        public PointObject FooObject()
        {
            PointObject pointObject = new PointObject();
            pointObject.x = 32343245454;
            pointObject.y = 32343245454;

            PointObject pointObject1 = new PointObject();
            pointObject1.x = 32343245454;
            pointObject1.y = 32343245454;
             

            PointObject pointObject2 = new PointObject();
            pointObject2.x = 32343245454;
            pointObject2.y = 32343245454;
             

            PointObject pointObject3 = new PointObject();
            pointObject3.x = 32343245454;
            pointObject3.y = 32343245454;
             

            PointObject pointObject4 = new PointObject();
            pointObject4.x = 32343245454;
            pointObject4.y = 32343245454; 

            return pointObject;
        }

        [Benchmark]
        public PointStruct FooStruct()
        {
            var pointStruct = new PointStruct();

            pointStruct.x = 32343245454;
            pointStruct.y = 32343245454;

            var pointStruct1 = new PointStruct();

            pointStruct1.x = 32343245454;
            pointStruct1.y = 32343245454;

            var pointStruct2 = new PointStruct();

            pointStruct2.x = 32343245454;
            pointStruct2.y = 32343245454;

            var pointStruct3 = new PointStruct();

            pointStruct3.x = 32343245454;
            pointStruct3.y = 32343245454;

            var pointStruct4 = new PointStruct();

            pointStruct4.x = 32343245454;
            pointStruct4.y = 32343245454;

            return pointStruct;
        }


        [Benchmark]
        public PointObject BarObject()
        {
            var avrPoint = new PointObject();

            var pointOs = new List<PointObject>
            {
                 new PointObject
                {
                    x = 20,
                    y = 21
                },
                new PointObject
                {
                    x = 33,
                    y = 21
                },
                new PointObject
                {
                    x = 30,
                    y = 21
                },
            };

            avrPoint.x = pointOs.Average(x => x.x);
            avrPoint.y = pointOs.Average(x => x.y);

            return avrPoint;
        }


        [Benchmark]
        public PointStruct BarStruct()
        { 
            var avrPoint = new PointStruct();

            var pointSs = new List<PointStruct>
            {
                new PointStruct
                {
                    x = 20,
                    y = 21
                },
                new PointStruct
                {
                    x = 33,
                    y = 21
                },
                new PointStruct
                {
                    x = 30,
                    y = 21
                },
            }; 

            avrPoint.x = pointSs.Average(x => x.x);
            avrPoint.y = pointSs.Average(x => x.y);

            return avrPoint;             
        }
    }
    
    public class PointObject
    {
        public decimal x { get; set; }
        public decimal y { get; set; }
    }

    public struct PointStruct
    {
        public decimal x { get; set; }
        public decimal y { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace AlgorithmsAndDataStructures
{
    public class BenchmarkClass
    {
        static PointClass[] arrayClass = GenerateArrayClass();
        static PointStruct[] arrayStruct = GenerateArrayStruct();

        public static PointClass[] GenerateArrayClass()
        {
            Random random = new Random();
            var array = new PointClass[10000];
            for (int i = 0; i < array.Length; i++)
            {
                var point = new PointClass() { X = random.Next(100), Y = random.Next(100) };
                array[i] = point;
            }
            return array;
        }
        public static PointStruct[] GenerateArrayStruct()
        {
            Random random = new Random();
            var array = new PointStruct[1000];
            for (int i = 0; i < array.Length; i++)
            {
                var point = new PointStruct() { X = random.Next(100), Y = random.Next(100) };
                array[i] = point;
            }
            return array;
        }

        public static PointClass GetRandomPointClass()
        {
            Random random = new Random();
            return arrayClass[random.Next(1, 1000)];
        }

        public static PointStruct GetRandomPointStruct()
        {
            Random random = new Random();
            return arrayStruct[random.Next(1, 1000)];
        }

        [Benchmark]
        public void PointClassDistanceFloatTest()
        {
            PointClass pointOne = GetRandomPointClass();
            PointClass pointTwo = GetRandomPointClass();
            PointClassDistanceFloat(pointOne, pointTwo);
        }

        [Benchmark]
        public void PointStructDistanceFloatTest()
        {
            PointStruct pointOne = GetRandomPointStruct();
            PointStruct pointTwo = GetRandomPointStruct();
            PointStructDistanceFloat(pointOne, pointTwo);
        }

        [Benchmark]
        public void PointStructDistanceDoubleTest()
        {
            PointStruct pointOne = GetRandomPointStruct();
            PointStruct pointTwo = GetRandomPointStruct();
            PointStructDistanceDouble(pointOne, pointTwo);
        }

        [Benchmark]
        public void PointStructDistanceFloatShortTest()
        {
            PointStruct pointOne = GetRandomPointStruct();
            PointStruct pointTwo = GetRandomPointStruct();
            PointStructDistanceFloatShort(pointOne, pointTwo);
        }

        public float PointClassDistanceFloat(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public float PointStructDistanceFloat(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public double PointStructDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public float PointStructDistanceFloatShort(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;

namespace AlgorithmsAndDataStructures
{
    public class Lesson3 : ILesson
    {
        public int Id => 3;

        public string Description => "Напишите тесты производительности для расчёта\n" +
            "дистанции между точками с помощью BenchmarkDotNet.\n";

        public void RunLesson()
        {
            Task1();   
        }

        private void Task1()
        {
            BenchmarkRunner.Run<BenchmarkClass>();
        }
    }
}

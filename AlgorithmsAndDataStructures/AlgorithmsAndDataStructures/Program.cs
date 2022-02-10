using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILesson> lessons = new List<ILesson>
            {
                new Lesson1(),
                new Lesson2(),
                new Lesson3()
            };

            while (true)
            {
                Console.Write("Введите номер урока: ");
                int numberLesson = Convert.ToInt32(Console.ReadLine());

                foreach(var lesson in lessons)
                {
                    if (lesson.Id == numberLesson)
                    {
                        Console.WriteLine(lesson.Description); 
                        lesson.RunLesson();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

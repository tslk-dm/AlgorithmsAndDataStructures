using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson1 lesson1 = new Lesson1();
            //lesson1.RunLesson();

            //Lesson2 lesson2 = new Lesson2();
            //lesson2.RunLesson();

            List<ILesson> lessons = new List<ILesson>
            {
                new Lesson1(),
                new Lesson2()
            };

            while (true)
            {
                Console.Write("Введите номер урока: ");
                int numberLesson = Convert.ToInt32(Console.ReadLine());

                foreach(var lesson in lessons)
                {
                    if (lesson.Id == numberLesson)
                    {
                        lesson.RunLesson();
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

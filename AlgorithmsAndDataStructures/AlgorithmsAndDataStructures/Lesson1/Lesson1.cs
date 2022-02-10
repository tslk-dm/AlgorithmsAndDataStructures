using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public class Lesson1 : ILesson
    {
        public int Id => 1;

        public string Description => "1. Напишите на C# функцию согласно блок-схеме.\n" + 
            "2. Посчитайте сложность функции.\n" + 
            "3. Реализуйте функцию вычисления числа Фибоначчи\n";

        public void RunLesson()
        {
            Console.WriteLine("Введите номер задания: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                default:
                    Console.WriteLine($"Задания с номером {taskNumber} не существует.");
                    break;
            }
        }

        private void Task1()
        {
            TestCheckNumberIsPrime(3, true);
            Console.WriteLine();
            TestCheckNumberIsPrime(4, false);
            Console.WriteLine();
        }

        private void Task2()
        {
            Console.WriteLine("Сложность функции - O(N^3)");
            Console.WriteLine();
        }

        private void Task3()
        {
            Console.Write("Введите номер числа последовательности Фибоначчи: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Рекурсивное вычисление");
            Console.WriteLine($"Число Фибоначчи: {GetFibonacciNumber.Recursion(number)}");
            Console.WriteLine("Вычисление через цикл");
            Console.WriteLine($"Число Фибоначчи: {GetFibonacciNumber.Cycle(number)}");
            Console.WriteLine();
        }

        private bool CheckNumberIsPrime(int number)
        {
            // int number = Convert.ToInt32(Console.ReadLine()); // ввод данных, указанный в блок схеме
            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                    d++;
                i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Простое");
                return true; //для реализации теста
            }
            else
            {
                Console.WriteLine("Не простое");
                return false;
            }
        }

        private void TestCheckNumberIsPrime(int number, bool сorrectAnswer)
        {
            Console.WriteLine($"Входное значение - {number}, ожидается {сorrectAnswer}");

            if (CheckNumberIsPrime(number) == сorrectAnswer)
            {
                Console.WriteLine("Тест пройден");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}

﻿using System;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания");
                int jobNumber = Convert.ToInt32(Console.ReadLine());

                switch (jobNumber)
                {
                    case 1:
                        TestCheckNumberIsPrime(3, true);
                        Console.WriteLine();
                        TestCheckNumberIsPrime(4, false);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Сложность функции - O(N^3)");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Введите номер числа последовательности Фибоначчи: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Рекурсивное вычисление");
                        Console.WriteLine($"Число Фибоначчи: {GetFibonacciNumber.Recursion(number)}");
                        Console.WriteLine("Вычисление через цикл");
                        Console.WriteLine($"Число Фибоначчи: {GetFibonacciNumber.Cycle(number)}");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine($"Задания с номером {jobNumber} не существует.");
                        break;
                }
            }
            
        }

        static bool CheckNumberIsPrime(int number)
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

        static void TestCheckNumberIsPrime(int number, bool сorrectAnswer)
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

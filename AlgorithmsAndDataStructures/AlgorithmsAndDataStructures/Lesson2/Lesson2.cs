using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    class Lesson2 : ILesson
    {
        public int Id => 2;

        public string Description => "Требуется реализовать класс двусвязного списка и операции вставки,\n" + 
            "удаления и поиска элемента в нём в соответствии с интерфейсом.\n";

        public void RunLesson()
        {
            Task1();
        }

        private void Task1()
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);
            Console.WriteLine("Список:");
            list.PrintList();

            Console.WriteLine("Добавили узел после узла со значением 20");
            Node node = list.FindNode(20);
            list.AddNodeAfter(node, 99);
            Console.WriteLine("Список:");
            list.PrintList();
            Console.WriteLine();

            Console.WriteLine("Удалили узел со значением 20");
            list.RemoveNode(node);
            Console.WriteLine("Список:");
            list.PrintList();
            Console.WriteLine();


            Console.WriteLine("Удалили узел с индексом 1, начиная с 0");
            list.RemoveNode(2);
            Console.WriteLine("Список:");
            list.PrintList();
            Console.WriteLine();

            Console.WriteLine("Количество узлов");
            Console.WriteLine(list.GetCount());
            Console.WriteLine();
        }
    }
}

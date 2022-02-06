using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    class DoublyLinkedList : ILinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddNode(int value) // добавляет новый элемент списка
        {
            Node newNode = new Node { Value = value };
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = newNode;
                currentNode.NextNode.PrevNode = currentNode;
                Tail = currentNode.NextNode;
            }
        }

        public void AddNodeAfter(Node node, int value) // добавляет новый элемент списка после определённого элемента
        {
            if (node.NextNode == null)
            {
                AddNode(value);
            }
            else
            {
                Node newNode = new Node
                {
                    Value = value,
                    NextNode = node.NextNode,
                    PrevNode = node.NextNode.PrevNode,
                };
                node.NextNode = newNode;
                newNode.NextNode.PrevNode = newNode;
            }
        }

        public Node FindNode(int searchValue) // ищет элемент по его значению
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
            }
            return null;

        }

        public int GetCount()
        {
            int count = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                currentNode = currentNode.NextNode;
                count++;
            }
            return count;
        }

        public void RemoveNode(int index) // удаляет элемент по порядковому номеру
        {
            
            if (index == 0)
            {
                Node newHead = Head.NextNode;
                Head.NextNode = null;
                Head = newHead;
                Head.PrevNode = null;   
            }
            else if (index == GetCount() - 1)
            {
                Node newTail = Tail.PrevNode;
                Tail.PrevNode = null;
                Tail = newTail;
                Tail.NextNode = null;
            }
            else
            {
                Node currentNode = Head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.PrevNode.NextNode = currentNode.NextNode;
                currentNode.NextNode.PrevNode = currentNode.PrevNode;
                currentNode.NextNode = null;
                currentNode.PrevNode = null;
            }
        }

        public void RemoveNode(Node node)
        {
            if (node.PrevNode == null)
            {
                Node newHead = Head.NextNode;
                Head.NextNode = null;
                Head = newHead;
                Head.PrevNode = null;
            }
            else if (node.NextNode == null)
            {
                Node newTail = Tail.PrevNode;
                Tail.PrevNode = null;
                Tail = newTail;
                Tail.NextNode = null;
            }
            else
            {
                node.PrevNode.NextNode = node.NextNode;
                node.NextNode.PrevNode = node.PrevNode;
                node.NextNode = null;
                node.PrevNode = null;
            }
        }
        public void PrintList()
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + "    ");
                currentNode = currentNode.NextNode;              
            }
            Console.WriteLine();
        }
    }
}

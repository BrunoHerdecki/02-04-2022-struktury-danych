using System;

namespace _02_04_2022_struktury_danych
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> head =
            new Node<int>(2,
            new Node<int>(5,
            new Node<int>(1)));
            AddAtEndOfSingleLinkedList<int>(-1, head);
            PrintSingleLinkedList<int>(head);
        }

        public static void AddAtEndOfSingleLinkedList<T>(T element, Node<T> head)
        {
            
           


        }

        public static void PrintSingleLinkedList<T>(Node<T> head)
        {
            if (head == null)
            {
                Console.WriteLine("head -> null");
            }
            else
            {
                Node<T> p = head;
                Console.Write("head -> ");
                while (p != null)
                {
                    Console.Write(p.Data + " -> ");
                    p = p.Next;
                }
                Console.Write("null");
            }

        }
    }
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data, Node<T> next = null)
        {
            Data = data; Next = next;
        }
        public override string ToString() => (this == null) ? "null" : $"{Data} -> ";
    }
}





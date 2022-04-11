using System;
using System.Collections.Generic;

namespace _02_04_2022_struktury_danych
{
    class Program
    {
        static void Main(string[] args)
        {

            var head = CreateSingleLinkedList<int>(2, 1, 2, 2, 1, 5, 1);
            PrintSingleLinkedList<int>(head);
            RemoveAllDuplicatesFromSortedLinkedList<int>(ref head);
            PrintSingleLinkedList<int>(head);

        }

        public static void RemoveAllDuplicatesFromSortedLinkedList<T>(ref Node<T> head)
        where T : IEquatable<T>, IComparable<T>
        {
            Node<T> current = head;
            while (current != null)
            {
                Node<T> prev = current;
                int position = 1;
                while (prev != null)
                {
                    Console.WriteLine(); PrintSingleLinkedList<T>(head);
                    if (prev.Next != null && EqualityComparer<T>.Default.Equals(current.Data, prev.Next.Data))
                    {
                        RemoveNodeAt<T>(position, ref head);
                    }
                    prev = prev.Next;
                    position++;
                }
                current = current.Next;
            }

        }

        public static void RemoveNodeAt<T>(int position, ref Node<T> head)
        {
            Node<T> current = head;
            int l = 0;
            int c = 0;

            while (current != null)
            {
                current = current.Next;
                c++;
            }
            current = head;
            if (position == c)
            {
                return;
            }

            if (current == null || current.Next == null)
            {
                return;
            }
            if (position == 0)
            {
                current = current.Next;
                head = current;

            }
            else
            {
                while (l < position - 1)
                {
                    current = current.Next;
                    l++;
                }
                current.Next = current.Next.Next;
            }

        }

        public static Node<T> CreateSingleLinkedList<T>(params T[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }

            Node<T> head = new Node<T>(arr[0]);
            Node<T> x = head;
            for (int i = 1; i < arr.Length; i++)
            {
                x.Next = new Node<T>(arr[i]);
                x = x.Next;
            }
            return head;
        }
        public static void AddAtEndOfSingleLinkedList<T>(T element, ref Node<T> head)
        {
            if (head == null)
            {
                head = new Node<T>(element);
            }
            else
            {
                Node<T> k = head;
                while (k.Next != null)
                {
                    k = k.Next;
                }
                k.Next = new Node<T>(element);
            }
        }
        public static Node<T> ReverseSingleLinkedList<T>(Node<T> head)
        {
            Node<T> prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            return head;
        }

        public static void MoveLastNodeToFront<T>(ref Node<T> head)
        {
            var current = head;
            Node<T> prev = head;
            if (current == null || current.Next == null)
            {
                return;
            }
            while (current.Next != null)
            {
                if (current.Next.Next == null)
                {
                    prev = current;
                }
                current = current.Next;
            }
            prev.Next = null;
            current.Next = (head);
            head = current;
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
                    Console.Write(p.ToString());
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





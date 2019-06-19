namespace p09._01.CustomLinkedList
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            // 15 <-> 10 <-> 5
            list.AddFirst(5);
            list.AddFirst(10);
            list.AddFirst(15);

            //IEnumerator<T> GetEnumerator()
            foreach (int element in list)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
            Console.WriteLine(list.Count == 3);

            // 15 <-> 10 <-> 5 <-> 20 <-> 25
            list.AddLast(20);
            list.AddLast(25);

            //IEnumerator<T> GetEnumerator()
            foreach (int element in list)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
            Console.WriteLine(list.Count == 3);

            int[] array = list.ToArray();
            Console.WriteLine(string.Join(", ", array));

            List<int> newList = list.ToList();
            Console.WriteLine(list.Count == 5);

            Console.WriteLine(
                $"List contains search element? {list.Contains(20)}");

            Console.WriteLine((int)list.RemoveFirst() == 15);
            Console.WriteLine((int)list.RemoveFirst() == 10);
            Console.WriteLine(list.Count == 3);

            // 5 <-> 20 <-> 25
            Action<int> action = l => Console.Write($"{l} ");
            list.ForEach(action);
            Console.WriteLine();

            Console.WriteLine((int)list.RemoveLast() == 25);
            Console.WriteLine((int)list.RemoveLast() == 20);
            Console.WriteLine((int)list.RemoveLast() == 5);
            Console.WriteLine(list.Count == 0);
        }
    }
}
namespace p09._02.CustomLinkedList
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();

            // ccc <-> bbb <-> aaa
            list.AddFirst("aaa");
            list.AddFirst("bbb");
            list.AddFirst("ccc");

            list.ForEach(Console.WriteLine);
            Console.WriteLine(list.Count == 3);

            // ccc <-> bbb <-> aaa <-> ddd <-> eee
            list.AddLast("ddd");
            list.AddLast("eee");

            list.ForEach(Console.WriteLine);
            Console.WriteLine(list.Count == 3);

            string[] array = list.ToArray();
            Console.WriteLine(string.Join(", ", array));

            List<string> newList = list.ToList();
            Console.WriteLine(list.Count == 5);

            Console.WriteLine(
                $"List contains search element? {list.Contains("bbb")}");

            list.RemoveFirst();
            list.RemoveFirst();
            Console.WriteLine(list.Count == 3);

            // aaa <-> ddd <-> eee
            list.ForEach(Console.WriteLine);

            list.RemoveLast();
            list.RemoveLast();
            list.RemoveLast();
            Console.WriteLine(list.Count == 0);
        }
    }
}
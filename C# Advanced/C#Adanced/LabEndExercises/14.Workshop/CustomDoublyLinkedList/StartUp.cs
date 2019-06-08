namespace CustomDoublyLinkedList
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
           
            // 15 <-> 10 <-> 5
            list.AddFirst(5);
            list.AddFirst(10);
            list.AddFirst(15);

            Action<int> action = l => Console.Write($"{l} ");
            list.ForEach(action);
            Console.WriteLine();
            Console.WriteLine(list.Count == 3);

            // 15 <-> 10 <-> 5 <-> 20 <-> 25
            list.AddLast(20);
            list.AddLast(25);

            list.ForEach(action);
            Console.WriteLine();
            Console.WriteLine(list.Count == 3);

            int[] array = list.ToArray();
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine(list.Count == 5);

            Console.WriteLine((int)list.RemoveFirst() == 15);
            Console.WriteLine((int)list.RemoveFirst() == 10); 
            Console.WriteLine(list.Count == 3);

            // 5 <-> 20 <-> 25
            list.ForEach(action);
            Console.WriteLine();

            Console.WriteLine((int)list.RemoveLast() == 25);
            Console.WriteLine((int)list.RemoveLast() == 20);
            Console.WriteLine((int)list.RemoveLast() == 5);
            Console.WriteLine(list.Count == 0);
        }
    }
}

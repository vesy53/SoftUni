namespace CreateCustomDataStructures
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomList customList = new CustomList();

            customList.Add(2);
            customList.Add(5);
            customList.Add(6);
            customList.Add(62);
            customList.Add(69);
            Console.WriteLine(
                $"Print an element from customList: {customList[0]}");

            int element = customList.RemoveAt(2);
            Console.WriteLine(
                "Print the result if customList contains or not an element: 62");
            Console.WriteLine(customList.Contains(62));

            customList.Swap(1, 3);

            Action<object> action = c => Console.Write(c + " ");
            Console.WriteLine("Print the customList result:");
            customList.ForEach(action);
            Console.WriteLine();

            CustomStack customStack = new CustomStack();

            customStack.Push(5);
            customStack.Push(15);
            customStack.Push(25);
            customStack.Push(35);
            customStack.Push(45);

            int peekElement = customStack.Peek();
            Console.WriteLine(
                $"Peek element: {peekElement}");

            for (int i = 0; i < 2; i++)
            {
                int popElement = customStack.Pop();
                Console.WriteLine(
                    $"Pop element: {popElement}");
            }

            Console.WriteLine("Print the customStack result:");
            customStack.ForEach(action);
            Console.WriteLine();
        }
    }
}

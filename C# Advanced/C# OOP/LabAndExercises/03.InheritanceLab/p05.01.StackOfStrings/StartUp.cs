namespace p05._01.StackOfStrings
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                StackOfStrings stackString = new StackOfStrings();

                stackString.Push("c++");
                stackString.Push("csharp");
                stackString.Push("java");
                stackString.Push("php");

                while (stackString.Count != 0)
                {
                    Console.WriteLine(stackString.Peek());
                    Console.WriteLine(stackString.Pop());
                    Console.WriteLine(stackString.IsEmpty());
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}

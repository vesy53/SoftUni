namespace CustomStack
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                StackOfStrings stackString = new StackOfStrings();

                stackString.PushElement("c++");
                stackString.PushElement("csharp");
                stackString.PushElement("java");
                stackString.PushElement("php");

                while (stackString.Count != 0)
                {             
                    Console.WriteLine(stackString.PeekElement());
                    Console.WriteLine(stackString.PopElement());
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

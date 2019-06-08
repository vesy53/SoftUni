namespace BoxOfT
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> boxInt = new Box<int>();
            Box<string> boxString = new Box<string>();
            Box<char> boxChar = new Box<char>();

            boxInt.Add(1);
            boxInt.Add(2);
            boxInt.Add(3);

            boxString.Add("1");
            boxString.Add("2");
            boxString.Add("3");

            boxChar.Add('1');
            boxChar.Add('2');
            boxChar.Add('3');

            Console.WriteLine(
                $"Remove element of boxInt: {boxInt.Remove()}");
            Console.WriteLine(
                $"Remove element of boxString: {boxString.Remove()}");
            Console.WriteLine(
                $"Remove element of boxChar: {boxChar.Remove()}");

            boxInt.Add(4);
            boxInt.Add(5);

            boxString.Add("4");
            boxString.Add("5");

            boxChar.Add('4');
            boxChar.Add('5');

            Console.WriteLine(
                $"Remove element of boxInt: {boxInt.Remove()}");
            Console.WriteLine(
                $"Remove element of boxString: {boxString.Remove()}");
            Console.WriteLine(
                $"Remove element of boxChar: {boxChar.Remove()}");
        }
    }
}

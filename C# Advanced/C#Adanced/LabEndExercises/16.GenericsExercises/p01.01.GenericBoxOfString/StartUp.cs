namespace p01._01.GenericBoxOfString
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                Box<string> box = new Box<string>(input);

                Console.WriteLine(box.ToString());
            }
        }
    }
}

namespace p02._01.GenericBoxOfInteger
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(input);

                Console.WriteLine(box.ToString());
            }
        }
    }
}

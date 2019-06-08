namespace p05._03.GenericCountMethodString
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < num; i++)
            {
                string text = Console.ReadLine();

                box.AddElement(text);
            }

            string compareValue = Console.ReadLine();

            int count = box.Compare(compareValue);

            Console.WriteLine(count);
        }
    }
}

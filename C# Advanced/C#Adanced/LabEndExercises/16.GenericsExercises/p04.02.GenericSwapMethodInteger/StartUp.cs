namespace p04._02.GenericSwapMethodInteger
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Box<int> boxes = new Box<int>();

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());

                boxes.AddElement(number);
            }

            string indexesStr = Console.ReadLine();

            boxes.Swap(indexesStr);

            Console.WriteLine(boxes.ToString());
        }
    }
}

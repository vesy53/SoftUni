namespace p03._02.GenericSwapMethodString
{
    using System;

    class StarrtUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Box<string> boxes = new Box<string>();

            for (int i = 0; i < num; i++)
            {
                string text = Console.ReadLine();

                boxes.AddElement(text);
            }

            string indexes = Console.ReadLine();

            //int[] index = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
            //
            //int firstIndex = index[0];
            //int secondIndex = index[1];
            //
            //boxes.Swap(firstIndex, secondIndex);

            boxes.Swap(indexes);

            Console.WriteLine(boxes.ToString());
        }
    }
}

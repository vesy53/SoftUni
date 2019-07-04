namespace p02._01.PointInRectangle
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(input);

            for (int i = 0; i < num; i++)
            {
                Point point = new Point(Console.ReadLine());

                bool contains = rectangle.Contains(point);

                Console.WriteLine(contains);
            }
        }
    }
}
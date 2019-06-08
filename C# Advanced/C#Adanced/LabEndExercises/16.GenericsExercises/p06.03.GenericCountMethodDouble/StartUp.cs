namespace p06._03.GenericCountMethodDouble
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < num; i++)
            {
                double number = double.Parse(Console.ReadLine());

                box.AddElement(number);
            }

            double compareNum = double.Parse(Console.ReadLine());

            int count = box.Compare(compareNum);

            Console.WriteLine(count);
        }
    }
}

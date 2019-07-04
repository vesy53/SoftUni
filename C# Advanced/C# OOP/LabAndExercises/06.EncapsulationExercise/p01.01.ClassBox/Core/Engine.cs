namespace p01._01.ClassBox.Core
{
    using System;

    public class Engine
    {
        public void Run()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            Console.WriteLine(box.ToString());
        }
    }
}

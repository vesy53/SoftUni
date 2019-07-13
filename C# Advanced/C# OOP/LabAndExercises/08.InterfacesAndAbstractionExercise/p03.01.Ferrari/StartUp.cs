namespace p03._01.Ferrari
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            IFerrari ferrari = new Ferrari(driverName);

            Console.WriteLine(ferrari.ToString());
        }
    }
}

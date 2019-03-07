using System;

namespace p04Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capasity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(numPeople * 1.0/ capasity);
           
            //int courses = (int)Math.Ceiling((double)numPeople / capasity);
            Console.WriteLine(courses);
        }
    }
}

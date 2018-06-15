using System;

namespace p01PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (age < 16)
            {
                if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (age >= 16)
            {
                if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
                else 
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}

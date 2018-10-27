using System;

namespace p09Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            int altitude = int.Parse(text[0]);

            for (int i = 1; i < text.Length - 1; i += 2)
            {
                string command = text[i];
                var value = int.Parse(text[i + 1]);
                                  
                if (command == "up")
                {
                    altitude += value;
                }
                else if (command == "down")
                {
                    altitude -= value;
                }
                
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
                           
            }

            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }
    }
}

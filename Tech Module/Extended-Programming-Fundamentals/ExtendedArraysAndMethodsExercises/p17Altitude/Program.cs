using System;

namespace p17Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            int altitude = int.Parse(text[0]);

            for (int i = 1; i < text.Length; i += 2)
            {
                string command = text[i];
                int value = int.Parse(text[i + 1]);

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
                    break;
                }
            }

            if (altitude > 0)
            {
                Console.WriteLine(
                    $"got through safely. current altitude: {altitude}m");
            }
        }
    }
}

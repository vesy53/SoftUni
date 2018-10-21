namespace p01._02.SoftUniReception
{
    using System;

    class SoftUniReception2
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirthEmployee = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int studentsForHour = firstEmployee + secondEmployee + thirthEmployee;
            int countHours = 0;

            while (students > 0)
            {
                countHours++;

                if (countHours % 4 == 0)
                {
                    continue;
                }
                else
                {

                    students -= studentsForHour;
                }
            }

            Console.WriteLine($"Time needed: {countHours}h.");
        }
    }
}

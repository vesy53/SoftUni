namespace p01._01.SoftUniReception
{
    using System;

    class SoftUniReception
    {
        static void Main(string[] args)
        {
            int firstEmployeeЕfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeЕfficiency = int.Parse(Console.ReadLine());
            int thirthEmployeeЕfficiency = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int forOneHour = 
                firstEmployeeЕfficiency + secondEmployeeЕfficiency + thirthEmployeeЕfficiency;
            int countHours = 0;
            int index = 1;

            while (students > 0)
            {
                if (index % 4 == 0)
                {
                    countHours++;
                }
                else
                {
                    students -= forOneHour;
                    countHours++;
                }

                index++;
            }

            Console.WriteLine($"Time needed: {countHours}h.");
        }
    }
}

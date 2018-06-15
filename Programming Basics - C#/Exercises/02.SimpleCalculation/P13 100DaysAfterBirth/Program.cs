using System;

namespace P13100_DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthday = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime newDate = DateTime.ParseExact(birthday, format, null);
            newDate = newDate.AddDays(999);

            Console.WriteLine(newDate.ToString(format));
        }
    }
}

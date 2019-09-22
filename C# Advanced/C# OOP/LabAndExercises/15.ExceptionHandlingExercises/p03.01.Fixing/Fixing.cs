namespace p03._01.Fixing
{
    using System;
    using System.Linq;

    class Fixing
    {
        static void Main(string[] args)
        {
            try
            {
                string[] weekdays = new string[5]                
                {
                    "Sunday",
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thurstday"
                };

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(weekdays[i]);
                }

                Console.Write("Please, enter one of these days: ");

                string enterDay = Console.ReadLine();

                bool isExist = weekdays.Contains(enterDay);

                if (isExist)
                {
                    Console.WriteLine(
                        $"I wish you a pleasant {enterDay}");
                }
                else
                {
                    throw new IndexOutOfRangeException(
                        $"The day should be in the range {weekdays[0]} - {weekdays[4]}");
                }
            }
            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine(ioore.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }
}

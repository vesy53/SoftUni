using System;

namespace p06BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (number > 1000)
            {
                bonusPoints = number * 10 / 100;
            }
            else if (number > 100)
            {
                bonusPoints = number * 20 / 100;
            }
            else if (number <= 100)
            {
                bonusPoints = 5;
            }    

            if (number % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (number % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(number + bonusPoints);
        }
    }
}

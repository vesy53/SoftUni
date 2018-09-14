namespace p02._02.EmailMe
{
    using System;
    using System.Linq;

    class EmailMe
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine()
                .Split('@');

            int firstSum = email.First().Sum(x => x);
            int secondSum = email.Last().Sum(x => x);

            int sum = firstSum - secondSum;

            if (sum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}

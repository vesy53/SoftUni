namespace p02._03.EmailMe
{
    using System;
    using System.Linq;

    class EmailMe
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            var userName = email
                .Split('@')
                .First()
                .ToCharArray()
                .Select(x => (int)x)
                .Sum();

            var userAdres = email
                .Split('@')
                .Last()
                .ToCharArray()
                .Select(x => (int)x)
                .Sum();

            if (userName - userAdres < 0)
            {
                Console.WriteLine("She is not the one.");
            }
            else if (userName - userAdres >= 0)
            {
                Console.WriteLine("Call her!");
            }
        }
    }
}

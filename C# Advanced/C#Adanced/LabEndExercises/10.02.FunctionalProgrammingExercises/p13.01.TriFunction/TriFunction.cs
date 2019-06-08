namespace p13._01.TriFunction
{
    using System;
    using System.Linq;

    class TriFunction
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Action<string> print = p => Console.WriteLine(p);

            string name = names.FirstOrDefault(n =>
            {
                int sum = 0;

                foreach (char symbol in n)
                {
                    sum += symbol;
                }

                return sum >= size;
            });

            print(name);
        }
    }
}

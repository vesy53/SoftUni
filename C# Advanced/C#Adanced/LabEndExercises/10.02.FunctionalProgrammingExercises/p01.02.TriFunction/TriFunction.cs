namespace p13._02.TriFunction
{
    using System;

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

            Func<string, int, bool> isValid = (n, s) =>
            {
                var sumOfChars = 0;

                foreach (char c in n)
                {
                    sumOfChars += c;
                }

                if (sumOfChars >= s)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            string result = FindMatchingName(isValid, names, size);

            print(result);
        }

        static string FindMatchingName(
            Func<string, int, bool> isValid,
            string[] names,
            int size)
        {
            string result = string.Empty;

            foreach (string name in names)
            {
                if (isValid(name, size))
                {
                    result = name;
                    break;
                }
            }

            return result;
        }
    }
}

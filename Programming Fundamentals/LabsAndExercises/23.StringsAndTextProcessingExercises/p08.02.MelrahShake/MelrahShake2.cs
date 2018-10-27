namespace p09._02.MelrahShake
{
    using System;

    class MelrahShake2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (input.Length > 0 && pattern.Length > 0)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);

                if (firstIndex >= 0 && 
                    lastIndex >= 0 && 
                    firstIndex != lastIndex)
                {
                    input = input.Remove(lastIndex, pattern.Length);
                    input = input.Remove(firstIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);

                    break;
                }
            }

            if (pattern.Length < 1 || input.Length < 1)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(input);
            }
        }
    }
}

namespace p09._01.MelrahShake
{
    using System;

    class MelrahShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);

                if (firstIndex > -1 && 
                    lastIndex > -1 &&
                    pattern.Length > 0)
                {
                    Console.WriteLine("Shaked it.");

                    input = input.Remove(firstIndex, pattern.Length);
                    lastIndex = input.LastIndexOf(pattern);
                    input = input.Remove(lastIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);

                    break;
                }
            }
        }
    }
}

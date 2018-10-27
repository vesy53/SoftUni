namespace p07._02.Hideout
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();

            while (true)
            {
                string[] searchedArgs = Console.ReadLine()
                    .Split();

                char @char = Convert.ToChar(searchedArgs[0]);
                int length = int.Parse(searchedArgs[1]);

                Regex pattern = new Regex($@"[{@char}]{{{length},}}");
                
                Match match = pattern.Match(map);

                if (match.Success)
                {
                    var index = match.Index;
                    var count = match.Value.Length;

                    Console.WriteLine(
                        $"Hideout found at index {index} and it is with size {count}!");

                    break;
                }
            }
        }
    }
}

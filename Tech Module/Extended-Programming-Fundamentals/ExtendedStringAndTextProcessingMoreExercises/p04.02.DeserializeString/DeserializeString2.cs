namespace p04._02.DeserializeString
{
    using System;

    class DeserializeString2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split(':');

                char @char = tokens[0][0];



                input = Console.ReadLine();
            }
        }
    }
}

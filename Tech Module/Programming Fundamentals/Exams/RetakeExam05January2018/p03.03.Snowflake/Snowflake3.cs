namespace p03._03.Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    class Snowflake3
    {
        static void Main(string[] args)
        {
            Regex surfacePattern = new Regex(@"^(?<surface>[^A-Za-z0-9]+)$");
            Regex mantlePattern = new Regex(@"^(?<mantle>[\d_]+)$");
            Regex middlePattern = new Regex(@"^[^A-Za-z0-9]+[\d_]+(?<core>[A-Za-z]+)[\d_]+[^A-Za-z0-9]+$");

            int lengthCore = 0;
            bool isValidSurface = false;
            bool isValidMantle = false;
            bool isValidMiddle = false;

            for (int i = 1; i <= 5; i++)
            {
                string input = Console.ReadLine();

                if (i == 1 || i == 5)
                {
                    Match matchSurface = surfacePattern.Match(input);

                    if (matchSurface.Success)
                    {
                        isValidSurface = true;
                    }
                }

                if (i == 2 || i == 4)
                {
                    Match matchMantle = mantlePattern.Match(input);

                    if (matchMantle.Success)
                    {
                        isValidMantle = true;
                    }
                }
               
                if (i == 3)
                {
                    Match matchMiddle = middlePattern.Match(input);

                    if (matchMiddle.Success)
                    {
                        lengthCore = matchMiddle.Groups["core"].Length;
                        isValidMiddle = true;
                    }
                }
            }

            if (isValidSurface && 
                isValidMantle && 
                isValidMiddle)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(lengthCore);
            }
            else if (!isValidSurface || 
                !isValidMantle || 
                !isValidMiddle)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

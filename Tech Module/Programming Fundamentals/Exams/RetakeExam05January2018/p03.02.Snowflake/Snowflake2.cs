namespace p03._02.Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    class Snowflake2
    {
        static void Main(string[] args)
        {
            string surface1 = Console.ReadLine();
            string mantle1 = Console.ReadLine();
            string middleSMC = Console.ReadLine();
            string mantle2 = Console.ReadLine();
            string surface2 = Console.ReadLine();

            Regex surfacePattern = new Regex(@"^(?<surface>[^A-Za-z0-9]+)$");
            Regex mantlePattern = new Regex(@"^(?<mantle>[\d_]+)$");
            Regex middlePattern = new Regex(@"^[^A-Za-z0-9]+[\d_]+(?<core>[A-Za-z]+)[\d_]+[^A-Za-z0-9]+$");

            Match matchSurface = surfacePattern.Match(surface1);

            if (matchSurface.Success)
            {
                Match matchMantle = mantlePattern.Match(mantle1);

                if (matchMantle.Success)
                {
                    Match matchMiddle = middlePattern.Match(middleSMC);

                    if (matchMiddle.Success)
                    {
                        int lengthCore = matchMiddle.Groups["core"].Length;

                        Match matchMantle2 = mantlePattern.Match(mantle2);

                        if (matchMantle2.Success)
                        {
                            Match matchSurface2 = surfacePattern.Match(surface2);

                            if (matchSurface2.Success)
                            {
                                Console.WriteLine("Valid");
                                Console.WriteLine(lengthCore);
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

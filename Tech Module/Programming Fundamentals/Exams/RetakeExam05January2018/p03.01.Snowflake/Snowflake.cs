namespace p03._01.Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    class Snowflake  //80/100
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
            Regex corePattern = new Regex(@"(?<core>[A-Za-z]+)");

            Match matchSurface1 = surfacePattern.Match(surface1);

            if (matchSurface1.Success)
            {
                Match matchMantle1 = mantlePattern.Match(mantle1);

                if (matchMantle1.Success)
                {
                    MatchCollection middleSurface = surfacePattern.Matches(middleSMC);
                    MatchCollection middleMantle = mantlePattern.Matches(middleSMC);
                    Match matchCore = corePattern.Match(middleSMC);

                    bool isValidSurfase = false;
                    int countSurface = 0;

                    foreach (Match middSurface in middleSurface)
                    {
                        string value = middSurface.Groups["surface"].Value;
                        countSurface++;

                        if (countSurface == 2)
                        {
                            isValidSurfase = true;
                        }
                    }

                    bool isValidMantle = false;
                    int countMantle = 0;

                    foreach (Match middMantle in middleMantle)
                    {
                        string value = middMantle.Groups["mantle"].Value;
                        countMantle++;

                        if (countMantle == 2)
                        {
                            isValidMantle = true;
                        }
                    }

                    if (matchCore.Success)
                    {
                        int lengthCore = matchCore.Length;

                        if (isValidSurfase && isValidMantle)
                        {
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
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                                return;
                            }
                        }
                    }

                    if (!isValidSurfase || !isValidMantle)
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
        }
    }
}

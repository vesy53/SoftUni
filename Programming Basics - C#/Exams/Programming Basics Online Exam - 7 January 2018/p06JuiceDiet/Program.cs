using System;

namespace p06JuiceDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            int raspberries = int.Parse(Console.ReadLine());
            int strawberries = int.Parse(Console.ReadLine());
            int cherries = int.Parse(Console.ReadLine());
            int quantityJuice = int.Parse(Console.ReadLine());
            
            int raspbCount = 0;
            int strawbCount = 0;
            int cherriesCount = 0;
            double total = 0;

            for (int r = 0; r <= raspberries; r++)
            {
                for (int s = 0; s <= strawberries; s++)
                {
                    for (int c = 0; c <= cherries; c++)
                    {
                        double raspb = r * 4.5;
                        double strawb = s * 7.5;
                        double cherry = c * 15;
                        double sum = raspb + strawb + cherry;
        
                        if (sum  <= quantityJuice)
                        {
                            if (sum > total)
                            {
                                total = sum;                          
                                raspbCount = r;
                                strawbCount = s;
                                cherriesCount = c;                           
                            }
                        }

                        if (sum == quantityJuice - 1 || sum == quantityJuice)
                        {
                            if (cherry > strawb && cherry > raspb || strawb > raspb || raspb > strawb)
                            {
                                Console.WriteLine(
                                    $"{r} Raspberries, {s} Strawberries, {c} Cherries. Juice: {sum} ml.");
                                return;
                            }                        
                        }
                    }
                }
            }

            Console.WriteLine(
                $"{raspbCount} Raspberries, {strawbCount} Strawberries, {cherriesCount} Cherries. Juice: {total} ml.");
            
        }
    }
}

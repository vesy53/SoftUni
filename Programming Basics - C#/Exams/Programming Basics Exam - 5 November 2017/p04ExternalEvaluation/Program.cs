using System;

namespace p04ExternalEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double counter2 = 0.0;
            double counter3 = 0.0;
            double counter4 = 0.0;
            double counter5 = 0.0;
            double counter6 = 0.0;

            for (int i = 0; i < num; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points >= 0 && points < 22.5)
                {
                    counter2++;
                }
                else if (points >= 22.5 && points < 40.5)
                {
                    counter3++;
                }
                else if (points >= 40.5 && points < 58.5)
                {
                    counter4++;
                }
                else if (points >= 58.5 && points < 76.5)
                {
                    counter5++;
                }
                else if (points >= 76.5 && points <= 100)
                {
                    counter6++;
                }
            }

            Console.WriteLine($"{counter2 / num * 100:F2}% poor marks");
            Console.WriteLine($"{counter3 / num * 100:F2}% satisfactory marks");
            Console.WriteLine($"{counter4 / num * 100:F2}% good marks");
            Console.WriteLine($"{counter5 / num * 100:F2}% very good marks");
            Console.WriteLine($"{counter6 / num * 100:F2}% excellent marks");
        }
    }
}

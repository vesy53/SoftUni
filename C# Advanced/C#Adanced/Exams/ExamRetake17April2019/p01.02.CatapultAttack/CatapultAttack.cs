namespace p01._02.CatapultAttack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CatapultAttack
    {
        static void Main(string[] args)
        {
            int numWaves = int.Parse(Console.ReadLine()); 
            int[] spartanDefense = Console.ReadLine() 
                .Split(" ", 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> spartans = new Stack<int>(spartanDefense.Reverse()); 

            Stack<int> trojans = new Stack<int>();

            for (int i = 1; i <= numWaves; i++) 
            {
                int[] trojanAttack = Console.ReadLine() 
                   .Split(" ", 
                       StringSplitOptions
                       .RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

                trojans = new Stack<int>(trojanAttack);

                if (i % 3 == 0) 
                {
                    int spartan = int.Parse(Console.ReadLine());

                    Queue<int> temp = new Queue<int>();

                    while (spartans.Count() > 0)
                    {
                        temp.Enqueue(spartans.Pop());
                    }

                    temp.Enqueue(spartan);

                    spartans = new Stack<int>(temp.Reverse());
                }

                while (spartans.Count() > 0 && 
                       trojans.Count() > 0)
                {
                    int spartan = spartans.Pop();
                    int trojan = trojans.Pop();

                    if (spartan > trojan)   
                    {
                        spartan -= trojan;

                        spartans.Push(spartan); 
                    }
                    else if (spartan < trojan)
                    {
                        trojan -= spartan;

                        trojans.Push(trojan);
                    }
                }
            }

            if (spartans.Count() > 0)
            {
                Console.Write("Walls left: ");
                Console.WriteLine(String.Join(", ", spartans));
            }

            if (trojans.Count() > 0)
            {
                Console.Write("Rocks left: ");
                Console.WriteLine(String.Join(", ", trojans));
            }
        }
    }
}

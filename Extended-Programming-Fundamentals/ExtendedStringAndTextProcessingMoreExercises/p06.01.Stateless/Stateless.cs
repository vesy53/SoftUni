namespace p06._01.Stateless
{
    using System;

    class Stateless
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("collapse") == false)
            {
                string searchStr = Console.ReadLine();

                while (searchStr.Length > 0)
                {
                    if (input.Contains(searchStr))
                    {
                        input = input.Replace(searchStr, string.Empty);
                    }
                    else
                    {
                        searchStr = searchStr.Remove(0, 1);

                        if (searchStr.Length > 0)
                        {
                            searchStr = searchStr
                                .Remove((searchStr.Length - 1), 1);
                        }
                    }
                }


                if (input.Length > 0)
                {
                    Console.WriteLine(input.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }

                input = Console.ReadLine();
            }
        }
    }
}

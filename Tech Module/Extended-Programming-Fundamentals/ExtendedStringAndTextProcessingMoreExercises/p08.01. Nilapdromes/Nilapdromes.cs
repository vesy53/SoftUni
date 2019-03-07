namespace p08._01.Nilapdromes
{
    using System;

    class Nilapdromes
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line.Equals("end") == false)
            {
                string nilapdrome = ReturnNilapdrome(line);

                if (nilapdrome != string.Empty)
                {
                    Console.WriteLine(nilapdrome);
                }

                line = Console.ReadLine();
            }
        }

        static string ReturnNilapdrome(string line)
        {
            int middleIndex = line.Length / 2;
            string border = string.Empty;
            int leftIndex = 0;

            for (int i = middleIndex + 1; i < line.Length; i++)
            {
                if (line[leftIndex] == line[i])
                {
                    border += line[i];
                    leftIndex++;
                }
                else
                {
                    border = string.Empty;
                    leftIndex = 0;

                    if (line[i] ==line[leftIndex])
                    {
                        border += line[i];
                        leftIndex++;
                    }
                }
            }

            if (border != string.Empty)
            {
                int leftIndexMiddle = line.IndexOf(border);
                int rightIndexMiddle = line.LastIndexOf(border);
                string middle = line
                    .Substring(leftIndexMiddle + border.Length,
                    rightIndexMiddle - leftIndexMiddle - border.Length);

                if (middle != string.Empty)
                {
                    return middle + border + middle;
                }
            }

            return string.Empty;
        }
    }
}

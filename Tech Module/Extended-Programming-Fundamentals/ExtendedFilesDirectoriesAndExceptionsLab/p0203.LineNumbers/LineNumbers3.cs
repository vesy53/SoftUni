namespace p02._03.LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class LineNumbers3
    {
        static void Main(string[] args)
        {
            //string text = "Two households, both alike in dignity," + Environment.NewLine
            //    + "In fair Verona, where we lay our scene," + Environment.NewLine
            //    + "From ancient grudge break to new mutiny," + Environment.NewLine
            //    + "Where civil blood makes civil hands unclean." + Environment.NewLine
            //    + "From forth the fatal loins of these two foes" + Environment.NewLine
            //    + "A pair of star - cross'd lovers take their life;" + Environment.NewLine
            //    + "Whose misadventured piteous overthrows" + Environment.NewLine
            //    + "Do with their death bury their parents' strife.";
            //
            //File.WriteAllText("input.txt", text);

            string[] file = File.ReadAllLines("input.txt");

            List<string> outputText = new List<string>();

            int lineCount = 1;

            foreach (var line in file)
            {
                outputText.Add($"{lineCount}. {line}");
                lineCount++;
            }

            File.WriteAllLines("output.txt", outputText);
        }
    }
}

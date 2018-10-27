namespace p02._02.LineNumbers
{
    using System;
    using System.IO;

    class LineNumbers2
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

            string[] textLines = File
                .ReadAllLines("input.txt");

            for (int i = 1; i <= textLines.Length; i++)
            {
                textLines[i - 1] = i + ". " + textLines[i - 1];
            }

            File.WriteAllLines(
                "numberedLines.txt", textLines);
        }
    }
}

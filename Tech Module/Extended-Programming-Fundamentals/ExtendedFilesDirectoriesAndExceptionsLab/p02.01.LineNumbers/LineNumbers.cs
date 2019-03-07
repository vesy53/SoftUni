namespace p02._01.LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    class LineNumbers
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

            string[] textArr = File
                .ReadAllLines("input.txt");

            string[] numberedLines = textArr
                .Select((line, index) => $"{index + 1}. {line}")
                .ToArray();

            File.WriteAllLines(
                "numbered-lines.txt", numberedLines);
        }
    }
}

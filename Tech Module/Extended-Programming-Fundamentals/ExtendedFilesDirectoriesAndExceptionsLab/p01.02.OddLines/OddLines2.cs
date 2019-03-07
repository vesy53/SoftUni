namespace p01._02.OddLines
{
    using System;
    using System.IO;

    class OddLines2
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

            File.Delete("odd-lines.txt");

            for (int i = 1; i < textArr.Length; i += 2)
            {
                File.AppendAllText
                (
                    "odd-lines.txt",
                    textArr[i] + 
                    Environment
                        .NewLine
                );
            }
        }
    }
}

namespace p01._01.StreamProgress
{
    using System;

    using p01._01.StreamProgress.Contracts;

    public class Program
    {
        static void Main()
        {
            File file = new File("e-book", 35, 20);
            Music music = new Music("Riana", "Umbrella", 120, 30);
            Video video = new Video("King Lion", 1_500_000, 90, 410);

            PrintCalculatePercent(file);
            PrintCalculatePercent(music);
            PrintCalculatePercent(video);
        }

        static void PrintCalculatePercent(IStreamable stream)
        {
            StreamProgressInfo streamProgress = new StreamProgressInfo(stream);

            Console.WriteLine(
                streamProgress.CalculateCurrentPercent());
        }
    }

}

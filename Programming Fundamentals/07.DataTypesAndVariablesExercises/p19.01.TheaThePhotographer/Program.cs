using System;

namespace p19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double numPicture = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double photosPercentage = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            photosPercentage /= 100;
            double filterPictures = Math.Ceiling(numPicture * photosPercentage);
            double totalFiltered = numPicture * filterTime;
            double totalUpload = filterPictures * uploadTime;

            double totalTime = totalFiltered + totalUpload;

            TimeSpan project = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine(
                $"{project.Days:D1}:{project.Hours:D2}:{project.Minutes:D2}:{project.Seconds:D2}");
        }
    }
}

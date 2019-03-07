using System;

namespace p19TheaThePhotographer1
{
    class Program 
    {
        static void Main(string[] args)
        {// 20 / 100
            var numPicture = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var photosPercentage = long.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());
        
            var filterPictures = (long)Math.Ceiling(numPicture * photosPercentage / 100.0);
            var totalFiltered = numPicture * filterTime;
            var totalUpload = filterPictures * uploadTime;

            var totalTime = totalFiltered + totalUpload;

            var seconds = totalTime % 60;
            var minutes = (totalTime - seconds) / 60 % 60;
            var hours = (totalTime - seconds - minutes * 60) / 3600;
            var days = (totalTime - seconds - minutes * 60 - hours * 360) / 86400; // 3600 * 24 = 86400

            Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}

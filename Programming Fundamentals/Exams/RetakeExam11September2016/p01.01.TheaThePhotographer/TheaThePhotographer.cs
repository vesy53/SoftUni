namespace p01._01.TheaThePhotographer
{
    using System;
    using System.Globalization;

    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long amountPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long percentage = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filteredPictures 
                = (long)Math.Ceiling((amountPictures * percentage) / 100.0);
            long totalFilteredTime = amountPictures * filterTime;
            long totalUploadTime = filteredPictures * uploadTime;
            long totalSeconds = totalFilteredTime + totalUploadTime;

            long days = totalSeconds / (60 * 60 * 24);
            long remainingDays = totalSeconds % (60 * 60 * 24);
            long hours = remainingDays / (60 * 60);
            long remainingHours = remainingDays % (60 * 60);
            long minutes = remainingHours / 60;
            long seconds = remainingHours % 60;

            Console.WriteLine($"{days:0}:{hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}

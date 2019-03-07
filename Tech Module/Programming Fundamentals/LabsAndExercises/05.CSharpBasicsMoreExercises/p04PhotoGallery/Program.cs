using System;

namespace p04PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photosNum = int.Parse(Console.ReadLine());
            int data = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photosNum:D4}.jpg");
            Console.WriteLine($"Date Taken: {data:0#}/{month:0#}/{year} {hours:0#}:{minutes:0#}");

            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }            
            else if (photoSize < 1000000)
            {            
                Console.WriteLine($"Size: {photoSize / 1000}KB");
            }
            else 
            {       
                Console.WriteLine($"Size: {photoSize / 1000000}MB");
            }

            string orientation = "";

            if (width == height)
            {
                orientation = "square";
            }
            else if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }

            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}

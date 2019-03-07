using System;

namespace p10CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;

            Console.WriteLine(
                $"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                $"{minutes} minutes = {seconds} seconds = {seconds}000 milliseconds = " +
                $"{seconds}000000 microseconds = {seconds}000000000 nanoseconds");
        }
    }
}

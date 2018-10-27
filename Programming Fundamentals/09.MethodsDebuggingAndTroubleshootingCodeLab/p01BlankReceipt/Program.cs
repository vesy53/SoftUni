using System;

namespace p01BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"\u00A9 SoftUni");
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine($"Charged to{new string('_', 20)}");
            Console.WriteLine($"Received by{new string('_', 19)}");
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
    }
}

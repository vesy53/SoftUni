using System;

namespace p07ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(
                $"Before:\r\na = {num1}\r\nb = {num2}");

            int changeNum = num2;
            num2 = num1;

            Console.WriteLine(
                $"After:\r\na = {changeNum}\r\nb = {num2}");
        }
    }
}

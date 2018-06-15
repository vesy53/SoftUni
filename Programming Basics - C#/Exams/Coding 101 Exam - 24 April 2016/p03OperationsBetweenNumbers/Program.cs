using System;

namespace p03OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();

            double result = 0.0;
            string oddEven = "";

            if (mathOperator == "+")
            {
                result = num1 + num2;

                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }

                Console.WriteLine(
                     $"{num1} {mathOperator} {num2} = {result} - {oddEven}");
            }
            else if (mathOperator == "-")
            {
                result = num1 - num2;

                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }

                Console.WriteLine(
                     $"{num1} {mathOperator} {num2} = {result} - {oddEven}");

            }
            else if (mathOperator == "*")
            {
                result = num1 * num2;

                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }

                Console.WriteLine(
                    $"{num1} {mathOperator} {num2} = {result} - {oddEven}");

            }
            else if (mathOperator == "/")
            {
                result = num1 / num2;

                if (num2 == 0)
                {
                    Console.WriteLine
                        ($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine(
                        $"{num1} {mathOperator} {num2} = {result:F2}");

                }
            }
            else if (mathOperator == "%")
            {
                result = num1 % num2;

                if (num2 == 0)
                {
                    Console.WriteLine
                        ($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine(
                        $"{num1} {mathOperator} {num2} = {result}");

                }
            }
        }
    }
}

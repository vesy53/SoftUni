using System;

namespace p06Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();

                if (command == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();

                    string result = ShowSuccess(operation, message);

                    Console.WriteLine(result);
                }
                else if (command == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());

                    string result = ShowError(operation, code);

                    Console.WriteLine(result);
                }
                else
                {
                    continue;
                }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            string result = "Successfully executed "+ operation + ".\r\n";
            result += new string('=', 30) + "\r\n";
            result += "Message: " + message + ".";

            return result;
        }

        static string ShowError(string operation, int code)
        {
            string result = "Error: Failed to execute " + operation + ".\r\n";
            result += new string('=', 30) + "\r\n";
            result += "Error Code: " + code + ".\r\n";
            result += "Reason: ";

            if (code >= 0)
            {
                result += "Invalid Client Data";
            }
            else if (code < 0)
            {
                result += "Internal System Failure";
            }

            return result;
        }
    }
}

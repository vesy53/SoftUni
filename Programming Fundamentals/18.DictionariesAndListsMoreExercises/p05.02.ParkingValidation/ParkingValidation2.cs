using System;
using System.Collections.Generic;

class ParkingValidation2
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, string>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] inputCommand = Console.ReadLine()
                .Split();

            string command = inputCommand[0];
            string username = inputCommand[1];

            if (command == "register")
            {
                string licenseNum = inputCommand[2];

                if (data.ContainsKey(username))
                {
                    Console.WriteLine(
                        $"ERROR: already registered with plate number {licenseNum}");
                    continue;
                }

                if (IsLicensePlateValidation(licenseNum))
                {
                    Console.WriteLine(
                        $"ERROR: invalid license plate {licenseNum}");
                    continue;
                }

                if (data.ContainsValue(licenseNum))
                {
                    Console.WriteLine($"ERROR: license plate {licenseNum} is busy");
                    continue;
                }

                data[username] = licenseNum;

                Console.WriteLine($"{username} registered {licenseNum} successfully");
            }
            else if (command == "unregister")
            {
                if (!data.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                    continue;
                }
      
                Console.WriteLine($"user {username} unregistered successfully");

                data.Remove(username);                
            }
        }

        foreach (var itemData in data)
        {
            string username = itemData.Key;
            string licenseNum = itemData.Value;

            Console.WriteLine($"{username} => {licenseNum}");
        }
    }

    static bool IsLicensePlateValidation(string licenseNum)
    {
        if (licenseNum.Length != 8)
        {
            return true;
        }

        string firstLastTwoSymbols =
            licenseNum.Substring(0, 2) + licenseNum.Substring(6);

        foreach (var symbol in firstLastTwoSymbols)
        {
            if (symbol < 'A' || 'Z' < symbol)
            {
                return true;
            }
        }

        string midleSymbols = licenseNum.Substring(2, 4);

        foreach (var symbol in midleSymbols)
        {
            if (symbol < '0' || '9' < symbol)
            {
                return true;
            }
        }

        return false;
    }
}


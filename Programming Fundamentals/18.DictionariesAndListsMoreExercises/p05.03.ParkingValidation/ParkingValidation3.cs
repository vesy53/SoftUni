using System;
using System.Collections.Generic;
using System.Linq;

class ParkingValidation3
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, string>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            List<string> inputCommand = Console.ReadLine()
                .Split()
                .ToList();

            string command = inputCommand[0];
            string username = inputCommand[1];

            if (command == "register")
            {
                string licenseNum = inputCommand[2];

                if (data.ContainsKey(username))
                {
                    Console.WriteLine(
                        $"ERROR: already registered with plate number {username}");
                    continue;
                }

                if (data.ContainsValue(licenseNum))
                {
                    Console.WriteLine(
                        $"ERROR: license plate {licenseNum} is busy");
                    continue;
                }

                if (!data.ContainsKey(username))
                {
                    string firstTwo = licenseNum.Substring(0, 2);
                    string lastTwo = licenseNum.Substring(6, 2);
                    string middle = licenseNum.Substring(2, 4);

                    bool isdigit = middle.All(char.IsDigit);

                    if (licenseNum.Length == 8 
                        && isdigit 
                        && firstTwo == firstTwo.ToUpper() 
                        && lastTwo == lastTwo.ToUpper())
                    {
                        data[username] = licenseNum;

                        Console.WriteLine(
                            $"{username} registered {data[username]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenseNum}");
                    }
                }
            }
            else if (command == "unregister")
            {
                if (!data.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    Console.WriteLine(
                        $"user {username} unregistered successfully");
                    data.Remove(username);
                }
            }
        }

        foreach (var itemData in data)
        {
            string username = itemData.Key;
            string number = itemData.Value;

            Console.WriteLine($"{username} => {number}");
        }
    }
}


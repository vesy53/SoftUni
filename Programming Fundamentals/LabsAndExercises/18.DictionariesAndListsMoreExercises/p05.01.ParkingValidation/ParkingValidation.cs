using System;
using System.Collections.Generic;

class ParkingValidation
{
    static void Main(string[] args)
    {
        Dictionary<string, string> data = new Dictionary<string, string>();

        int num  = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] command = Console.ReadLine()
                .Split();
            string username = command[1];

            bool isInvalidNum = true;

            if (command[0] == "register")
            {
                string licenseNum = command[2];

                if (licenseNum.Length != 8)
                {
                    Console.WriteLine(
                        $"ERROR: invalid license plate {licenseNum}");
                    continue;
                }
                else
                {        
                    string firstTwoLetters = licenseNum.Substring(0, 2);
                    string middleFour = licenseNum.Substring(2, 4);
                    string lastTwoLetters = licenseNum.Substring(6, 2);

                    if (firstTwoLetters[0] >= '1' && firstTwoLetters[0] <= '9' ||
                        firstTwoLetters[1] >= '1' && firstTwoLetters[1] <= '9' ||
                        firstTwoLetters[0] >= 'a' && firstTwoLetters[0] <= 'z' ||
                        firstTwoLetters[1] >= 'a' && firstTwoLetters[1] <= 'z')
                    {
                        Console.WriteLine(
                            $"ERROR: invalid license plate {licenseNum}");
                        continue;
                    }

                    if (lastTwoLetters[0] >= '1' && lastTwoLetters[0] <= '9' ||
                        lastTwoLetters[1] >= '1' && lastTwoLetters[1] <= '9' ||
                        lastTwoLetters[0] >= 'a' && lastTwoLetters[0] <= 'z' ||
                        lastTwoLetters[0] >= 'a' && lastTwoLetters[0] <= 'z')
                    {
                        Console.WriteLine(
                            $"ERROR: invalid license plate {licenseNum}");
                        continue;
                    }

                    foreach (var middle in middleFour)
                    {
                        if (middle >= 'A' && middle <= 'Z' ||
                            middle >= 'a' && middle <= 'z')
                        {
                            Console.WriteLine(
                                $"ERROR: invalid license plate {licenseNum}");
                            isInvalidNum = false;
                            break; 
                        }
                    }
                }

                if (isInvalidNum == false)
                {
                    continue;
                }

                if (!data.ContainsValue(licenseNum))
                {
                    data.Add(username, licenseNum);                   
                }
                else
                {                  
                    Console.WriteLine(
                        $"ERROR: license plate {licenseNum} is busy");
                    continue;
                }

                if (data.ContainsValue(licenseNum) && !data.ContainsKey(username))
                {
                    Console.WriteLine(
                        $"ERROR: already registered with plate number {licenseNum}");
                    continue;
                }

                Console.WriteLine(
                        $"{username} registered {licenseNum} successfully");
            }
            else if (command[0] == "unregister")
            {
                if (!data.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    Console.WriteLine($"user {username} unregistered successfully");

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


using System;
using System.Collections.Generic;
using System.Linq;

namespace p04Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phoneNum = Console.ReadLine()
                .Split()
                .ToList();
            List<string> name = Console.ReadLine()
                .Split()
                .ToList();
            string[] command = Console.ReadLine()
                .Split()
                .ToArray();

            int index = 0;

            while (command[0] != "done")
            {
                if (command[0].Equals("call"))
                {
                    List<int> sumArr = SumPhoneNum(phoneNum);

                    for (int i = 0; i < name.Count; i++)
                    {                
                        if (command[1].Equals(phoneNum[i]))
                        {
                            Console.WriteLine($"calling {name[i]}...");
                            index = phoneNum.IndexOf(command[1]);
                            break;
                        }
                        else if (command[1].Equals(name[i]))
                        {
                            Console.WriteLine($"calling {phoneNum[i]}...");
                            index = name.IndexOf(command[1]);
                            break;
                        }
                    }                 

                    if (sumArr[index] % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                    }
                    else if (sumArr[index] % 2 == 0)
                    {
                        int minutes = sumArr[index] / 60;
                        int seconds = sumArr[index] % 60;

                        Console.WriteLine($"call ended. duration: {minutes:00}:{seconds:00}");
                    }
                }
                else if (command[0].Equals("message"))
                {
                    List<int> diffArr = SumPhoneNum(phoneNum);                 

                    for (int i = 0; i < name.Count; i++)
                    {
                        if (command[1].Equals(phoneNum[i]))
                        {
                            Console.WriteLine($"sending sms to {name[i]}...");
                            index = phoneNum.IndexOf(command[1]);
                            break;
                        }
                        else if (command[1].Equals(name[i]))
                        {
                            Console.WriteLine($"sending sms to {phoneNum[i]}...");
                            index = name.IndexOf(command[1]);
                            break;
                        }
                    }

                    if (diffArr[index] % 2 != 0)
                    {
                        Console.WriteLine("busy");
                    }
                    else if (diffArr[index] % 2 == 0)
                    {
                        Console.WriteLine($"meet me there");
                    }
                }

                command = Console.ReadLine().Split().ToArray();
            }

        }
       
        static List<int> SumPhoneNum(List<string> phoneNum)
        {
            List<int> sumArr = new List<int>();

            int sum = 0;

            foreach (var number in phoneNum)
            {
                foreach (var num in number)
                {
                    if (num == '+' || num == '(' || num == ')' || num == '-')
                    {
                        continue;
                    }

                    sum += num - 48;
                }

                sumArr.Add(sum);
                sum = 0;
            }

            return sumArr;
        }

    }
}

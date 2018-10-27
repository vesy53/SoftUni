using System;
using System.Collections.Generic;
using System.Linq;

class TakeSkipRope
{
    static void Main(string[] args)
    {
        string encryptedMessage = Console.ReadLine();

        string numStr = string.Empty;
        string take = string.Empty;
        string skip = string.Empty;

        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            if (encryptedMessage[i] >= '0' 
                && encryptedMessage[i] <= '9')
            {
                numStr += encryptedMessage[i].ToString();
                encryptedMessage = encryptedMessage.Remove(i, 1);
                i--;
            }
        }

        for (int i = 0; i < numStr.Length; i++)
        {
            if (i % 2 == 0)
            {
                take += numStr[i];
            }
            else
            {
                skip += numStr[i];
            }
        }

        //convert string to List<string>
        List<string> letters = encryptedMessage
            .Select(m => m.ToString())
            .ToList();
        List<string> takeListStr = take
            .Select(t => t.ToString())
            .ToList();
        List<string> skipListStr = skip
            .Select(s => s.ToString())
            .ToList();
       //convert List<string> to List<int>
        List<int> takeListInt = takeListStr
            .ConvertAll(int.Parse);
        List<int> skipListInt = skipListStr
            .ConvertAll(int.Parse);

        int total = 0;
        List<string> totalResult = new List<string>();

        for (int i = 0; i < takeListInt.Count; i++)
        {
            List<string> result = letters
                .Skip(total)
                .Take(takeListInt[i])
                .ToList();

            totalResult.AddRange(result);

            total += skipListInt[i] + takeListInt[i];
        }

        Console.WriteLine(string.Join("", totalResult));
    }
}


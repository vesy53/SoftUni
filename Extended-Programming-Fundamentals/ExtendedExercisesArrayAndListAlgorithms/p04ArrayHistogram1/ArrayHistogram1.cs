using System;
using System.Collections.Generic;
using System.Linq;

class ArrayHistogram1
{
    static void Main(string[] args)
    {
        string[] text = Console.ReadLine()
            .Split()
            .ToArray();

        List<string> wordsList = new List<string>();
        List<int> counterList = new List<int>();

        FillingInLists(text, wordsList, counterList);

        BubbleSort(wordsList, counterList);

        PrintResult(text, wordsList, counterList);
    }

    static void FillingInLists(string[] text, List<string> wordsList, List<int> counterList)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (!wordsList.Contains(text[i]))
            {
                wordsList.Add(text[i]);
                counterList.Add(1);
            }
            else if (wordsList.Contains(text[i]))
            {
                int indexWord = wordsList.IndexOf(text[i]);
                int currentCount = counterList[indexWord];//тук взимам с-стта
                currentCount++;

                counterList[indexWord] = currentCount;
            }
        }
    }

    static void BubbleSort(List<string> wordsList, List<int> counterList)
    {
        for (int i = 0; i < counterList.Count; i++)
        {
            for (int j = 0; j < counterList.Count - 1; j++)
            {
                if (counterList[j] < counterList[j + 1])
                {
                    int tempCount = counterList[j];
                    counterList[j] = counterList[j + 1];
                    counterList[j + 1] = tempCount;

                    string tempWord = wordsList[j];
                    wordsList[j] = wordsList[j + 1];
                    wordsList[j + 1] = tempWord;
                }

            }
        }
    }

    static void PrintResult(string[] text, List<string> wordsList, List<int> counterList)
    {
        for (int i = 0; i < wordsList.Count; i++)
        {
            double percentage = counterList[i] * 100.0 / text.Length;

            Console.WriteLine(
                wordsList[i] + " -> " + counterList[i] + $" times ({percentage:F2}%)");
        }
    }
}


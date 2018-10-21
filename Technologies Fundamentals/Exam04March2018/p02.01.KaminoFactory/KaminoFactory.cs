namespace p02._01.KaminoFactory
{
    using System;
    using System.Linq;

    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int rowCounter = 1;  //сетва ме си го на 1, защото броим от 1

            int bestLength = 0;  //защото може да имаме вход без еденици
            int bestIndex = 0;
            int[] bestSequence = new int[length];
            int indexOfSeq = 0;

            while (input.Equals("Clone them!") == false)
            {
                int[] numbers = input
                    .Split('!')
                    .Where(x => x != "")
                    .Select(int.Parse)
                    .ToArray();

                if (rowCounter == 1) //хардкодваме си, ако сме на първата интерация да съхраним нещо, ако имаме случаите с 0!0!0
                {
                    bestSequence = numbers;
                    indexOfSeq = 1;
                }

                int currLength = 0;
                int currIndex = 0;
                bool found = false;  //дали сме намерили поредни еденици, за да си го сетнем =>

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 1)
                    {
                        if (!found)  //за да си го сетнем => ето тук
                        {            //ако първото е 1 тогава си пазим този индекс от където ни почва този sequence
                            found = true;
                            currIndex = i;
                        }
                        // ако е 1(едно) има много проверки
                        currLength++;  //I-во си увеличаваме currLength-а

                        if (currLength > bestLength)  //проверяваме дали currLength > bestLength
                        {
                            indexOfSeq = rowCounter;  // презаписваме всичко което има по-добър резултат
                            bestLength = currLength;
                            bestSequence = numbers;
                            bestIndex = currIndex;
                        }
                        else if (currLength == bestLength)  //проверяваме дали са ==, защото имаме спешълкейс и трябва
                        {                                   //да проверяваме индекса на които се намираме в ммента е
                            if (currIndex == bestIndex)     //по-ляв или по-десен и взимаме по-левият и ако това е =
                            {                               //търсим сумата и като имаме някакво условие отново презаписваме всичко
                                int sumBestSequence = bestSequence.Sum();
                                int sumCurrSequence = numbers.Sum();

                                if (sumCurrSequence > sumBestSequence)
                                {
                                    indexOfSeq = rowCounter;
                                    bestLength = currLength;
                                    bestSequence = numbers;
                                    bestIndex = currIndex;
                                }
                            }
                            else
                            {
                                if (currIndex < bestIndex)
                                {
                                    indexOfSeq = rowCounter;
                                    bestLength = currLength;
                                    bestSequence = numbers;
                                    bestIndex = currIndex;
                                }
                            }
                        }
                    }
                    else  //тук влизаме в случайте когато имаме 0(нула)
                    {
                        currLength = 0;  //рестартираме всички променливи който сме направили
                        currIndex = 0;   //за currentSequence за да можем да започнем на чисто
                        found = false;
                    }
                }

                rowCounter++;  //увеличаваме си rowCounter-а

                input = Console.ReadLine();
            }

            Console.WriteLine(
                $"Best DNA sample {indexOfSeq} with sum: {bestSequence.Sum()}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}

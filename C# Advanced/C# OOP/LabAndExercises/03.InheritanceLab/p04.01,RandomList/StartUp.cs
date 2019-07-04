namespace p04._01_RandomList
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList randomList = new RandomList()
            {
                "Matrix",
                "Array",
                "List",
                "Dictionary",
                "Stack and Queue"
            };

            randomList.Add("variable");
            randomList.Add("object");
            randomList.Add("type");

            while (randomList.Count > 0)
            {
                Console.WriteLine(randomList.RandomString());
                Console.WriteLine(randomList.Count);
            }
        }
    }
}

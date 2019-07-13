namespace p09._01.CollectionHierarchy
{
    using System;

    using p09._01.CollectionHierarchy.Contracts;
    using p09._01.CollectionHierarchy.Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] input = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);
            int count = int.Parse(Console.ReadLine());

            AddInCollections(addCollection, input);
            AddInCollections(addRemoveCollection, input);
            AddInCollections(myList, input);

            RemoveInCollection(addRemoveCollection, count);
            RemoveInCollection(myList, count);
        }

        private static void RemoveInCollection(
            IRemove addRemoveCollection,
            int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(
                    $"{addRemoveCollection.RemoveElement()} ");
            }

            Console.WriteLine();
        }

        private static void AddInCollections(
            IAdd collection,
            string[] input)
        {
            foreach (string element in input)
            {
                Console.Write(
                    $"{collection.AddElement(element)} ");
            }

            Console.WriteLine();
        }
    }
}

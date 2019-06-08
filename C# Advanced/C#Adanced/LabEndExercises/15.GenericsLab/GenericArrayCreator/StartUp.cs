namespace GenericArrayCreator
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
            char[] chars = ArrayCreator.Create(15, 'a');
            double[] doubles = ArrayCreator.Create(3, 5.20);

            Console.WriteLine(string.Join(" ", strings));
            Console.WriteLine(string.Join(" ", integers));
            Console.WriteLine(string.Join(" ", chars));
            Console.WriteLine(string.Join(" ", doubles));
        }
    }
}

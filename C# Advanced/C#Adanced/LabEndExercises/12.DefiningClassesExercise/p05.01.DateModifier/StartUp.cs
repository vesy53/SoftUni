namespace p05._01.DateModifier
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDateStr = Console.ReadLine();
            string secondDateStr = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            int difference = dateModifier
                .CalculateDifferenceBetweenTwoDates(firstDateStr, secondDateStr);

            Console.WriteLine(difference);
        }
    }
}

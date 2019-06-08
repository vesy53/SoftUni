namespace GenericScale
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstStr = "aaa";
            string secondStr = "AAA";
            EqualityScale<string> equality = new EqualityScale<string>(firstStr, secondStr);
            Console.WriteLine(equality.AreEqual());

            int firstNum = 12;
            int secondNum = 12;
            EqualityScale<int> equalityScale = new EqualityScale<int>(firstNum, secondNum);
            Console.WriteLine(equalityScale.AreEqual());

            char firstChar = 's';
            char secondChar = 's';
            EqualityScale<char> scale = new EqualityScale<char>(firstChar, secondChar);
            Console.WriteLine(scale.AreEqual());

            double firstDouble = 5.90;
            double secondDouble = 0.90;
            EqualityScale<double> equalityDouble = new EqualityScale<double>(firstDouble, secondDouble);
            Console.WriteLine(equalityDouble.AreEqual());
        }
    }
}

namespace p08._01.PersonalException
{
    using System;

    class PersonalException
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        throw new NegativeNumberException();
                    }

                    Console.WriteLine(number);
                }
            }
            catch (NegativeNumberException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }

    class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("My first exception is awesome!!!")
        {

        }
    }
}

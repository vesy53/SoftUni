namespace p06._01.ValidPerson
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                Person pesho = new Person("Pesho", "Peshev", 24);

                Person negativeAge = new Person("Stoyan", "Kolev", -1);
                Person tooOldForThisProgram = new Person("Iskren", "Ivanov", 240);
                Person noLastName = new Person("Didi", null, 64);
                Person noName = new Person(string.Empty, "Goshev", 31);
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine($"Exception thrown: {ae.Message}");
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine($"Exception thrown: {aoore.Message}");
            }
        }
    }
}

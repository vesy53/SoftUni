namespace p06._02.ValidPerson
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                Person pesho = new Person("Pesho", "Peshev", 24);

                Person noLastName = new Person("Didi", null, 64);
                Person tooOldForThisProgram = new Person("Iskren", "Ivanov", 240);
                Person negativeAge = new Person("Stoyan", "Kolev", -1);
                Person noName = new Person(string.Empty, "Goshev", 31);
            }
            catch (InvalidFirstNameException ifne)
            {
                Console.WriteLine($"Exception thrown: {ifne.Message}");
            }
            catch (InvalidSecondNameException isne)
            {
                Console.WriteLine($"Exception thrown: {isne.Message}");
            }
            catch (AgeOutOfRangeException aoor)
            {
                Console.WriteLine($"Exception thrown: {aoor.Message}");
            }
        }
    }
}

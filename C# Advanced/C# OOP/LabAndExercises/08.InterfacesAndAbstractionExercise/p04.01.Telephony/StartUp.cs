namespace p04._01.Telephony
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(" ");
            string[] siteAddresses = Console.ReadLine()
               .Split(" ");

            foreach (string phoneNumber in phoneNumbers)
            {
                ICallable callable = new Smartphone();

                string call = callable.Call(phoneNumber);

                Console.WriteLine(call);
            }

            foreach (string siteNumber in siteAddresses)
            {
                IBrowsable browsable = new Smartphone();

                string browse = browsable.Browse(siteNumber);

                Console.WriteLine(browse);
            }
        }

    }
}

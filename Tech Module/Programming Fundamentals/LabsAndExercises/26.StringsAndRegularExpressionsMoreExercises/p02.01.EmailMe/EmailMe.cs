namespace p02._01.EmailMe
{
    using System;

    class EmailMe  
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            int indexOfAt = email.IndexOf('@');

            int beforeAt = 0;
            int afterAt = 0;

            for (int i = 0; i < indexOfAt; i++)
            {
                beforeAt += email[i];
            }

            for (int j = indexOfAt + 1; j < email.Length; j++)
            {
                afterAt += email[j];
            }

            int sum = beforeAt - afterAt;

            string result = sum >= 0 ? 
                "Call her!" : 
                "She is not the one.";

            Console.WriteLine(result);
        }
    }
}

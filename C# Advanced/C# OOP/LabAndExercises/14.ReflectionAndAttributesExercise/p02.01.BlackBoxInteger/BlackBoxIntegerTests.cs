namespace p02._01.BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main(string[] args)
        {
            Type classType = typeof(BlackBoxInteger);

            BlackBoxInteger box = (BlackBoxInteger)Activator
                .CreateInstance(classType, true);

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split("_");

                string command = tokens[0];
                int value = int.Parse(tokens[1]);

                MethodInfo method = classType
                   .GetMethods(BindingFlags.NonPublic |
                               BindingFlags.Instance)
                   .First(m => m.Name == command);

                method.Invoke(box, new object[] { value });

                object result = classType
                    .GetFields(BindingFlags.NonPublic |
                               BindingFlags.Instance)
                    .First(f => f.Name == "innerValue")
                    .GetValue(box);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}

namespace p02._02.BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main(string[] args)
        {
            Type classType = Type
                .GetType("p02._02.BlackBoxInteger.BlackBoxInteger");

            FieldInfo fieldInfo = classType
                .GetField("innerValue", 
                    BindingFlags.Instance |
                    BindingFlags.NonPublic);
            MethodInfo[] methodInfos = classType
                .GetMethods(BindingFlags.Instance |
                            BindingFlags.NonPublic);

            object instance = Activator
                .CreateInstance(classType, true);

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split('_');

                string command = tokens[0];
                int value = int.Parse(tokens[1]);

                MethodInfo method = methodInfos
                    .First(m => m.Name == command);

                method.Invoke(instance, new object[] { value });

                object result = fieldInfo.GetValue(instance);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        Type type = typeof(StartUp);

        MethodInfo[] methods = type
            .GetMethods(BindingFlags.Instance |
                        BindingFlags.Public |
                        BindingFlags.Static);

        foreach (MethodInfo method in methods)
        {
            bool isMatch = method
                .CustomAttributes
                .Any(n => n.AttributeType == typeof(AuthorAttribute));
                
            if (isMatch)
            {
                object[] attributes = method
                    .GetCustomAttributes(false);

                foreach (AuthorAttribute attribute in attributes)
                {
                    Console.WriteLine(
                        $"{method.Name} is written by {attribute.Name}");
                }
            }
        }
    }
}
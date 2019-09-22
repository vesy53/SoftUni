namespace MyTestingFramework.Runner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using MyTestingFramework.Attributes;

    public class TestRunner
    {
        public List<string> Run(string path)
        {
            List<string> resultsList = new List<string>();

            List<Type> testClasses = Assembly
                .LoadFrom(path)
                .GetTypes()
                .Where(x => x.GetCustomAttributes<TestClassAttribute>().Any())
                .ToList();

            foreach (Type classType in testClasses)
            {
                List<MethodInfo> classMethods = classType
                    .GetMethods()
                    .Where(x => x.GetCustomAttributes<TestMethodAttribute>().Any())
                    .ToList();

                Object classInstance = Activator.CreateInstance(classType);

                foreach (MethodInfo method in classMethods)
                {
                    try
                    {
                        method.Invoke(classInstance, new object[0]);

                        resultsList.Add($"{method.Name} passed successfully!");
                    }
                    catch (TargetInvocationException ex)
                    {
                        resultsList
                            .Add($"{method.Name} failed! {ex.InnerException.Message}");
                    }
                }
            }

            return resultsList;
        }
    }
}

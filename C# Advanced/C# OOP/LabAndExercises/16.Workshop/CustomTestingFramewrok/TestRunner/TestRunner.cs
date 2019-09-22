namespace CustomTestingFramework.TestRunner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using CustomTestingFramework.Attributes;
    using CustomTestingFramework.Exceptions;
    using CustomTestingFramework.Utilities;

    public class TestRunner : ITestRunner
    {
        private readonly List<string> resultInfo;

        public TestRunner()
        {
            this.resultInfo = new List<string>();
        }

        public IReadOnlyCollection<string> ResultInfo
            => this.resultInfo.AsReadOnly();

        public IReadOnlyCollection<string> Run(string assemblyPath)
        {
            // Find all classes which have specific custom attribute

            List<Type> testClasses = Assembly
                .LoadFrom(assemblyPath)
                .GetTypes()
                .Where(ti => ti.HasAttribute<TestClassAttribute>())
                //.Where(ti => ti.CustomAttributes.Any(ca => ca.AttributeType == typeof(TestClassAttribute)))
                .ToList();

            foreach (Type testClass in testClasses)
            {
                // Find all test methods using custom extension method HasAttribute

                List<MethodInfo> testMethods = testClass
                    .GetMethods()
                    .Where(mi => mi.HasAttribute<TestMethodAttribute>())
                    .ToList();

                object testClassInstance = Activator
                    .CreateInstance(testClass);

                foreach (MethodInfo methodInfo in testMethods)
                {
                    try
                    {
                        methodInfo.Invoke(testClassInstance, null);

                        this.resultInfo
                            .Add($"Method: {methodInfo.Name} - passed!");
                    }
                    catch (TestException te)
                    {
                        this.resultInfo
                            .Add($"Method: {methodInfo.Name} - failed!");
                    }
                    catch
                    {
                        this.resultInfo
                            .Add($"Method: {methodInfo.Name} - unexpected error occured!");
                    }
                }
            }

            return this.ResultInfo;
        }
    }
}

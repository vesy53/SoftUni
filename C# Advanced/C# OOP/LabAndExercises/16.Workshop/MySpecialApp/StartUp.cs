namespace MySpecialApp
{
    using System;

    using MyTestingFramework.Runner;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            TestRunner testRunner = new TestRunner();

            string path =
                @"C:\Users\hp\Desktop\SoftUni\SoftUni\C# Advanced\C# OOP\LabAndExercises\16.Workshop\MySpecialApp.Tests\bin\Debug\netcoreapp2.1\MySpecialApp.Tests.dll";

            var testResults = testRunner.Run(path);

            foreach (string result in testResults)
            {
                Console.WriteLine(result);
            }
        }
    }
}

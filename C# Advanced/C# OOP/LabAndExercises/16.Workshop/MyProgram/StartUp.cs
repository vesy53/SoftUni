namespace MyProgram
{
    using System;

    using CustomTestingFramework.TestRunner;

    public class StartUp
    {
        private const string path =
            @"C:\Users\hp\Desktop\SoftUni\SoftUni\C# Advanced\C# OOP\LabAndExercises\16.Workshop\CustomTestingFramework.Tests\bin\Debug\netcoreapp2.2\CustomTestingFramework.Tests.dll";

        public static void Main(string[] args)
        {
            TestRunner runner = new TestRunner();
            
            var result = runner.Run(path);

            foreach (string info in result)
            {
                Console.WriteLine(info);
            }

            // Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}

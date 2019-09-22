namespace p06._01.TrafficLights.Core
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using Contracts;
    using IO.Contracts;
    using p06._01.TrafficLights.Models;

    public class Engine : IRunable
    {
        private IRead read;
        private IWriter writer;
        private IWriteLine writeLine;

        public Engine(
            IRead read,
            IWriter writer, 
            IWriteLine writeLine)
        {
            this.read = read;
            this.writer = writer;
            this.writeLine = writeLine;
        }

        public void Run()
        {
            List<TrafficLight> trafficLights = new List<TrafficLight>();

            Type classType = typeof(TrafficLight);

            string[] inputLights = read
                .ConsoleReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            int number = int.Parse(read.ConsoleReadLine());

            for (int i = 0; i < inputLights.Length; i++)
            {
                TrafficLight currLight = (TrafficLight)Activator
                   .CreateInstance(
                        classType,
                        new object[] 
                        {
                            inputLights[i]
                        });

                trafficLights.Add(currLight);
            }

            for (int i = 0; i < number; i++)
            {
                foreach (TrafficLight light in trafficLights)
                {
                    light.ChangeLight();

                    FieldInfo fieldInfo = classType
                        .GetField(
                            "colorAtLight", 
                            BindingFlags.Instance |
                            BindingFlags.NonPublic);

                    writer.ConsoleWrite(fieldInfo.GetValue(light) + " ");
                }

                writeLine.ConsoleWriteLine();
            }
        }
    }
}

namespace p10._01.ExplicitInterfaces.Models
{
    using System;

    using p10._01.ExplicitInterfaces.Contracts;
    using p10._01.ExplicitInterfaces.Core.IO;
    using p10._01.ExplicitInterfaces.Core.IO.Contracts;

    public class Citizen : IResident, IPerson
    {
        private IWriter writer;

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;

            this.writer = new Writer();
        }

        public string Country { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        void IResident.GetName()
        {
            writer.ConsoleWriteLine($"Mr/Ms/Mrs {this.Name}");
        }

        void IPerson.GetName()
        {
            writer.ConsoleWriteLine($"{this.Name}");
        }
    }
}

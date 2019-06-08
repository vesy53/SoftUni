﻿namespace p12._01.Google
{
    using System.Text;

    public class Parent
    {
        private string name;
        private string birthday;

        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; set; }

        public string Birthday { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{this.Name} {this.Birthday}");

            return builder.ToString().TrimEnd();
        }
    }
}

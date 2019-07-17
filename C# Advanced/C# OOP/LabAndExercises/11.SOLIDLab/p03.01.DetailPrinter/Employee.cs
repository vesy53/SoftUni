﻿namespace p03._01.DetailPrinter
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}";
        }
    }
}

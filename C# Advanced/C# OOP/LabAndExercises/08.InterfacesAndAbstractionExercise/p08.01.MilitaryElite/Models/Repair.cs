namespace p08._01.MilitaryElite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using p08._01.MilitaryElite.Contracts;

    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .Append($"Part Name: {this.PartName} ")
                .Append($"Hours Worked: {this.HoursWorked}");

            return builder.ToString();
        }
    }
}

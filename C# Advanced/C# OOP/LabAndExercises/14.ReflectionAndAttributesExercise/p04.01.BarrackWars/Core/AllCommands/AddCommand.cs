﻿namespace p04._01.BarrackWars.Core.AllCommands
{
    using p04._01.BarrackWars.Contracts;

    public class AddCommand : Command
    {
        public AddCommand(
            string[] data, 
            IRepository repository,
            IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];

            IUnit unitToAdd = this.UnitFactory
                .CreateUnit(unitType);

            this.Repository.AddUnit(unitToAdd);

            string output = unitType + " added!";
            return output;
        }
    }
}

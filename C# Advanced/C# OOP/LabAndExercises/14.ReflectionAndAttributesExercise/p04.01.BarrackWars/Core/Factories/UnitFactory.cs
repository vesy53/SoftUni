namespace p04._01.BarrackWars.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3
            Assembly assembly = Assembly
                .GetExecutingAssembly();

            Type type = assembly
                .GetTypes()
                .First(t => t.Name == unitType);

            IUnit instance = (IUnit)Activator
                .CreateInstance(type, true);

            return instance;
        }
    }
}

namespace p03._01.BarrackWarsANewFactory.Core.Factories
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

            //first method
            //Type classType = Type
            //    .GetType("p03._01.BarrackWarsANewFactory.Models.Units." + unitType);
            //
            //IUnit instance = (IUnit)Activator
            //    .CreateInstance(classType);

            //second method
            Assembly assembly = Assembly
                .GetExecutingAssembly();
            
            //Type type = assembly
            //    .GetTypes()
            //    .First(t => t.Name == unitType);
            //
            //IUnit instance = (IUnit)Activator
            //    .CreateInstance(type, true);

            //third method
            Type model = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == unitType);

            if (model == null)
            {
                throw new ArgumentException("Invalid Unit Type!");
            }

            // if (model.GetInterfaces().Any(i => i == typeof(IUnit)))
            if (!typeof(IUnit).IsAssignableFrom(model))
            {
                throw new ArgumentException(
                    $"{unitType} is not a Unit Type!");
            }

            IUnit unit = (IUnit)Activator.CreateInstance(model);

            return unit;
        }
    }
}

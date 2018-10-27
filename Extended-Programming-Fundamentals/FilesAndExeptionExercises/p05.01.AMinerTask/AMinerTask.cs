namespace p05._01.AMinerTask
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    class AMinerTask
    {
        static void Main(string[] args)
        {
            var resourcesQuantities = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource.Equals("stop"))
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resourcesQuantities.ContainsKey(resource))
                {
                    resourcesQuantities.Add(resource, 0);
                }

                resourcesQuantities[resource] += quantity;
            }

            File.WriteAllText("output.txt", string.Empty);

            foreach (var resourceQuantity in resourcesQuantities)
            {
                string resource = resourceQuantity.Key;
                int quantity = resourceQuantity.Value;

                File.AppendAllText
                (
                    "output.txt",
                    $"{resource} -> {quantity}" +
                    $"{Environment.NewLine}"
                );
            }
        }
    }
}

using System.Collections.Generic;

public class ProviderFactory
{
    public Provider CreateProvider(List<string> arguments)
    {
        Provider provider = null;

        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);

        switch (type)
        {
            case "Pressure":
                provider = new PressureProvider(id, energyOutput);
                break;
            case "Solar":
                provider = new SolarProvider(id, energyOutput);
                break;
        }

        return provider;
    }
}


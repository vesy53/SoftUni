using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester CreateHarvester(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);

        Harvester harvester = null;

        switch (type)
        {
            case "Hammer":
                harvester = new HammerHarvester(id, oreOutput, energyRequirement);
                break;
            case "Sonic":
                int sonicFactor = int.Parse(arguments[4]);

                harvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                break;
            //default:
            //    break;
        }

        return harvester;
    }
}

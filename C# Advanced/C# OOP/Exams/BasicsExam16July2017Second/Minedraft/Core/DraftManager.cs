using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;

    private List<Harvester> harvesters;
    private List<Provider> providers;

    private double totalStoredEnergy;
    private double totalMinedOre;

    private Modes modes;

    public DraftManager()
    {
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();

        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();

        this.totalStoredEnergy = 0;
        this.totalMinedOre = 0;

        this.modes = Modes.Full;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester harvester = this.harvesterFactory.CreateHarvester(arguments);

            this.harvesters.Add(harvester);

            string type = harvester is SonicHarvester ? "Sonic" : "Hammer";

            string output = string.Format(
                $"Successfully registered {type} Harvester - {harvester.Id}");

            return output;
        }
        catch (ArgumentException exception)
        {
            return exception.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            Provider provider = this.providerFactory.CreateProvider(arguments);

            this.providers.Add(provider);

            string type = provider is SolarProvider ? "Solar" : "Pressure";

            string output = string.Format(
                $"Successfully registered {type} Provider - {provider.Id}");

            return output;
        }
        catch (ArgumentException exception)
        {
            return exception.Message;
        }
    }

    public string Day()
    {
        double indexEnergy = 0;
        double indexOre = 0;

        switch (this.modes)
        {
            case Modes.Energy:
                indexEnergy = (double)Modes.Energy;
                indexOre = (double)Modes.Energy;
                break;
            case Modes.Full:
                indexEnergy = (double)Modes.Full;
                indexOre = (double)Modes.Full;
                break;
            case Modes.Half:
                indexEnergy = 0.6;
                indexOre = 0.5;
                break;
        }

        double sumEnergyProvider = this.providers.Sum(p => p.EnergyOutput);

        totalStoredEnergy += sumEnergyProvider;

        double sumEnergyHarvester = this.harvesters.Sum(h => h.EnergyRequirement) * indexEnergy;

        double sumOreOutput = 0;

        if (sumEnergyHarvester <= totalStoredEnergy)
        {
            totalStoredEnergy -= sumEnergyHarvester;
            sumOreOutput = this.harvesters.Sum(h => h.OreOutput) * indexOre;
            totalMinedOre += sumOreOutput;
        }

        StringBuilder builder = new StringBuilder();

        builder.AppendLine("A day has passed.")
               .AppendLine($"Energy Provided: {sumEnergyProvider}")
               .Append($"Plumbus Ore Mined: {sumOreOutput}");

        return builder.ToString();
    }

    public string Mode(List<string> arguments)
    {
        string modeStr = arguments[0];

        string output = string.Empty;

        if (Enum.TryParse(modeStr, out Modes currentMode))
        {
            this.modes = currentMode;

            output = string.Format(
                $"Successfully changed working mode to {currentMode} Mode");
        }

        return output;
    }

    public string Check(List<string> arguments)
    {
        StringBuilder builder = new StringBuilder();

        string id = arguments[0];

        if (this.harvesters.Any(h => h.Id == id))
        {
            Harvester harvester = this.harvesters.First(h => h.Id == id);

            string type = harvester is SonicHarvester ? "Sonic" : "Hammer";

            builder.AppendLine($"{type} Harvester - {harvester.Id}")
                   .AppendLine($"Ore Output: {harvester.OreOutput}")
                   .Append($"Energy Requirement: {harvester.EnergyRequirement}");
        }
        else if (this.providers.Any(p => p.Id == id))
        {
            Provider provider = this.providers.First(p => p.Id == id);

            string type = provider is SolarProvider ? "Solar" : "Hammer";

            builder.AppendLine($"{type} Provider - {provider.Id}")
                   .Append($"Energy Output: {provider.EnergyOutput}");
        }
        else
        {
            builder.Append($"No element found with id - {id}");
        }

        return builder.ToString();
    }

    public string ShutDown()
    {
        StringBuilder builder = new StringBuilder();

        builder.AppendLine("System Shutdown")
               .AppendLine($"Total Energy Stored: {totalStoredEnergy}")
               .Append($"Total Mined Plumbus Ore: {totalMinedOre}");

        return builder.ToString();
    }
}
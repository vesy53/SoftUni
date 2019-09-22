using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;

    private double totalStoredEnergy;
    private double totalMinedOre;

    private Modes modes;

    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;

    public object Identity { get; private set; }

    public DraftManager()
    {
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();

        this.totalStoredEnergy = 0;
        this.totalMinedOre = 0;

        this.modes = Modes.Full;

        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester harvester = this.harvesterFactory.CreateHarvester(arguments);

            this.harvesters.Add(harvester.Id, harvester);

            string type = arguments[0];
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

            this.providers.Add(provider.Id, provider);

            string type = arguments[0];
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
        double modeEnergy = 0.0;
        double modeOreOutput = 0.0;

        switch (this.modes)
        {
            case Modes.Full:
                modeEnergy = 1;
                modeOreOutput = 1;
                break;
            case Modes.Half:
                modeEnergy = 0.6;
                modeOreOutput = 0.5;
                break;
            case Modes.Energy:
                break;
        }

        double sumEnergyRequrement = this.harvesters.Values.Sum(h => h.EnergyRequirement) * modeEnergy;

        double sumProvidedEnergy = this.providers.Values.Sum(p => p.EnergyOutput);
        totalStoredEnergy += sumProvidedEnergy;

        double sumOreOutput = 0;

        if (sumEnergyRequrement <= totalStoredEnergy)
        {
            totalStoredEnergy -= sumEnergyRequrement;
            sumOreOutput = this.harvesters.Values.Sum(h => h.OreOutput) * modeOreOutput;
            totalMinedOre += sumOreOutput;
        }

        StringBuilder builder = new StringBuilder();

        builder.AppendLine("A day has passed.")
               .AppendLine($"Energy Provided: { sumProvidedEnergy}")
               .Append($"Plumbus Ore Mined: { sumOreOutput}");

        return builder.ToString();
    }

    public string Mode(List<string> arguments)
    {
        string mode = arguments[0];

        string output = string.Empty;

        if (Enum.TryParse(mode, out Modes currMode))
        {
            this.modes = currMode;

            output = string.Format(
                $"Successfully changed working mode to {mode} Mode");
        }

        return output;
    }

    public string Check(List<string> arguments)
    {
        StringBuilder builder = new StringBuilder();

        string id = arguments[0];

        Indentity indentity;
        //TODO
        if (this.harvesters.ContainsKey(id))
        {
            indentity = harvesters[id];

            string type = indentity is SonicHarvester ? "Sonic" : "Hammer";

            Harvester harvester = (Harvester)indentity;

            builder.AppendLine($"{type} Harvester - {harvester.Id}")
                   .AppendLine($"Ore Output: {harvester.OreOutput}")
                   .Append($"Energy Requirement: {harvester.EnergyRequirement}");
        }
        else if (this.providers.ContainsKey(id))
        {
            indentity = providers[id];

            string type = indentity is PressureProvider ? "Pressure" : "Solar";

            Provider provider = (Provider)indentity;

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


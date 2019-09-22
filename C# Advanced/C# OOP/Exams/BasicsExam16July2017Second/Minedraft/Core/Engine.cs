using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private DraftManager draftManager;

    public Engine()
    {
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        string input = Console.ReadLine();
 
        while (true)
        {
            bool isShutdown = false;

            try
            {
                string[] tokens = input
                    .Split();

                string command = tokens[0];

                List<string> arguments = tokens
                    .Skip(1)
                    .ToList();

                string output = string.Empty;

                switch (command)
                {
                    case "RegisterHarvester":
                        output = this.draftManager.RegisterHarvester(arguments);
                        break;
                    case "RegisterProvider":
                        output = this.draftManager.RegisterProvider(arguments);
                        break;
                    case "Day":
                        output = this.draftManager.Day();
                        break;
                    case "Mode":
                        output = this.draftManager.Mode(arguments);
                        break;
                    case "Check":
                        output = this.draftManager.Check(arguments);
                        break;
                    case "Shutdown":
                        isShutdown = true;
                        output = this.draftManager.ShutDown();
                        break;
                }

                Console.WriteLine(output);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            if (isShutdown)
            {
                break;
            }

            input = Console.ReadLine();
        }
    }
}

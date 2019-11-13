﻿namespace p01._01.Logger
{
    using System;

    using p01._01.Logger.Appenders;
    using p01._01.Logger.Appenders.Contracts;
    using p01._01.Logger.Layouts;
    using p01._01.Logger.Layouts.Contracts;
    using p01._01.Logger.Loggers.Contracts;
    using p01._01.Logger.Loggers;
    using p01._01.Logger.Loggers.Enums;
    using p01._01.Logger.Core.Contracts;
    using p01._01.Logger.Core;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //first test
            //ILayout simpleLayout = new SimpleLayout();
            //IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            //ILogger logger = new Logger(consoleAppender);
            //
            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

            //second test
            //ILayout simpleLayout = new SimpleLayout();
            //IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            //
            //ILogFile file = new LogFile();
            //IAppender fileAppender = new FileAppender(simpleLayout, file);
            //
            //ILogger logger = new Logger(consoleAppender, fileAppender);
            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

            //third test
            //var xmlLayout = new XmlLayout();
            //var consoleAppender = new ConsoleAppender(xmlLayout);
            //var logger = new Logger(consoleAppender);
            //
            //logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
            //logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");

            //fourth test
            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);
            //consoleAppender.ReportLevel = ReportLevel.Error;
            //
            //var logger = new Logger(consoleAppender);
            //
            //logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
            //logger.Warning("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
            //logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
            //logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
            //logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");

            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IEngine engine = new Engine(commandInterpreter);
            
            engine.Run();
        }
    }
}
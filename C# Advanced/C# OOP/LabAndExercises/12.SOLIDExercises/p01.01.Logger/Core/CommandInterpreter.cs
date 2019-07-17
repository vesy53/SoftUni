namespace p01._01.Logger.Core
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using p01._01.Logger.Appenders.Contracts;
    using p01._01.Logger.Appenders.Factory;
    using p01._01.Logger.Appenders.Factory.Contracts;
    using p01._01.Logger.Layouts.Contracts;
    using p01._01.Logger.Layouts.Factory;
    using p01._01.Logger.Layouts.Factory.Contracts;
    using p01._01.Logger.Loggers.Enums;

    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];

            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length == 3)
            {
                reportLevel = Enum
                    .Parse<ReportLevel>(args[2]);
            }

            ILayout layout = this.layoutFactory
                .CreateLayout(layoutType);
            IAppender appender = this.appenderFactory
                .CreateAppender(appenderType, layout);

            appender.ReportLevel = reportLevel;

            this.appenders.Add(appender);
        }

        public void AddMessage(string[] args)
        {
            ReportLevel reportLevel = Enum
                .Parse<ReportLevel>(args[0]);

            string dateTime = args[1];
            string message = args[2];

            foreach (IAppender appender in appenders)
            {
                appender
                    .Append(dateTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");

            foreach (IAppender appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}

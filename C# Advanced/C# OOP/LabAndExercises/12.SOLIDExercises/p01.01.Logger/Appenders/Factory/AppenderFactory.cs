namespace p01._01.Logger.Appenders.Factory
{
    using System;

    using Contracts;
    using p01._01.Logger.Appenders.Contracts;
    using p01._01.Logger.Layouts.Contracts;
    using p01._01.Logger.Loggers;

    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}

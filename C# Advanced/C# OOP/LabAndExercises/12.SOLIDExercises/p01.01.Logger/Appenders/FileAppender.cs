namespace p01._01.Logger.Appenders
{
    using System;
    using System.IO;
    using System.Text;

    using p01._01.Logger.Layouts.Contracts;
    using p01._01.Logger.Loggers.Contracts;
    using p01._01.Logger.Loggers.Enums;

    public class FileAppender : Appender
    {
        private const string path = "log.txt";

        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(
            string dateTime, 
            ReportLevel reportLevel, 
            string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessageCount++;

                string content = string.Format(
                    this.Layout.Format, 
                    dateTime, 
                    reportLevel,
                    message + Environment.NewLine);

                this.logFile.Writer(content);

                File.AppendAllText(path, content);
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .Append($"Appender type: {this.GetType().Name}, ")
                .Append($"Layout type: {this.Layout.GetType().Name}, ")
                .Append($"Report level: {this.ReportLevel.ToString().ToUpper()}, ")
                .Append($"Messages appended: {this.MessageCount}, ")
                .Append($"File size: {this.logFile.Size}");

            return builder.ToString();
        }
    }
}

namespace p01._01.Logger.Appenders
{
    using System;
    using System.Text;

    using p01._01.Logger.Layouts.Contracts;
    using p01._01.Logger.Loggers.Enums;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(
            string dateTime, 
            ReportLevel reportLevel, 
            string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessageCount++;

                Console.WriteLine(
                    string.Format(
                        this.Layout.Format, 
                        dateTime, 
                        reportLevel, 
                        message));
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .Append($"Appender type: {this.GetType().Name}, ")
                .Append($"Layout type: {this.Layout.GetType().Name}, ")
                .Append($"Report level: {this.ReportLevel.ToString().ToUpper()}, ")
                .Append($"Messages appended: {this.MessageCount}");

            return builder.ToString();
        }
    }
}

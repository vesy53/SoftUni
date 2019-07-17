namespace p01._01.Logger.Appenders.Contracts
{
    using p01._01.Logger.Loggers.Enums;

    public interface IAppender
    {
        void Append(string dateTime, ReportLevel reportLevel, string message);

        ReportLevel ReportLevel { get; set; }

        int MessageCount { get; }
    }
}

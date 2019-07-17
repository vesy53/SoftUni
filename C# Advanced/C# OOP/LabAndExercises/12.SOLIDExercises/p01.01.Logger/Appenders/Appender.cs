namespace p01._01.Logger.Appenders
{
    using Contracts;
    using p01._01.Logger.Layouts.Contracts;
    using p01._01.Logger.Loggers.Enums;

    public abstract class Appender : IAppender
    {
        private readonly ILayout layout;

        protected Appender(ILayout layout)
        {
            this.layout = layout;
        }

        protected ILayout Layout => this.layout;

        public ReportLevel ReportLevel { get; set; }

        public int MessageCount { get; protected set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}

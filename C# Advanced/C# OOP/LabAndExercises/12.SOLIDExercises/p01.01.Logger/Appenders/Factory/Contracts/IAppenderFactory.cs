namespace p01._01.Logger.Appenders.Factory.Contracts
{
    using p01._01.Logger.Appenders.Contracts;
    using p01._01.Logger.Layouts.Contracts;

    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}

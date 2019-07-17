namespace p01._01.Logger.Layouts.Factory.Contracts
{
    using p01._01.Logger.Layouts.Contracts;

    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}

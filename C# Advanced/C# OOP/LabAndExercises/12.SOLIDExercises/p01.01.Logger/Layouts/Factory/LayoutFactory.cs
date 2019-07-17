namespace p01._01.Logger.Layouts.Factory
{
    using System;

    using p01._01.Logger.Layouts.Contracts;
    using p01._01.Logger.Layouts.Factory.Contracts;

    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            string typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException(
                        "Invalid layout type!");
            }
        }
    }
}

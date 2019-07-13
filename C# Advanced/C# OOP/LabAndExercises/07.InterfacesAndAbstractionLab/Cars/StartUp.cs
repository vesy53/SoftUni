namespace Cars
{
    using Core;
    using Core.IO;
    using Core.IO.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IWriter writer = new Writer();

            Engine engine = new Engine(writer);
            engine.Run();
        }
    }
}

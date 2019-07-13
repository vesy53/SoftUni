namespace Cars.Core
{
    using IO.Contracts;
    using Cars.Models;
    using Cars.Models.Contracts;

    public class Engine
    {
        private IWriter writer;

        public Engine(IWriter writer)
        {
            this.writer = writer;
        }

        public void Run()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            writer.ConsoleWriteLine(seat.ToString());
            writer.ConsoleWriteLine(tesla.ToString());
        }
    }
}

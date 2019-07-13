namespace p03._01.Ferrari
{
    using System.Text;

    public class Ferrari : IFerrari
    {
        private const string DefaultModel = "488-Spider";

        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Model => DefaultModel;

        public string Driver { get; private set; }

        public string Brakes()
        {
            string result = "Brakes!";

            return result;
        }

        public string PushTheGasPedal()
        {
            string result = "Gas!";

            return result;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"{this.Model}/")
                   .Append($"{this.Brakes()}/")
                   .Append($"{this.PushTheGasPedal()}/")
                   .Append($"{this.Driver}");
                   
            return builder.ToString();
        }
    }
}
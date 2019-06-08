namespace p12._01.Google
{
    using System.Text;

    public class Car
    {
        private string model;
        private int speed;

        //public Car()
        //{

        //}

        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model { get; set; }

        public int Speed { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{this.Model} {this.Speed}");

            return builder.ToString().TrimEnd();
        }
    }
}

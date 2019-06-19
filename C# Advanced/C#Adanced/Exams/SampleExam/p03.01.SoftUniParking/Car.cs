namespace p03._01.SoftUniParking
{
    using System.Text;

    public class Car
    {
        public Car(
            string make,
            string model,
            int horsePower,
            string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public string Make { get; private set; }

        public string Model { get; private set; }

        public int HorsePower { get; private set; }

        public string RegistrationNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"Make: {this.Make}")
                .AppendLine($"Model: {this.Model}")
                .AppendLine($"HorsePower: {this.HorsePower}")
                .AppendLine($"RegistrationNumber: {this.RegistrationNumber}");

            return builder.ToString().TrimEnd();
        }
    }

}

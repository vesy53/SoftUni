namespace p02._01.ClassBoxDataValidation
{
    using p02._01.ClassBoxDataValidation.Core;
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(
            double length, 
            double width, 
            double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                Validation.ValidateElement(value, "Length");

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                Validation.ValidateElement(value, "Width");

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                Validation.ValidateElement(value, "Height");

                this.height = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            double area = 2 * (this.Length * this.Width +
                               this.Length * this.Height +
                               this.Width * this.Height);

            return area;
        }

        public double CalculateLeteralSurfaceArea()
        {
            double area = 2 * (this.Length * this.Height +
                               this.Width * this.Height);

            return area;
        }

        public double CalculateVolume()
        {
            double volume = this.Length * this.Width * this.Height;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"Surface Area – {this.CalculateSurfaceArea():F2}")
                .AppendLine($"Lateral Surface Area – {this.CalculateLeteralSurfaceArea():F2}")
                .AppendLine($"Volume  – {this.CalculateVolume():F2}");

            return builder.ToString().TrimEnd();
        }
    }
}

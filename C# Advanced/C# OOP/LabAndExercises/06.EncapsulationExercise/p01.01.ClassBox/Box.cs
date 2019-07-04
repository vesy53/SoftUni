namespace p01._01.ClassBox
{
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
            get => this.length;
            private set => this.length = value;
        }

        public double Width
        {
            get => this.width;
            private set => this.width = value;
        }

        public double Height
        {
            get => this.height;
            private set => this.height = value;
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
                .AppendLine($"Surface Area - {this.CalculateSurfaceArea():F2}")
                .AppendLine($"Lateral Surface Area - {this.CalculateLeteralSurfaceArea():F2}")
                .AppendLine($"Volume - {this.CalculateVolume():F2}");

            return builder.ToString().TrimEnd();
        }
    }
}

namespace p02._01.ClassBoxDataValidation
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
            get
            {
                return this.length;
            }

            private set
            {
                Validation.ValidateValue(value, "Length");

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
                Validation.ValidateValue(value, "Width");

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
                Validation.ValidateValue(value, "Height");

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double resut = 2 * this.Length * this.Width +
                           2 * this.Length * this.Height +
                           2 * this.Height * this.Width;

            return resut;
        }

        public double LateralSurfaceArea()
        {
            double result = 2 * this.Length * this.Height +
                            2 * this.Width * this.Height;

            return result;
        }

        public double Volume()
        {
            double result = this.Height * this.Length * this.Width;

            return result;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"Surface Area - {this.SurfaceArea():F2}")
                .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():F2}")
                .AppendLine($"Volume - {this.Volume():F2}");

            return builder.ToString();
        }
    }
}

namespace p06._01.TrafficLights.Models
{
    using System;

    using Contracts;
    using p06._01.TrafficLights.Enums;

    public class TrafficLight : IChangeable
    {
        private ColorAtLight colorAtLight;

        public TrafficLight(string colorLight)
        {
            ConvertStringToEnum(colorLight);
        }

        public void ChangeLight()
        {
            switch (this.colorAtLight)
            {
                case ColorAtLight.Red:
                    this.colorAtLight = ColorAtLight.Green;
                    break;
                case ColorAtLight.Green:
                    this.colorAtLight = ColorAtLight.Yellow;
                    break;
                case ColorAtLight.Yellow:
                    this.colorAtLight = ColorAtLight.Red;
                    break;
            }
        }

        private void ConvertStringToEnum(string colorLight)
        {
            this.colorAtLight = (ColorAtLight)Enum
                .Parse(typeof(ColorAtLight), colorLight);
        }
    }
}

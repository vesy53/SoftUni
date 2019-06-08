namespace p08._01.RawData
{
    public class Cargo
    {
        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type { get; set; }

        public int Weight { get; set; }
    }
}

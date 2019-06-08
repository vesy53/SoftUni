namespace p01._01.GenericBoxOfString
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            string result = string.Format(
                $"{this.Value.GetType()}: {this.Value}");

            return result;
        }
    }
}

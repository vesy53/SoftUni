namespace p02._01.GenericBoxOfInteger
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            string result = string.Format(
                $"{this.value.GetType()}: {this.value}");

            return result;
        }
    }
}

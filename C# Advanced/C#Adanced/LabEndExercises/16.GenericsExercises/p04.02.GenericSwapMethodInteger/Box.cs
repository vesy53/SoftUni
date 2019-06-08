namespace p04._02.GenericSwapMethodInteger
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Box<T>
    {
        private T value;
        private IList<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public Box(T value)
            : this()
        {
            this.value = value;
        }

        public IList<T> Data => this.data;

        public void AddElement(T element)
        {
            this.data.Add(element);
        }

        public void Swap(string indexesStr)
        {
            int[] indexes = indexesStr
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            T temp = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = temp;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var item in this.data)
            {
                builder.AppendLine(
                    $"{item.GetType().FullName}: {item}");
            }

            return builder.ToString().Trim();
        }
    }
}

namespace p06._02.GenericCountMethodDouble
{
    using System.Collections.Generic;

    public class Box<T>
    {
        public Box()
        {
            this.Lists = new List<T>();
        }

        public List<T> Lists { get; set; }

        public void Add(T element)
        {
            this.Lists.Add(element);
        }

        public int CompareElement(double comparisonByValue)
        {
            int count = 0;

            foreach (var element in this.Lists)
            {
                if (comparisonByValue.CompareTo(element) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

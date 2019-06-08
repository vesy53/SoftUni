namespace p06._01.GenericCountMethodDouble
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
    }
}

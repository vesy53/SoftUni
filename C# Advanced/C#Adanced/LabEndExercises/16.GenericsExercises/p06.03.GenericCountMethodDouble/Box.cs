namespace p06._03.GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;

    public class Box<T>
        where T : IComparable<T>
    {
        private IList<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void AddElement(T element)
        {
            this.data.Add(element);
        }

        public int Compare(T element)
        {
            int count = 0;

            foreach (var item in this.data)
            {
                int compareIndex = element.CompareTo(item);

                if (compareIndex < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

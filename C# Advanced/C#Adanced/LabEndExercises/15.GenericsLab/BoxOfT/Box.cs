namespace BoxOfT
{
    using System.Collections.Generic;

    public class Box<T> : IBox<T>
    {
        private List<T> list;

        public int Count => this.list.Count;

        public Box()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove()
        {
            T lastElement = this.list[this.list.Count - 1];
            this.list.RemoveAt(this.list.Count - 1);

            return lastElement;
        }
    }
}

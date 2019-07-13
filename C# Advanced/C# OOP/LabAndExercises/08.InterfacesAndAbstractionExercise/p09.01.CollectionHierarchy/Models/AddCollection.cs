namespace p09._01.CollectionHierarchy.Models
{
    using System.Collections.Generic;

    using p09._01.CollectionHierarchy.Contracts;

    public class AddCollection : IAdd
    {
        protected List<string> collection;

        public AddCollection()
        {
            this.collection = new List<string>();
        }

        public virtual int AddElement(string element)
        {
            this.collection.Add(element);

            return this.collection.Count - 1;
        }
    }
}

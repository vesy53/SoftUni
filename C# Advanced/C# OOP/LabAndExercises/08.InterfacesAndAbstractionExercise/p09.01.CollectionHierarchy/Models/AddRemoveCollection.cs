namespace p09._01.CollectionHierarchy.Models
{
    using p09._01.CollectionHierarchy.Contracts;

    public class AddRemoveCollection : AddCollection, IRemove
    {
        public override int AddElement(string element)
        {
            this.collection.Insert(0, element);

            return 0;
        }

        public virtual string RemoveElement()
        {
            string element = this.collection[this.collection.Count - 1];

            this.collection.RemoveAt(this.collection.Count - 1);

            return element;
        }
    }
}

namespace p09._01.CollectionHierarchy.Models
{
    using p09._01.CollectionHierarchy.Contracts;

    public class MyList : AddRemoveCollection, IUsed
    {
        public int UsedElements => this.collection.Count;

        public override string RemoveElement()
        {
            string element = this.collection[0];
            this.collection.RemoveAt(0);

            return element;
        }
    }
}

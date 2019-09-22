public abstract class Identifier
{
    protected Identifier(string id)
    {
        this.Id = id;
    }

    public string Id { get; private set; }

    //public abstract string Type { get; }
}

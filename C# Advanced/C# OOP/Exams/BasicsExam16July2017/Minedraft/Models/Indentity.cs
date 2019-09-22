public abstract class Indentity
{
    protected Indentity(string id)
    {
        this.Id = id;
    }

    public string Id { get; private set; }
}


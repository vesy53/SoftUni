namespace p06._01.BirthdayCelebrations
{
    public class Robot : INameable, IIdentifiable
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name { get; private set; }

        public string Id { get; private set; }
    }
}

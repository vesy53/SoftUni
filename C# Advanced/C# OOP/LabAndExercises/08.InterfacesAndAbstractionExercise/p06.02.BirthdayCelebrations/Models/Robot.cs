namespace p06._02.BirthdayCelebrations.Models
{
    using p06._02.BirthdayCelebrations.Contracts;

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

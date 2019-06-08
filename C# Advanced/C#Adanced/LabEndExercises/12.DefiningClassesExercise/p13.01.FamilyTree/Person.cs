namespace p13._01.FamilyTree
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private string birthday;
        private List<Person> parents;
        private List<Person> children;

        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;

            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public string Birthday
        {
            get => this.birthday;
            set => this.birthday = value;
        }

        public List<Person> Parents
        {
            get => this.parents;
            set => this.parents = value;
        }

        public List<Person> Children
        {
            get => this.children;
            set => this.children = value;
        }

        public void AddChild(Person parent)
        {
            children.Add(parent);
        }

        public void AddParent(Person child)
        {
            parents.Add(child);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"{this.Name} {this.Birthday}");

            return builder.ToString().TrimEnd();
        }
    }
}

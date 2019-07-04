namespace p07._01.FamilyTree
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private string birthday;
        private List<Person> parents;
        private List<Person> children;

        public Person()
        {
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public Person(string name)
            : this()
        {
            this.Name = name;
        }

        public Person(string name, string birthday)
            : this(name)
        {
            this.birthday = birthday;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Person> Children
        {
            get { return children; }
            set { children = value; }
        }

        public void AddChild(Person child)
        {
            this.Children.Add(child);
        }

        public void AddParent(Person parent)
        {
            this.Parents.Add(parent);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{Name} {Birthday}");
            builder.AppendLine("Parents:");

            foreach (Person parent in Parents)
            {
                builder.AppendLine(
                    $"{parent.Name} {parent.Birthday}");
            }

            builder.AppendLine("Children:");

            foreach (Person child in Children)
            {
                builder.AppendLine(
                    $"{child.Name} {child.Birthday}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}

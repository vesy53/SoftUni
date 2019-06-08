namespace DefiningClasses
{
    public class Person
    {
        private const string DefaultName = "No name";
        private const int DefaultAge = 1;

        private string name;
        private int age;

        public Person()
        {
            this.Name = DefaultName;
            this.Age = DefaultAge;
        }

        public Person(int age)
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }
    }
}

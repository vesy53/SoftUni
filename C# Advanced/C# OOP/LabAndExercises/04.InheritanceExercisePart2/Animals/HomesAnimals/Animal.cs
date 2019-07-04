namespace Animals.HomesAnimals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validation.ValidateName(value);

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                Validation.ValidateAge(value);

                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            private set
            {
                Validation.ValidateGender(value);

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            string result = string.Empty;

            return result;
        }

        public override string ToString()
        {
            string result = string.Format(
                $"{this.Name} {this.Age} {this.Gender}");

            return result;
        }
    }
}

namespace p02._01.SpaceStationRecruitment
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.data = new List<Astronaut>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count => this.data.Count();

        public void Add(Astronaut astronaut)
        {
            //if (this.data.Count <= this.Capacity - 1)
            //{
            //    this.data.Add(astronaut);
            //}

            if (this.Capacity > 0)
            {
                this.data.Add(astronaut);
                this.Capacity--;
            }
        }

        public bool Remove(string name)
        {
            Astronaut astronaut = this.data
                .Where(d => d.Name == name)
                .FirstOrDefault();

            if (astronaut != null)
            {
                this.data.Remove(astronaut);

                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldestAstronaut = this.data
                .OrderByDescending(d => d.Age)
                .FirstOrDefault();

            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.data
                .Where(d => d.Name == name)
                .FirstOrDefault();

            return astronaut;
        }

        public string Report()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (Astronaut astronaut in this.data)
            {
                builder.AppendLine($"{astronaut}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}

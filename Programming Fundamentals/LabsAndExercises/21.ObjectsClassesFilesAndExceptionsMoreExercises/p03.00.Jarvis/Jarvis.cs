namespace p03._00.Jarvis
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    class Jarvis
    {
        static void Main(string[] args)
        {
            long maxEnergy = long.Parse(Console.ReadLine());

            Robot robot = new Robot();
            robot.Energy = maxEnergy;

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split();

                if (tokens[0] == "Assemble!")
                {
                    break;
                }

                switch (tokens[0])
                {
                    case "Head":
                        Head newHead = new Head
                        (
                            int.Parse(tokens[1]),
                            int.Parse(tokens[2]),
                            tokens[3]
                        );
                        robot.AddHead(newHead);
                        break;
                    case "Torso":
                        Torso newTorso = new Torso
                        (
                            int.Parse(tokens[1]),
                            double.Parse(tokens[2]),
                            tokens[3]
                        );
                        robot.AddTorso(newTorso);
                        break;
                    case "Arm":
                        Arm newArm = new Arm
                        (
                            int.Parse(tokens[1]),
                            int.Parse(tokens[2]),
                            int.Parse(tokens[3])
                        );
                        robot.AddArm(newArm);
                        break;
                    case "Leg":
                        Leg newLeg = new Leg
                        (
                            int.Parse(tokens[1]),
                            int.Parse(tokens[2]),
                            int.Parse(tokens[3])
                        );
                        robot.AddLeg(newLeg);
                        break;
                }
            }

            Console.WriteLine(robot.ToString());
        }
    }

    class Robot
    {
        public long Energy { get; set; }

        public Head Head { get; set; }

        public Torso Torso { get; set; }

        public List<Arm> Arms = new List<Arm>();

        public List<Leg> Legs = new List<Leg>();

        public void AddHead(Head headInput)
        {
            if (Head == null)
            {
                Head = headInput;
            }

            if (headInput.Energy < Head.Energy)
            {
                Head = headInput;
            }
        }

        public void AddTorso(Torso torsoInput)
        {
            if (Torso == null)
            {
                Torso = torsoInput;
            }

            if (torsoInput.Energy < Torso.Energy)
            {
                Torso = torsoInput;
            }
        }

        public void AddArm(Arm armInput)
        {
            //проверяваме дали ни е създадена истанция от листовете
            if (Arms == null)
            {
                Arms = new List<Arm>();
            }

            if (Arms.Count < 2)
            {
                Arms.Add(armInput);
            }
            else
            {
                for (int i = 0; i < this.Arms.Count; i++)
                {
                    if (Arms[i].Energy > armInput.Energy)
                    {
                        Arms.RemoveAt(i);
                        Arms.Add(armInput);
                    }
                }
            }
        }

        public void AddLeg(Leg legInput)
        {
            if (Legs == null)
            {
                Legs = new List<Leg>();
            }

            if (Legs.Count < 2)
            {
                Legs.Add(legInput);
            }
            else
            {
                for (int i = 0; i < this.Arms.Count; i++)
                {
                    if (Legs[i].Energy > legInput.Energy)
                    {
                        Legs.RemoveAt(i);
                        Legs.Add(legInput);
                    }
                }
            }
        }

        public override string ToString()
        {
            if (Head == null ||
                Torso == null ||
                Arms.Count < 2 ||
                Legs.Count < 2)
            {
                return "We need more parts!";
            }

            long totalEnergy = 0;
            totalEnergy += Head.Energy;
            totalEnergy += Torso.Energy;
            totalEnergy += Arms.Select(x => long.Parse(x.Energy.ToString())).Sum();
            totalEnergy += Legs.Select(x => long.Parse(x.Energy.ToString())).Sum();

            if (totalEnergy > Energy)
            {
                return "We need more power!";
            }

            StringBuilder sb = new StringBuilder();

            sb.Append("Jarvis:\r\n");
            sb.Append(Head.ToString());
            sb.Append(Torso.ToString());

            foreach (var arm in Arms
                .OrderBy(x => x.Energy))
            {
                sb.Append(arm.ToString());
            }

            foreach (var leg in Legs
                .OrderBy(x => x.Energy))
            {
                sb.Append(leg.ToString());
            }

            return sb.ToString();
        }
    }

    class Head
    {
        public int Energy { get; set; }

        public int IQ { get; set; }

        public string Material { get; set; }

        public Head(
          int energy,
          int iq,
          string material)
        {
            this.Energy = energy;
            this.IQ = iq;
            this.Material = material;
        }

        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format($"#Head:\r\n");
            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###IQ: {IQ}\r\n");
            result += string.Format($"###Skin material: {Material}\r\n");

            return result;
        }
    }

    class Torso
    {
        public int Energy { get; set; }

        public double ProcessorSize { get; set; }

        public string Material { get; set; }

        public Torso(
            int energy,
            double processorSize,
            string corpusMaterial)
        {
            this.Energy = energy;
            this.ProcessorSize = processorSize;
            this.Material = corpusMaterial;
        }

        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format($"#Torso:\r\n");
            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###Processor size: {ProcessorSize:F1}\r\n");
            result += string.Format($"###Corpus material: {Material}\r\n");

            return result;
        }
    }

    class Arm
    {
        public int Energy { get; set; }

        public int Reach { get; set; }

        public int Fingers { get; set; }

        public Arm(
            int energy,
            int reach,
            int countFingers)
        {
            this.Energy = energy;
            this.Reach = reach;
            this.Fingers = countFingers;
        }

        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format($"#Arm:\r\n");
            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###Reach: {Reach}\r\n");
            result += string.Format($"###Fingers: {Fingers}\r\n");

            return result;
        }
    }

    class Leg
    {
        public int Energy { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }

        public Leg(
            int energy,
            int strength,
            int speed)
        {
            this.Energy = energy;
            this.Strength = strength;
            this.Speed = speed;
        }

        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format($"#Leg:\r\n");
            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###Strength: {Strength}\r\n");
            result += string.Format($"###Speed: {Speed}\r\n");

            return result;
        }
    }
}

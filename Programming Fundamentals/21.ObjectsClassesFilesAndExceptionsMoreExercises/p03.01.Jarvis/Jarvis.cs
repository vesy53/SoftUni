namespace p03._01.Jarvis
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Jarvis
    {
        static void Main(string[] args)
        {
            long maxEnergy = long.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Robot robot = new Robot();

            while (input.Equals("Assemble!") == false)
            {
                string[] inputTokens = input
                    .Split();

                string typeComponent = inputTokens[0];
                int energyConsumption = int.Parse(inputTokens[1]);

                if (typeComponent.Equals("Head"))
                {
                    int iq = int.Parse(inputTokens[2]);
                    string skinMaterial = inputTokens[3];

                    Head newHead = new Head
                    (
                        energyConsumption,
                        iq,
                        skinMaterial
                    );

                    if (robot.Head == null)
                    {
                        robot.Head = newHead;
                    }
                    else if (newHead.EnergyConsumption < robot.Head.EnergyConsumption)
                    {
                        robot.Head = newHead;
                    }
                }
                else if (typeComponent.Equals("Torso"))
                {
                    double procesorSize = double.Parse(inputTokens[2]);
                    string housingMaterial = inputTokens[3];

                    Torso newTorso = new Torso
                    (
                        energyConsumption,
                        procesorSize,
                        housingMaterial
                    );

                    if (robot.Torso == null)
                    {
                        robot.Torso = newTorso;
                    }
                    else if (newTorso.EnergyConsumption < robot.Torso.EnergyConsumption)
                    {
                        robot.Torso = newTorso;
                    }
                }
                else if (typeComponent.Equals("Arm"))
                {
                    int reach = int.Parse(inputTokens[2]);
                    int countFingers = int.Parse(inputTokens[3]);

                    Arm newArm = new Arm
                    (
                        energyConsumption,
                        reach,
                        countFingers
                    );

                    robot.Arms.Add(newArm);
                    robot.Arms = robot
                        .Arms
                        .OrderBy(x => x.EnergyConsumption)
                        .ToList();

                    if (robot.Arms.Count > 2)
                    {
                        robot.Arms = robot
                            .Arms
                            .Take(2)
                            .ToList();
                    }
                }
                else if (typeComponent.Equals("Leg"))
                {
                    int strength = int.Parse(inputTokens[2]);
                    int speed = int.Parse(inputTokens[3]);

                    Leg newLeg = new Leg
                    (
                        energyConsumption,
                        strength,
                        speed
                    );

                    robot.Legs.Add(newLeg);
                    robot.Legs = robot
                        .Legs
                        .OrderBy(x => x.EnergyConsumption)
                        .ToList();

                    if (robot.Legs.Count > 2)
                    {
                        robot.Legs = robot
                            .Legs
                            .Take(2)
                            .ToList();
                    }
                }

                input = Console.ReadLine();
            }

            if (robot.Arms.Count > 1 && robot.Head != null &&
                robot.Legs.Count > 1 && robot.Torso != null)
            {
                long consumedEnergy =
               robot.Arms.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption +
               robot.Arms.OrderBy(x => x.EnergyConsumption).Skip(1).Take(1).First().EnergyConsumption +
               robot.Legs.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption +
               robot.Legs.OrderBy(x => x.EnergyConsumption).Skip(1).Take(1).First().EnergyConsumption +
               robot.Head.EnergyConsumption +
               robot.Torso.EnergyConsumption;

                if (consumedEnergy > maxEnergy)
                {
                    Console.WriteLine("We need more power!");
                }
                else
                {
                    Console.WriteLine("Jarvis:");
                    Console.WriteLine(robot.Head.ToString());
                    Console.WriteLine(robot.Torso.ToString());

                    foreach (var arm in robot.Arms)
                    {
                        Console.WriteLine(arm);
                    }

                    foreach (var leg in robot.Legs)
                    {
                        Console.WriteLine(leg);
                    }
                }
            }
            else
            {
                Console.WriteLine("We need more parts!");
            }
        }
    }

    class Robot
    {
        public Head Head { get; set; }

        public Torso Torso { get; set; }

        public List<Arm> Arms = new List<Arm>();

        public List<Leg> Legs = new List<Leg>();
    }

    class Head
    {
        public int EnergyConsumption { get; set; }

        public int IQ { get; set; }

        public string SkinMaterial { get; set; }

        public Head(
            int energy,
            int iq,
            string skinMaterial)
        {
            this.EnergyConsumption = energy;
            this.IQ = iq;
            this.SkinMaterial = skinMaterial;
        }

        public override string ToString()
        {
            string result = $"#Head:\r\n";
            result += $"###Energy consumption: {EnergyConsumption}\r\n";
            result += $"###IQ: {IQ}\r\n";
            result += $"###Skin material: {SkinMaterial}";

            return result;
        }
    }

    class Torso
    {
        public int EnergyConsumption { get; set; }

        public double ProcessorSize { get; set; }

        public string HousingMaterial { get; set; }

        public Torso(
            int energy,
            double processorSize,
            string corpusMaterial)
        {
            this.EnergyConsumption = energy;
            this.ProcessorSize = processorSize;
            this.HousingMaterial = corpusMaterial;
        }

        public override string ToString()
        {
            string result = $"#Torso:\r\n";
            result += $"###Energy consumption: {EnergyConsumption}\r\n";
            result += $"###Processor size: {ProcessorSize:F1}\r\n";
            result += $"###Corpus material: {HousingMaterial}";

            return result;
        }
    }

    class Arm
    {
        public int EnergyConsumption { get; set; }

        public int Reach { get; set; }

        public int CountOfFingers { get; set; }

        public Arm(
            int energy,
            int reach,
            int countFingers)
        {
            this.EnergyConsumption = energy;
            this.Reach = reach;
            this.CountOfFingers = countFingers;
        }

        public override string ToString()
        {
            string result = $"#Arm:\r\n";
            result += $"###Energy consumption: {EnergyConsumption}\r\n";
            result += $"###Reach: {Reach}\r\n";
            result += $"###Fingers: {CountOfFingers}";

            return result;
        }
    }

    class Leg
    {
        public int EnergyConsumption { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }

        public Leg(
            int energy,
            int strength,
            int speed)
        {
            this.EnergyConsumption = energy;
            this.Strength = strength;
            this.Speed = speed;
        }

        public override string ToString()
        {
            string result = $"#Leg:\r\n";
            result += $"###Energy consumption: {EnergyConsumption}\r\n";
            result += $"###Strength: {Strength}\r\n";
            result += $"###Speed: {Speed}";

            return result;
        }
    }
}

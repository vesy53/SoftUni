namespace p03._002.Jarvis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Jarvis02
    {
        static void Main(string[] args)
        {
            long maxEnergy = long.Parse(Console.ReadLine());

            Robot robot = new Robot();

            ReadPartsForRobotJarvis(robot);

            PrintRobotStatus(maxEnergy, robot);
        }

        static void PrintRobotStatus(long maxEnergy, Robot robot)
        {

            if (robot.TotalEnergy > maxEnergy)
            {
                Console.WriteLine("We need more power!");
            }
            else if (robot.Head == null || robot.Torso == null ||
                robot.Arms.Count != 2 || robot.Legs.Count != 2)
            {
                Console.WriteLine("We need more parts!");
            }
            else
            {
                Console.WriteLine("Jarvis:"); 
                Console.WriteLine(robot.Head);
                Console.WriteLine(robot.Torso);

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

        static void ReadPartsForRobotJarvis(Robot robot)
        {
            string command = Console.ReadLine();

            while (command != "Assemble!")
            {
                string part = command
                    .Split(' ')
                    .First();
                string[] partSepcs = command
                    .Split(' ')
                    .Skip(1)
                    .ToArray();

                switch (part)
                {
                    case "Head":
                        TakeHead(robot, partSepcs);
                        break;
                    case "Torso":
                        TakeTorso(robot, partSepcs);
                        break;
                    case "Arm":
                        TakeArm(robot, partSepcs);
                        break;
                    case "Leg":
                        TakeLeg(robot, partSepcs);
                        break;
                }

                command = Console.ReadLine();
            }
        }

        static void TakeLeg(Robot robot, string[] partSepcs)
        {
            Leg newLeg = new Leg
            {
                Energy = int.Parse(partSepcs[0]),
                Strenght = int.Parse(partSepcs[1]),
                Speed = int.Parse(partSepcs[2])
            };

            robot.Legs.Add(newLeg);
            robot.Legs = robot
                .Legs
                .OrderBy(ec => ec.Energy)
                .ToList();

            if (robot.Legs.Count > 2)
            {
                robot.Legs = robot.Legs.Take(2).ToList();
            }
        }

        static void TakeArm(Robot robot, string[] partSepcs)
        {
            Arm newArm = new Arm
            {
                Energy = int.Parse(partSepcs[0]),
                Reach = int.Parse(partSepcs[1]),
                FingersCount = int.Parse(partSepcs[2])
            };

            robot.Arms.Add(newArm);
            robot.Arms = robot
                .Arms
                .OrderBy(ec => ec.Energy)
                .ToList();

            if (robot.Arms.Count > 2)
            {
                robot.Arms = robot.Arms.Take(2).ToList();
            }
        }

        static void TakeTorso(Robot robot, string[] partSepcs)
        {
            Torso newTorso = new Torso
            {
                Energy= int.Parse(partSepcs[0]),
                ProcessorSize = double.Parse(partSepcs[1]),
                Material = partSepcs[2]
            };

            if (robot.Torso == null)
            {
                robot.Torso = newTorso;
            }
            else if (newTorso.Energy < robot.Torso.Energy)
            {
                robot.Torso = newTorso;
            }
        }

        static void TakeHead(Robot robot, string[] partSepcs)
        {
            Head newHead = new Head
            {
                Energy = int.Parse(partSepcs[0]),
                IQ = int.Parse(partSepcs[1]),
                Material = partSepcs[2]
            };

            if (robot.Head == null)
            {
                robot.Head = newHead;
            }
            else if (newHead.Energy < robot.Head.Energy)
            {
                robot.Head = newHead;
            }
        }
    }

    class Robot
    {
        public Head Head { get; set; }

        public Torso Torso { get; set; }

        public List<Arm> Arms = new List<Arm>();

        public List<Leg> Legs = new List<Leg>();

        public long TotalEnergy
        {
            get
            {
                int totalEnergy = Head != null ? Head.Energy : 0;
                totalEnergy += Torso != null ? Torso.Energy : 0;

                foreach (var arm in Arms)
                {
                    totalEnergy += arm.Energy;
                }

                foreach (var leg in Legs)
                {
                    totalEnergy += leg.Energy;
                }

                return totalEnergy;
            }
        }
    }

    class Head
    {
        public int Energy { get; set; }

        public int IQ { get; set; }

        public string Material { get; set; }

        public override string ToString()
        {
            string result = string.Format($"#Head:\r\n");
            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###IQ: {IQ}\r\n");
            result += string.Format($"###Skin material: {Material}");

            return result;
        }
    }

    class Torso
    {
        public int Energy { get; set; }

        public double ProcessorSize { get; set; }

        public string Material { get; set; }

        public override string ToString()
        {
            string result = string.Format($"#Torso:\r\n");

            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###Processor size: {ProcessorSize:F1}\r\n");
            result += string.Format($"###Corpus material: {Material}");

            return result;
        }
    }


    class Arm
    {
        public int Energy { get; set; }
        public int Reach { get; set; }
        public int FingersCount { get; set; }

        public override string ToString()
        {
            string result = string.Format($"#Arm:\r\n");

            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###Reach: {Reach}\r\n");
            result += string.Format($"###Fingers: {FingersCount}");

            return result;
        }
    }

    class Leg
    {
        public int Energy { get; set; }

        public int Strenght { get; set; }

        public int Speed { get; set; }

        public override string ToString()
        {
            string result = string.Format($"#Leg:\r\n");

            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###Strength: {Strenght}\r\n");
            result += string.Format($"###Speed: {Speed}");

            return result;
        }
    }
}

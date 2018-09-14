namespace p03Jarvis
{
    using System;

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
}

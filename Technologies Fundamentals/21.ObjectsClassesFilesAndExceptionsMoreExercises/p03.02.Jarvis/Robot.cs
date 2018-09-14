using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarvis
{
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
}

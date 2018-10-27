using System;
using System.Collections.Generic;
using System.Text;

namespace Jarvis
{
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Jarvis
{
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
}

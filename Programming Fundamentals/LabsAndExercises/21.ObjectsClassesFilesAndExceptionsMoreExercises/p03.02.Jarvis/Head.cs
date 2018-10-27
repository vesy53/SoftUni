using System;
using System.Collections.Generic;
using System.Text;

namespace Jarvis
{
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
}

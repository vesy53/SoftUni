using System;
using System.Collections.Generic;
using System.Text;

namespace Jarvis
{
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
}

using System;

namespace TestEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num0 = (int)Mode.Energy;
            //int num1 = (int)Mode.Full;
            //int num2 = (int)Mode.Half;

            //Console.WriteLine(num0);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //int nums = 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 * 0 + 1;
            //
            //Console.WriteLine(nums);

            string modeStr = "Full";

            if (Enum.TryParse(modeStr, out Mode currMode))
            {
                int num = (int)currMode;

                Console.WriteLine($"{currMode} - {num}");
            }

            Mode mode = Mode.Half;
            int indexEnum = 0;
            double doubleIndex = 0;

            switch (mode)
            {
                case Mode.Energy:
                    indexEnum = (int)Mode.Energy;
                    doubleIndex = (double)Mode.Energy;
                    break;
                case Mode.Full:
                    indexEnum = (int)Mode.Full;
                    doubleIndex = (double)Mode.Full;
                    break;
                case Mode.Half:
                    indexEnum = (int)Mode.Half;
                    doubleIndex = (double)Mode.Half;
                    break;
            }

            Console.WriteLine($"Swich enum -> {indexEnum}");
            Console.WriteLine($"Switch double enum -> {doubleIndex}");
        }
    }

    public enum Mode
    {
        Energy = 0,
        Full = 1,
        Half = 2
    }
}

namespace p05._01.ConvertToDouble
{
    using System;

    class ConvertToDouble
    {
        public static void Main(string[] args)
        {
            string[] values =
            {
                "-1,035.77219", "1AFF", "1e-35",
                "1,635,592,999,999,999,999,999,999",
                "-17.455", "190.34001", "1.29e325"
            };

            foreach (string value in values)
            {
                try
                {
                    double result = Convert.ToDouble(value);

                    Console.WriteLine(
                        $"Converted '{value}' to {result}.");
                }
                catch (FormatException)
                {
                    Console.WriteLine(
                        $"Unable to convert '{value}' to a Double.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine(
                        $"'{value}' is outside the range of a Double.");
                }
            }
        }
    }
}

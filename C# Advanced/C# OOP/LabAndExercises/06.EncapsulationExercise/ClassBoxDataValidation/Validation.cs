namespace p02._01.ClassBoxDataValidation
{
    using System;

    public static class Validation
    {
        private const int MinValue = 0;

        public static void ValidateValue(
            double value,
            string side)
        {
            if (value <= MinValue)
            {
                throw new ArgumentException(
                    $"{side} cannot be zero or negative.");
            }
        }
    }
}

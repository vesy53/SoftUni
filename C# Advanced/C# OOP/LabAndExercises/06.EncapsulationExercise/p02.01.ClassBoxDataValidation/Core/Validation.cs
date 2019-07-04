namespace p02._01.ClassBoxDataValidation.Core
{
    using System;

    public static class Validation
    {
        public static void ValidateElement(
            double value,
            string parameter)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"{parameter} cannot be zero or negative.");
            }
        }
    }
}

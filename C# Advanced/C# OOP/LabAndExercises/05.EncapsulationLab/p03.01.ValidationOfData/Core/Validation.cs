namespace p03._01.ValidationOfData.Core
{
    using System;

    public static class Validation
    {
        private const int DefaultMinLength = 3;
        private const int MinAge = 0;
        private const int MinSalary = 460;

        public static void ValidateName(
            string value,
            string parameter)
        {
            if (value.Length < DefaultMinLength)
            {
                throw new ArgumentException(
                    $"{parameter} name cannot contain fewer than 3 symbols!");
            }
        }

        public static void ValidateAge(int value)
        {
            if (value < MinAge)
            {
                throw new ArgumentException(
                    "Age cannot be zero or a negative integer!");
            }
        }

        public static void ValidateSalary(decimal value)
        {
            if (value < MinSalary)
            {
                throw new ArgumentException(
                    "Salary cannot be less than 460 leva!");
            }
        }
    }
}

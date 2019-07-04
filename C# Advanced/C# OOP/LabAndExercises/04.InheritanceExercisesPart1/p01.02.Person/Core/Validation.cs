namespace p01._02.Person.Core
{
    using System;

    public static class Validation
    {
        public static void ValidateName(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException(
                    "Name's length should not be less than 3 symbols!");
            }
        }

        public static void ValidateAgeIsNegative(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
        }

        public static void ValidateAge(int value)
        {
            if (value > 15)
            {
                throw new ArgumentException(
                    "Child's age must be less than 15!");
            }
        }
    }
}

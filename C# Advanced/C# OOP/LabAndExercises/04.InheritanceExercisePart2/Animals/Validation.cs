namespace Animals
{
    using System;

    public static class Validation
    {
        private static int DefaultAge = 0;

        public static void ValidateName(string value)
        {
            ValidateValue(value);
        }

        public static void ValidateAge(int value)
        {
            if (value < DefaultAge)
            {
                ThrowException();
            }
        }

        public static void ValidateGender(string value)
        {
            ValidateValue(value);
        }

        private static void ValidateValue(string value)
        {
            if (value == null ||
                string.IsNullOrEmpty(value))
            {
                ThrowException();
            }
        }

        private static void ThrowException()
        {
            throw new Exception("Invalid input");
        }
    }
}

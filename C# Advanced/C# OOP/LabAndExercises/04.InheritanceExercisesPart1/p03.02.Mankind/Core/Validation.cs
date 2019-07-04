namespace p03._02.Mankind.Core
{
    using System;
    using System.Linq;

    public static class Validation
    {
        public static void ValidateName(
            string value,
            int defaultLengthName,
            string parameter)
        {
            char firstLetter = value[0];

            if (!char.IsUpper(firstLetter))
            {
                throw new ArgumentException(
                    $"Expected upper case letter! Argument: {parameter}");
            }
            else if (value.Length < defaultLengthName)
            {
                throw new ArgumentException(
                    $"Expected length at least {defaultLengthName} symbols! Argument: {parameter}");
            }
        }

        public static void ValidateFacultyNumber(
            string value, 
            int defaultMinLength, 
            int defaultMaxLength)
        {
            if (value.Length < defaultMinLength ||
                value.Length > defaultMaxLength ||
                !value.All(char.IsLetterOrDigit)) // value.Any(x => !char.IsLetterOrDigit(x))
            {
                throw new ArgumentException(
                    $"Invalid faculty number!");
            }
        }

        public static void ValidateWeekSalary(
            decimal value, 
            decimal defaultWeekSalary)
        {
            if (value <= defaultWeekSalary)
            {
                ThrowExeption("weekSalary");
            }
        }

        public static void ValidateWorkHoursPerDay(
            decimal value,
            decimal minWorkHoursPerDay,
            decimal maxWorkHoursPerDay)
        {
            if (value < minWorkHoursPerDay ||
                value > maxWorkHoursPerDay)
            {
                ThrowExeption("workHoursPerDay");
            }
        }

        private static void ThrowExeption(string parameter)
        {
            throw new ArgumentException(
               $"Expected value mismatch! Argument: {parameter}");
        }
    }
}

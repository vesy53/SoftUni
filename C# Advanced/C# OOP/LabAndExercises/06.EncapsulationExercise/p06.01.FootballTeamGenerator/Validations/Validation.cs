namespace p06._01.FootballTeamGenerator.Validations
{
    using System;

    public static class Validation
    {
        private const int MinStatValue = 0;
        private const int MaxStatValue = 100;

        // Validation in class Engine
        public static void ValidateMissingTeam(string teamName)
        {
            throw new ArgumentException(
                string.Format(
                    ExceptionsMessages
                    .InvalidTeamName,
                        teamName));
        }

        // Validation team
        public static void ValidateMissingPlayer(
            string playerName,
            string teamName)
        {
            throw new ArgumentException(
                string.Format(
                    ExceptionsMessages
                    .MissingPlayer, 
                        playerName, 
                        teamName));
        }

        // Validation player name
        public static void ValidateName(string value)
        {
            if (string.IsNullOrEmpty(value) ||
                string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    ExceptionsMessages.EmptyPlayerName);
            }
        }

        // Validation stat
        public static void ValidateValue(
            int value,
            string statName)
        {
            if (value < MinStatValue ||
                value > MaxStatValue)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptionsMessages
                        .InvalidStatName,
                            statName));
            }
        }
    }
}

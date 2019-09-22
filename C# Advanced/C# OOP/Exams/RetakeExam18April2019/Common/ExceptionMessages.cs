namespace PlayersAndMonsters.Common
{
    public static class ExceptionMessages
    {
        public const string InvalidUsername =
            "Player's username cannot be null or an empty string.";

        public const string InvalidHealth =
            "Player's health bonus cannot be less than zero.";

        public const string InvalidDamagePoints =
            "Damage points cannot be less than zero.";

        public const string InvalidCardsName =
            "Card's name cannot be null or an empty string.";

        public const string InvalidCardsPoints =
            "Card's {0} cannot be less than zero.";

        //public const string InvalidCardsDamagePoints =
        //    "Card's damage points cannot be less than zero.";
        //public const string InvalidCardsHP =
        //    "Card's HP cannot be less than zero.";

        public const string DeadPlayer = "Player is dead!";

        public const string InvalidCard = "Card cannot be null!";

        public const string ExistCardName = "Card {0} already exists!";

        public const string InvalidPlayer = "Player cannot be null";

        public const string ExistPlayerUsername = "Player {0} already exists!";
    }
}

namespace PlayersAndMonsters.Common
{
    public class ExceptionMessages
    {
        public const string InvalidUsername =
            "Player's username cannot be null or an empty string.";

        public const string InvalidHealth =
            "Player's health bonus cannot be less than zero.";

        public const string InvalidDamagePoints =
            "Damage points cannot be less than zero.";

        public const string InvalidCardName =
            "Card's name cannot be null or an empty string.";

        public const string InvalidPoints =
            "Card's {0} cannot be less than zero.";

        public const string DeadPlayer = "Player is dead!";

        public const string InvalidPlayer = "Player cannot be null";

        public const string ExistPlayer = "Player {0} already exists!";

        public const string InvalidCard = "Card cannot be null!";

        public const string ExistCard = "Card {0} already exists!";
    }
}

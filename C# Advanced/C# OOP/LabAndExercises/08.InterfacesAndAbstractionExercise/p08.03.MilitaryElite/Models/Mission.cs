namespace p08._03.MilitaryElite.Models
{
    using System;

    using p08._03.MilitaryElite.Contracts;
    using p08._03.MilitaryElite.Enums;
    using p08._03.MilitaryElite.Exceptions;

    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;

            ParseState(state);
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            if (this.State == State.Finished)
            {
                throw new InvalidMissionCopletionException();
            }
        }

        private void ParseState(string stateStr)
        {
            bool parsed = Enum
                .TryParse(stateStr, out State state);

            if (!parsed)
            {
                throw new InvalidStateException();
            }

            this.State = state;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
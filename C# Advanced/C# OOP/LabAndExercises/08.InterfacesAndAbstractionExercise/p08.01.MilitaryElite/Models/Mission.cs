namespace p08._01.MilitaryElite.Models
{
    using System;
    using System.Text;

    using p08._01.MilitaryElite.Contracts;
    using p08._01.MilitaryElite.Enums;

    public class Mission : IMission
    {
        public Mission(string codeName, string stateStr)
        {
            this.CodeName = codeName;

            ParseState(stateStr);
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            if (this.State == State.Finished)
            {
                throw new ArgumentException();
            }
        }

        private void ParseState(string stateStr)
        {
            bool isExistState = Enum
                .TryParse(stateStr, out State state);

            if (!isExistState)
            {
                throw new ArgumentException();
            }

            this.State = state;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .Append($"Code Name: {this.CodeName}")
                .Append($" State: {this.State}");

            return builder.ToString();
        }
    }
}

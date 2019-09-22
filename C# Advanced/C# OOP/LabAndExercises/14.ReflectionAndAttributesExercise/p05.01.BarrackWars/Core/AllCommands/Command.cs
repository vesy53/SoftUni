namespace p05._01.BarrackWars.Core.AllCommands
{
    using p05._01.BarrackWars.Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;

        protected Command(string[] data)
        {
            this.Data = data;
        }

        public string[] Data
        {
            get => this.data;
            private set => this.data = value;
        }

        public abstract string Execute();
    }
}

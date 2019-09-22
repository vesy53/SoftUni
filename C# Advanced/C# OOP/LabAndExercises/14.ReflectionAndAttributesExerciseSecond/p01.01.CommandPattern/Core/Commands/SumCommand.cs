namespace p01._01.CommandPattern.Core.Commands
{
    using System.Linq;

    using p01._01.CommandPattern.Core.Contracts;

    public class SumCommand : ICommand
    {
        public string Execute(string[] args)
        {
            int[] numbers = args
                .Select(int.Parse)
                .ToArray();

            long sum = numbers
                .Sum(n => n);

            return $"Current Sum: {sum}";
        }
    }
}

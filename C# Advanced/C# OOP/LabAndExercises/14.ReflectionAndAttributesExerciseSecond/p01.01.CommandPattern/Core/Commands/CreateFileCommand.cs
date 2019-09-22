namespace p01._01.CommandPattern.Core.Commands
{
    using System;
    using System.IO;
    using System.Linq;

    using p01._01.CommandPattern.Core.Contracts;

    public class CreateFileCommand : ICommand
    {
        public string Execute(string[] args)
        {
            string fileName = args[0];

            string content = string.Empty;

            if (args.Length > 1)
            {
                string[] arrayContent = args
                    .Skip(1)
                    .ToArray();

                content += String.Join(" ", arrayContent);
            }

            File.WriteAllText(fileName, content);

            return $"File {fileName} create successfully";
        }
    }
}

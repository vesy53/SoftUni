namespace p01._02.HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            Type type = typeof(HarvestingFields);

            FieldInfo[] fieldInfos = type
                .GetFields(BindingFlags.Instance |
                           BindingFlags.Public |
                           BindingFlags.NonPublic);

            string command = Console.ReadLine();

            while (command.Equals("HARVEST") == false)
            {
                FieldInfo[] newFieldInfos = type
                    .GetFields(BindingFlags.Default);

                if (command == "private")
                {
                    newFieldInfos = fieldInfos
                         .Where(f => f.Attributes.ToString() == "Private")
                         .ToArray();

                    PrintTheResult(newFieldInfos);
                }
                else if (command == "protected")
                {
                    newFieldInfos = fieldInfos
                        .Where(f => f.Attributes.ToString() == "Family")
                        .ToArray();

                    PrintTheResult(newFieldInfos);
                }
                else if (command == "public")
                {
                    newFieldInfos = fieldInfos
                        .Where(f => f.Attributes.ToString() == "Public")
                        .ToArray();

                    PrintTheResult(newFieldInfos);
                }
                else if (command == "all")
                {
                    PrintTheResult(fieldInfos);
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintTheResult(FieldInfo[] fieldInfos)
        {
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                string accessModifier = fieldInfo
                    .Attributes
                    .ToString()
                    .ToLower()
                    .Replace("family", "protected");
                string fieldType = fieldInfo.FieldType.Name;
                string fieldName = fieldInfo.Name;

                Console.WriteLine(
                    $"{accessModifier} {fieldType} {fieldName}");
            }
        }
    }
}

namespace p01._01.HarvestingFields
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
                .GetFields(BindingFlags.Default);

            string command = Console.ReadLine();

            while (command.Equals("HARVEST") == false)
            {
                if (command == "private")
                {
                    fieldInfos = type
                        .GetFields(BindingFlags.Instance |
                                   BindingFlags.NonPublic)
                         .Where(f => f.Attributes.ToString() != "Family")
                         .ToArray();

                    PrintTheResult(fieldInfos);
                }
                else if (command == "protected")
                {
                    fieldInfos = type
                        .GetFields(BindingFlags.Instance |
                                   BindingFlags.NonPublic)
                        .Where(f => f.Attributes.ToString() == "Family")
                        .ToArray();

                    PrintTheResult(fieldInfos);
                }
                else if (command == "public")
                {
                    fieldInfos = type
                        .GetFields(BindingFlags.Instance |
                                   BindingFlags.Public);

                    PrintTheResult(fieldInfos);
                }
                else if (command == "all")
                {
                    fieldInfos = type
                       .GetFields(BindingFlags.Instance |
                                  BindingFlags.Public |
                                  BindingFlags.NonPublic);

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

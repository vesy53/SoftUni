namespace p01._03.HarvestingFieldsTest
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            Type classType = Type
                .GetType("p01._03.HarvestingFields.HarvestingFields");

            FieldInfo[] fieldInfos = classType
                    .GetFields((BindingFlags)62);

            string command = Console.ReadLine();

            while (command.Equals("HARVEST") == false)
            {
                FieldInfo[] newFieldInfos = null;

                switch (command)
                {
                    case "private":
                        newFieldInfos = fieldInfos
                            .Where(f => f.IsPrivate)
                            .ToArray();

                        PrintTheResult(newFieldInfos);
                        break;
                    case "protected":
                        newFieldInfos = fieldInfos
                            .Where(f => f.IsFamily)
                            .ToArray();

                        PrintTheResult(newFieldInfos);
                        break;
                    case "public":
                        newFieldInfos = fieldInfos
                            .Where(f => f.IsPublic)
                            .ToArray();

                        PrintTheResult(newFieldInfos);
                        break;
                    case "all":
                        PrintTheResult(fieldInfos);
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintTheResult(FieldInfo[] newFieldInfos)
        {
            foreach (FieldInfo fieldInfo in newFieldInfos)
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

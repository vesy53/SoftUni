namespace p01._05.HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            Type classType = Type
                .GetType("p01._05.HarvestingFields.HarvestingFields");

            FieldInfo[] fieldInfos = classType.GetFields(
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic);

            string command = Console.ReadLine();

            while (command != "HARVEST")
            {
                IEnumerable<FieldInfo> printFieldInfo = null;

                switch (command)
                {
                    case "public":
                        printFieldInfo = fieldInfos
                            .Where(f => f.IsPublic);
                        break;
                    case "protected":
                        printFieldInfo = fieldInfos
                            .Where(f => f.IsFamily);
                        break;
                    case "private":
                        printFieldInfo = fieldInfos
                            .Where(f => f.IsPrivate);
                        break;
                    case "all":
                        printFieldInfo = fieldInfos;
                        break;
                }

                foreach (FieldInfo field in printFieldInfo)
                {
                    Print(field);
                }

                command = Console.ReadLine();
            }
        }

        private static void Print(FieldInfo field)
        {
            string access = null;

            switch (field.Attributes)
            {
                case FieldAttributes.Family:
                    access = "protected";
                    break;
                case FieldAttributes.Private:
                    access = "private";
                    break;
                case FieldAttributes.Public:
                    access = "public";
                    break;
            }

            string fieldString = string.Format(
                $"{access} {field.FieldType.Name} {field.Name}");

            Console.WriteLine(fieldString);
        }
    }
}

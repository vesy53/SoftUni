namespace p01._04.HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            Type type = typeof(HarvestingFields);

            FieldInfo[] fieldInfos = type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Instance);

            string input = Console.ReadLine();

            while (input.Equals("HARVEST") == false)
            {
                if (input != "all")
                {
                    FieldInfo[] fieldsToPrint = fieldInfos
                        .Where(f => f.Attributes
                                     .ToString()
                                     .Replace("Family", "protected")
                                     .ToLower() == input)
                        .ToArray();

                    foreach (FieldInfo field in fieldsToPrint)
                    {
                        string attribute = field
                            .Attributes
                            .ToString()
                            .ToLower()
                            .Replace("family", "protected");

                        Console.WriteLine(
                            $"{attribute} {field.FieldType.Name} {field.Name}");
                    }
                }
                else
                {
                    foreach (FieldInfo field in fieldInfos)
                    {
                        string attribute = field
                            .Attributes
                            .ToString()
                            .ToLower()
                            .Replace("family", "protected");

                        Console.WriteLine(
                            $"{attribute} {field.FieldType.Name} {field.Name}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}

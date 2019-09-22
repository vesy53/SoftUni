namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;


    public class Spy
    {
        public string StealFieldInfo(
            string investigatedClass,
            params string[] investigatedFields)
        {
            StringBuilder builder = new StringBuilder();

            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classField = classType
                .GetFields(
                    BindingFlags.Instance |
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Static);

            Object classInstance = Activator
                .CreateInstance(classType, new object[] { });

            builder
                .AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classField
                .Where(f => investigatedFields.Contains(f.Name)))
            {
                builder.AppendLine(
                    $"{field.Name} = {field.GetValue(classInstance)}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}

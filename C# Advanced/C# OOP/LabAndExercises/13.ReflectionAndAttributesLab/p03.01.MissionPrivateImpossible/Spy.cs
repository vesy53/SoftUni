using System;
using System.Reflection;
using System.Text;

public class Spy : ISpy
{
    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);

        MethodInfo[] methodInfos = classType
            .GetMethods(BindingFlags.Instance |
                        BindingFlags.NonPublic);

        StringBuilder builder = new StringBuilder();

        builder
            .AppendLine($"All Private Methods of Class: {className}");

        builder
            .AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in methodInfos)
        {
            builder
                .AppendLine(method.Name);
        }

        return builder.ToString().TrimEnd();
    }
}


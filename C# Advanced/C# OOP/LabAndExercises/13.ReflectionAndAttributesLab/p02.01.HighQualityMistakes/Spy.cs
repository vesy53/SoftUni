using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy : ISpy
{
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        FieldInfo[] fieldInfos = classType
            .GetFields(BindingFlags.Instance |
                       BindingFlags.Static |
                       BindingFlags.Public);

        MethodInfo[] publicMethodInfos = classType
            .GetMethods(BindingFlags.Instance |
                        BindingFlags.Public);
        MethodInfo[] nonPublicMethodInfos = classType
            .GetMethods(BindingFlags.Instance |
                        BindingFlags.NonPublic);

        StringBuilder builder = new StringBuilder();

        foreach (FieldInfo fieldInfo in fieldInfos)
        {
            builder
                .AppendLine($"{fieldInfo.Name} must be private!");
        }

        foreach (MethodInfo method in nonPublicMethodInfos
            .Where(m => m.Name.StartsWith("get")))
        {
            builder
                .AppendLine($"{method.Name} have to be public!");
        }

        foreach (MethodInfo method in publicMethodInfos
           .Where(m => m.Name.StartsWith("set")))
        {
            builder
                .AppendLine($"{method.Name} have to be private!");
        }

        return builder.ToString().TrimEnd();
    }
}


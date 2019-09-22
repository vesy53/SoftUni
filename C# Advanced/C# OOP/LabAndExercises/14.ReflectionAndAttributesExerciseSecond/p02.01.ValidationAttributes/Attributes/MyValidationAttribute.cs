namespace p02._01.ValidationAttributes.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool IsValid(object obj);
    }
}

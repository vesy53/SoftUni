public interface ISpy
{
    string StealFieldInfo(string investigatedClass, params string[] investigatedFields);
}

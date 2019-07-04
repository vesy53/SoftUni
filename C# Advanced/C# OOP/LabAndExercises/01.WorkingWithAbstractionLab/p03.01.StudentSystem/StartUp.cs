namespace p03._01.StudentSystem
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            StudentSystem studentSystem = new StudentSystem();

            while (true)
            {
                studentSystem.ParseCommand();
            }
        }
    }
}

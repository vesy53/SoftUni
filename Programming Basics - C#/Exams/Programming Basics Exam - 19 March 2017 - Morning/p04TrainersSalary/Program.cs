using System;

namespace p04TrainersSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine());
            double boudget = double.Parse(Console.ReadLine());

            double jelevCount = 0.0;
            double royalCount = 0.0;
            double roliCount = 0.0;
            double trofonCount = 0.0;
            double sinoCount = 0.0;
            double otherCount = 0.0;

            for (int i = 0; i < lectures; i++)
            {
                string nameLecturer = Console.ReadLine();

                if (nameLecturer == "Jelev")
                {
                    jelevCount++;
                }
                else if (nameLecturer == "RoYaL")
                {
                    royalCount++;
                }
                else if (nameLecturer == "Roli")
                {
                    roliCount++;
                }
                else if (nameLecturer == "Trofon")
                {
                    trofonCount++;
                }
                else if (nameLecturer == "Sino")
                {
                    sinoCount++;
                }
                else
                {
                    otherCount++;
                }
            }

            double everyLecture = boudget / lectures;

            Console.WriteLine(
                $"Jelev salary: {everyLecture * jelevCount:F2} lv");
            Console.WriteLine(
                $"RoYaL salary: {everyLecture * royalCount:F2} lv");
            Console.WriteLine(
                $"Roli salary: {everyLecture * roliCount:F2} lv");
            Console.WriteLine(
                $"Trofon salary: {everyLecture * trofonCount:F2} lv");
            Console.WriteLine
                ($"Sino salary: {everyLecture * sinoCount:F2} lv");
            Console.WriteLine(
                $"Others salary: {everyLecture * otherCount:F2} lv");
        }
    }
}

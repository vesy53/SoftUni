namespace p02._01.SoftUniCoursePlanning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ")
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("course start") == false)
            {
                string[] tokens = input
                    .Split(':');
                string command = tokens[0];
                string title = tokens[1];

                switch (command)
                {
                    case "Add":
                        if (!lessons.Contains(title))
                        {
                            lessons.Add(title);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[2]);

                        if (!lessons.Contains(title))
                        {
                            if (index >= 0 && index < lessons.Count)
                            {
                                lessons.Insert(index, title);
                            }
                        }
                        break;
                    case "Remove":
                        if (lessons.Contains(title))
                        {
                            if (lessons.Contains(title + "-Exercise"))
                            {
                                lessons.Remove(title + "-Exercise");
                            }

                            lessons.Remove(title);
                        }
                        break;
                    case "Swap":
                        string secondTitle = tokens[2];

                        if (lessons.Contains(title) && lessons.Contains(secondTitle))
                        {
                            int indexTitle = lessons.IndexOf(title);
                            int indexSecTitle = lessons.IndexOf(secondTitle);

                            lessons.RemoveAt(indexTitle);
                            lessons.Insert(indexTitle, secondTitle);
                            lessons.RemoveAt(indexSecTitle);
                            lessons.Insert(indexSecTitle, title);

                            if (lessons.Contains(title + "-Exercise"))                              
                            {
                                indexTitle = lessons.IndexOf(title);
                                int indexExercise = lessons.IndexOf(title + "-Exercise");

                                lessons.RemoveAt(indexExercise);
                                lessons.Insert(indexTitle + 1, title + "-Exercise");
                            }
                            else if (lessons.Contains(secondTitle + "-Exercise"))
                            {
                                indexSecTitle = lessons.IndexOf(secondTitle);
                                int indexSecExercise = lessons.IndexOf(secondTitle + "-Exercise");

                                lessons.RemoveAt(indexSecExercise);
                                lessons.Insert(indexSecTitle + 1, secondTitle + "-Exercise");
                            }
                        }
                        break;
                    case "Exercise":
                        if (lessons.Contains(title))
                        {
                           int titleIndex = lessons.IndexOf(title);

                            if (!lessons.Contains(title + "-Exercise"))
                            {
                                lessons.Insert(titleIndex + 1, title + "-Exercise");
                            }
                        }
                        else
                        {
                            lessons.Add(title);

                            int titleIndex = lessons.IndexOf(title);

                            if (!lessons.Contains(title + "-Exercise"))
                            {
                                lessons.Insert(titleIndex + 1, title + "-Exercise");
                            }
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            int count = 0;

            foreach (var lesson in lessons)
            {
                count++;

                Console.WriteLine($"{count}.{lesson}");                
            }
        }
    }
}

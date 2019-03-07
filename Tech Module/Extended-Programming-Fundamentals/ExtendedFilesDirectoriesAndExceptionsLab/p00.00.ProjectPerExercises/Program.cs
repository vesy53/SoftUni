namespace p00._00.ProjectPerExercises
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            //създаване на ф-л с текстово съдържание
            //string text = "Hello there" + Environment.NewLine + "I am Gosho";
            //File.WriteAllText("output.txt", text);

            //четене на ф-ла I-ви метод
            //string text = File.ReadAllText("output.txt");
            //Console.WriteLine(text);

            //четене на ф-ла II-ри метод
            //StreamReader reader = new StreamReader("output.txt");
            //string line = reader.ReadLine();
            //Console.WriteLine(line);

            //четене на ф-ла III-ти метод
            //StreamReader reader = new StreamReader("output.txt");
            //while (!reader.EndOfStream)
            //{
            //    string line = reader.ReadLine();
            //    Console.WriteLine(line);
            //}
            //reader.Close();//затваряме програмата( !!! ЗАДЪЛЖИТЕЛНО)

            //четене на ф-ла IV-ти метод
            //using (StreamReader reader = new StreamReader("output.txt"))
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        string line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}

            //променяме съдържанието на ф-ла
            //StreamWriter writer = new StreamWriter("output.txt");           
            //writer.WriteLine("Hello gays!");
            //writer.WriteLine("Pesho is here");
            //writer.WriteLine("Gosho is there");
            //writer.Close();

            //2-ри метод за промяна на съдържанието на ф-ла 
            //using (
            //StreamWriter writer = new StreamWriter("output.txt"))
            //{
            //    writer.WriteLine("Hello gays!");
            //    writer.WriteLine("Tony is here");
            //    writer.WriteLine("Didy is there");
            //}

            //2-ри метод за промяна на съдържанието на ф-ла с append
            //using (
            //    StreamWriter writer = new StreamWriter("output.txt", append: true))
            //{
            //    writer.WriteLine("Tony is here");
            //    writer.WriteLine("Didy is there");
            //}

            // FileInfo ни дава информация за ф-ла

            FileInfo fileInfo = new FileInfo("output.txt");
            Console.WriteLine(fileInfo.DirectoryName);// дава ни пътя до ф-ла
            Console.WriteLine(fileInfo.FullName);//дава нипълния път до ф-ла
            Console.WriteLine(fileInfo.Length);// дава ни байтовете
            Console.WriteLine(fileInfo.Length / 1024.0);//байтовете ги превръщаме в килобайтове
            Console.WriteLine(fileInfo.Extension); //дава разширението
            Console.WriteLine(fileInfo.CreationTime);//дава ни датата на създаване

            // създаваме директория
            string directory = "TestFolde";
            Directory.CreateDirectory(directory);

            //създаваме ф-лове които се намират в директорията
            //for (int i = 0; i < 10; i++)
            //{
            //    File.WriteAllText
            //        (directory +
            //        "/file-" + 
            //        i,
            //        "dummy-text");
            //}

            string[] files = Directory.GetFiles(directory);
            //създаваме име на ф-ловете
            /*   foreach (var fileName in files)
                 {
                     Console.WriteLine(fileName);
                 }  */
            //добавяме съдържание на ф-ловете
            for (int i = 0; i < files.Length; i++)
            {
                File.WriteAllText(
                    files[i],
                    "This is file number " +
                    (i + 1));
            }
        }
    }
}

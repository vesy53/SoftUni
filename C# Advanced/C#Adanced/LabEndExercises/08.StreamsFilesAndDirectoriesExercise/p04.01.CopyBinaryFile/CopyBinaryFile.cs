namespace p04._01.CopyBinaryFile
{
    using System.IO;

    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string sourceFile = "../../copyMe.png";
            string destinatioinPath = "../../copyMe-copy.png";

            using (FileStream readFile = new FileStream(sourceFile, FileMode.Open))
            {
                long size = readFile.Length;

                byte[] buffer = new byte[size];

                readFile.Read(buffer, 0, buffer.Length);

                using (FileStream writeFile = new FileStream(destinatioinPath, FileMode.Create))
                {
                    writeFile.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
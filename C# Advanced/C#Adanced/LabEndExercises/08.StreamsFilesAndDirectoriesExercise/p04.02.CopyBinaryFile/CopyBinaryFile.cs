namespace p04._02.CopyBinaryFile
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
                using (FileStream writeFile = new FileStream(destinatioinPath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int bytesCount = readFile.Read(buffer, 0, buffer.Length);

                        if (bytesCount == 0)
                        {
                            break;
                        }

                        writeFile.Write(buffer, 0, bytesCount);
                    }
                }
            }
        }
    }
}
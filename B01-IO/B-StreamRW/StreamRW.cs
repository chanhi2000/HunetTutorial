using System;
using System.IO;

namespace B_StreamRW
{
    public class StreamRw
    {
        public static void StreamReaderWriter()
        {
            Stream stream = File.OpenWrite("test1.txt");
            StreamWriter streamWriter = new StreamWriter(stream);
            streamWriter.WriteLine("Hello.net {0}, {1:C4}", "행복한 하루 입니다.", 10000);
            streamWriter.Flush();
            stream.Close();

            stream =  File.OpenRead("test1.txt");
            StreamReader StreamReader = new StreamReader(stream);
            string str = StreamReader.ReadLine();
            StreamReader.Close();
            Console.WriteLine(str);
        }

        public static void Main(string[] args)
        {
            StreamReaderWriter();
        }
    }
}
